using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.NINIRODIE.Repositorios;
using FrbaHotel.NINIRODIE.Clases;
using FrbaHotel.Generar_Modificar_Reserva;
using FrbaHotel.Registrar_Estadia;

namespace FrbaHotel.Cancelar_Reserva
{
    public partial class BuscarReserva : Form
    {

        public Reserva ReservaBuscada { get; set; }
        public Usuario usuario { get; set; }
        public ModoApertura modoApertura { get; set; }
        public Hotel hotelSeleccionado { get; set; }

        public BuscarReserva(Usuario user, ModoApertura modoApert)
        {
            InitializeComponent();
            usuario = user;
            modoApertura = modoApert;

            MessageBox.Show("El código de reserva solo debe contener Números", "Atención", MessageBoxButtons.OK);

        }

        public BuscarReserva(Usuario user, ModoApertura modoApert, Hotel hotelSelec) : this(user, modoApert)
        {
            hotelSeleccionado = hotelSelec;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (!Char.IsDigit(e.KeyChar) & !Char.IsControl(e.KeyChar));
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (codigoReservaTextBox.Text != "")
            {
                Decimal codigoReserva = Decimal.Parse(this.codigoReservaTextBox.Text);
                if (usuario.tipo != "CLIENTE")
                    ReservaBuscada = RepositorioReserva.Instance.BuscarReserva(codigoReserva);
                else
                    ReservaBuscada = RepositorioReserva.Instance.BuscarReservaDeUsuario(codigoReserva, usuario);


                if (ReservaBuscada.identificador != -1)
                {
                    if (this.compararFechaReservaConActual())
                    {
                        ModificacionSegunModoApertura();
                        this.Close();
                    }
                    else
                    {
                        InformarMotivoFallaModificacionCheckInOut();
                            
                        this.Close();
                    }
                }
                else
                {
                  //  if(modoApertura == ModoApertura.CANCELACION)
                        VerificarQueNoEsteCancelada();
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un Código de Reserva.", "Atención", MessageBoxButtons.OK);
            }
           
        }

        private void ModificacionSegunModoApertura()
        {
            if (modoApertura == ModoApertura.CANCELACION)
                new CancelarReserva(usuario, ReservaBuscada).ShowDialog(this);
            else
                if (modoApertura == ModoApertura.MODIFICACION)
                {
                    Hotel hotel = RepositorioHotel.Instance.BuscarHotelxId(ReservaBuscada.identificador_hotel);
                    new ModificarReserva(usuario, ReservaBuscada, hotel).ShowDialog(this);
                }
                else
                    RegistrarCheckInOutSiEsHotelCorrespondiente();
        }

        private void RegistrarCheckInOutSiEsHotelCorrespondiente()
        {
            if (hotelSeleccionado.identificador == ReservaBuscada.identificador_hotel)
            {
                if (!RepositorioEstadia.Instance.SeRegistroIngreso(ReservaBuscada) & modoApertura == ModoApertura.CHECKIN
                    | RepositorioEstadia.Instance.SeRegistroIngreso(ReservaBuscada) & modoApertura == ModoApertura.CHECKOUT)
                    new RegistrarIngresoEgreso(usuario, ReservaBuscada, modoApertura, hotelSeleccionado).ShowDialog(this);
                else
                {
                    if (modoApertura == ModoApertura.CHECKOUT)
                        MessageBox.Show("No puede realizarse el egreso porque \n" +
                                        "todavía no se ha realizado el ingreso.", "Atención", MessageBoxButtons.OK);
                    else
                        MessageBox.Show("El ingreso ya ha sido registrado.", "Atención", MessageBoxButtons.OK);
                    
                    this.Close();
                }
            }
            else
                MessageBox.Show("La reserva no corresponde a este hotel.", "Atención", MessageBoxButtons.OK);
        }

        private void InformarMotivoFallaModificacionCheckInOut()
        {
            if (modoApertura == ModoApertura.CANCELACION)
                MessageBox.Show("No puede realizarse la cancelación.\n" +
                            "Las cancelaciones pueden realizarse hasta\n" +
                            "el día anterior al comienzo de la reserva.",
                            "Atención", MessageBoxButtons.OK);
            else
            {
                if (modoApertura == ModoApertura.MODIFICACION)
                    MessageBox.Show("No puede realizarse una modificación sobre la reserva indicada.\n" +
                                    "Las modificaciones pueden realizarse hasta\n" +
                                    "el día anterior al comienzo de la reserva.",
                                     "Atención", MessageBoxButtons.OK);
                else
                    if (modoApertura == ModoApertura.CHECKIN)
                        if (FechaSistema.Instance.fecha.Date.CompareTo(ReservaBuscada.fechaDesde.Date) > 0)
                            MessageBox.Show("No puede realizarse el ingreso.\n" +
                                            "La reserva ya ha caducado.", "Atención", MessageBoxButtons.OK);
                        else
                            MessageBox.Show("No puede realizarse el ingreso.\n" +
                                            "Su reserva comienza el día: " +
                                            ReservaBuscada.fechaDesde.Date.ToString(), "Atención", MessageBoxButtons.OK);
            }
        }

        private void VerificarQueNoEsteCancelada()
        {
            Decimal codigoReserva = Decimal.Parse(this.codigoReservaTextBox.Text);
            Cancelacion cancel = RepositorioReserva.Instance.VerificarCancelacion(codigoReserva, usuario);
            if (cancel.codigo < 0)
                MessageBox.Show("La reserva no ha sido encontrada o usted no es el resposable de la misma.\n" +
                            "Asegurese de ingresar el código correctamente.\n", "Atención", MessageBoxButtons.OK);
            else
            {
                MessageBox.Show("La reserva ya ha sido cancelada el día: " + cancel.fechaCancelacion.ToString() +
                               "\nEl código de cancelación es: " + cancel.codigo.ToString() + "."
                               , "Atención", MessageBoxButtons.OK);
                
                this.Close();
            }
        }

        
        private bool compararFechaReservaConActual()
        {
            int resultadoComparacion = FechaSistema.Instance.fecha.Date.CompareTo(ReservaBuscada.fechaDesde.Date);

            if (modoApertura == ModoApertura.MODIFICACION | modoApertura == ModoApertura.CANCELACION)
                return resultadoComparacion < 0;
            else
                if(modoApertura == ModoApertura.CHECKIN)
                    return resultadoComparacion == 0;
                else
                    return true;
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}