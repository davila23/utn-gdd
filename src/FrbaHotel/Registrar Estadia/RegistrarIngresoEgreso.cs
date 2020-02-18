using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.NINIRODIE.Clases;
using FrbaHotel.ABM_de_Cliente;
using FrbaHotel.Generar_Modificar_Reserva;
using FrbaHotel.NINIRODIE.Repositorios;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class RegistrarIngresoEgreso : Form
    {
        public Usuario usuario { get; set; }
        public Reserva reserva { get; set; }
        public Decimal cantHuespedes { get; set; }
        public ModoApertura modoApertura { get; set; }
        public List<Habitacion> habitaciones { get; set; }
        public Hotel hotelSeleccionado { get; set; }
        public Decimal precio { get; set; }

        public RegistrarIngresoEgreso(Usuario user, Reserva reserv, ModoApertura modoApert, Hotel hotelSelecc)
        {
            InitializeComponent();
            usuario = user;
            reserva = reserv;
            modoApertura = modoApert;
            hotelSeleccionado = hotelSelecc;
            precio = 0;
            PopularGrillas();
            
            ModificarBotonesSegunTipoRegistro();
            if (ModoApertura.CHECKIN == modoApertura)
                MessageBox.Show("Recuerde ingresar los datos de todos los huéspedes.", "Atención", MessageBoxButtons.OK);
            
        }

        private void ModificarBotonesSegunTipoRegistro()
        {
            if (modoApertura == ModoApertura.CHECKOUT)
            {
                this.Text = "Registrar Egreso";
                this.BuscarClienteBoton.Dispose();
                this.GenericoBoton.Text = "Salir";
                this.RegistrarBoton.Text = "Registrar Egreso";

                this.RegistrarBoton.Click += new EventHandler(RegistrarEgresoBoton_Click);
                this.GenericoBoton.Click += new EventHandler(Salir_Click);
            }
            else
            {
                this.RegistrarBoton.Text = "Registrar Ingreso";
                this.RegistrarBoton.Click += new EventHandler(RegistrarIngresoBoton_Click);
                this.GenericoBoton.Text = "Nuevo Cliente";
                this.GenericoBoton.Click += new EventHandler(NuevoClienteBoton_Click);
            }
        }

        void RegistrarEgresoBoton_Click(object sender, EventArgs e)
        {
            Estadia estadia = RepositorioEstadia.Instance.BuscarEstadia(reserva);
            estadia.fechaHasta = FechaSistema.Instance.fecha;

            estadia.CalcularDiasAlojados();
            estadia.CalcularDiasNoAlojados(reserva.fechaHasta);
            estadia.precio = precio * (estadia.diasAlojados + estadia.diasNoAlojados);

            RepositorioEstadia.Instance.RegistrarEgreso(estadia);
            RepositorioReserva.Instance.ActualizarEstadoReserva(reserva, 4006);

            MessageBox.Show("El egreso se ha registrado.", "Informe", MessageBoxButtons.OK);

            this.Close();
        }

        private void PrecioPorHabitaciones()
        {
            Regimen regimen = RepositorioRegimen.Instance.BuscarRegimen(reserva.identificador_regimen);
            
            foreach (Habitacion habitacion in (List<Habitacion>)this.HabitacionesDataGrid.DataSource)
            {
                habitacion.cantidadPersonas = RepositorioHabitacion.Instance.CantidadPersonasParaHabitacion(habitacion);

                habitacion.precio = (regimen.precio * habitacion.cantidadPersonas) + hotelSeleccionado.recarga;
                precio += habitacion.precio; 
            }
            this.HabitacionesDataGrid.Refresh();
            
        }

        void Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PopularGrillas()
        {
            this.ReservaDataGrid.DataSource = new List<Reserva>() {reserva};
            this.ReservaDataGrid.Columns["identificador_hotel"].Visible = false;
            this.ReservaDataGrid.Columns["identificador_regimen"].Visible = false;
            this.ReservaDataGrid.Columns["identificador_estado"].Visible = false;
            this.ReservaDataGrid.Refresh();

            List<Habitacion> habitaciones = RepositorioHabitacion.Instance.HabitacionesReserva(reserva);
            foreach (Habitacion habit in habitaciones)
                habit.cantidadPersonas = RepositorioHabitacion.Instance.CantidadPersonasParaHabitacion(habit);
            
            cantHuespedes = habitaciones.Sum(habitacion => habitacion.cantidadPersonas);

            this.HabitacionesDataGrid.DataSource = habitaciones;
            this.HabitacionesDataGrid.Columns["identificador"].Visible = false;
            this.HabitacionesDataGrid.Columns["codigo_hotel"].Visible = false;
            this.HabitacionesDataGrid.Columns["codigo_tipo"].Visible = false;
            this.HabitacionesDataGrid.Columns["habilitada"].Visible = false;
            this.HabitacionesDataGrid.Refresh();

            this.PrecioPorHabitaciones();
        }

        private void NuevoClienteBoton_Click(object sender, EventArgs e)
        {
            GenerarClienteNuevo();
        }

        private void GenerarClienteNuevo()
        {
            Cliente cliente;
            using (var GenerarNuevoCliente = new AltaCli())
            {
                DialogResult resultado = GenerarNuevoCliente.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    cliente = GenerarNuevoCliente.cliente;
                }
                else
                    cliente = new Cliente();
            }

            AgregarCliente(cliente);
        }

        private void BuscarClienteBoton_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            using (var BusquedaCliente = new BuscarCliente())
            {
                DialogResult resultado = BusquedaCliente.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    cliente = BusquedaCliente.cliente;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado al Cliente.\n" +
                                "Debe generar un nuevo Cliente.", "Reporte", MessageBoxButtons.OK);
                    this.NuevoClienteBoton_Click(sender, e);
                }
            }
            if (cliente.identificador != -1)
                AgregarCliente(cliente);

        }

        private void AgregarCliente(Cliente cliente)
        {
            if (cliente.identificador != -1)
            {
                RepositorioUsuario.Instance.GenerarReserva(reserva, cliente);
                cantHuespedes--;
            }
        }

        private void RegistrarIngresoBoton_Click(object sender, EventArgs e)
        {
            if (cantHuespedes <= 0 )
            {
                Estadia estadia = RepositorioEstadia.Instance.BuscarEstadia(reserva);

                if (estadia.codigo == 0)
                {
                    RepositorioEstadia.Instance.RegistrarEstadia(reserva);
                    estadia = RepositorioEstadia.Instance.BuscarEstadia(reserva);
                }
                else
                    RepositorioEstadia.Instance.ActualizarIngreso(reserva);

                RepositorioReserva.Instance.ActualizarEstadoReserva(reserva, 4005); //CodigoReservaEfectivizada

                MessageBox.Show("El ingreso se ha registrado.\n" +
                                "Su número de estadia es: " +
                                estadia.codigo.ToString(), "Informe", MessageBoxButtons.OK);
                this.Close();
            }
            else
            {
                MessageBox.Show("Debe ingresar al menos " + cantHuespedes.ToString() + 
                                "\nclientes para poder realizar el ingreso.", "Atención", MessageBoxButtons.OK);
            }
        }
    }
}
