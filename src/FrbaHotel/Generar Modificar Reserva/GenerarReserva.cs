using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.NINIRODIE.Clases;
using FrbaHotel.NINIRODIE.Repositorios;
using FrbaHotel.ABM_de_Cliente;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenerarReserva : Form
    {
        public Usuario usuario { get; set; }
        public Hotel hotel { get; set; }
        public Reserva reserva { get; set; }
        public Cliente cliente { get; set; }

        public GenerarReserva()
        {
            InitializeComponent();
            DesdeDateTimePicker.Value = FechaSistema.Instance.fecha;
            HastaDateTimePicker.Value = FechaSistema.Instance.fecha.AddDays(1);
        }

        public GenerarReserva(Usuario user, Hotel hotelSeleccionado) : this()
        {
            hotel = hotelSeleccionado;
            usuario = user;
            PopularComboBoxesYGrillas();

            if (usuario.tipo != "CLIENTE" & usuario.tipo != "GUEST")
            {
                this.hotelComboBox.SelectedItem = this.BuscarHotelRecepcionista();
                this.hotelComboBox.Refresh();
                this.hotelComboBox.Enabled = false;
            }
        }

        public GenerarReserva(Usuario user)
            : this()
        {
            usuario = user;
            PopularComboBoxesYGrillas();
        }

        private Hotel BuscarHotelRecepcionista()
        {
            Hotel hotelBuscado = hotel;

            foreach (Hotel hotelEnCombo in this.hotelComboBox.Items)
            {
                if(hotelEnCombo.identificador == hotel.identificador)
                    hotelBuscado = hotelEnCombo;
            }

            return hotelBuscado;
        }

        private void PopularComboBoxesYGrillas()
        {
            this.hotelComboBox.DataSource = new List<Hotel>();
            this.hotelComboBox.Refresh();
            this.hotelComboBox.DataSource = RepositorioHotel.Instance.BuscarHoteles();
            this.hotelComboBox.Refresh();
            this.hotelComboBox.DisplayMember = "Calle"; //Sería mejor poner el nombre pero hay varios que no tienen.
            if(hotel != null)
              PopularRegimen(hotel);

            this.HabitacionesDisponiblesDataGrid.DataSource = new List<Habitacion>();
            this.HabitacionesDisponiblesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.HabitacionesDisponiblesDataGrid.Columns["identificador"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["codigo_tipo"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["codigo_hotel"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["habilitada"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Refresh();

        }

        private void PopularRegimen(Hotel hotel)
        {
            this.RegimenDataGrid.DataSource = new List<Regimen>();
            this.RegimenDataGrid.Columns["identificador"].Visible = false;
            this.RegimenDataGrid.Columns["habilitado"].Visible = false;
            this.RegimenDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.RegimenDataGrid.DataSource = RepositorioRegimen.Instance.RegimenesPorHotel(hotel);
            this.RegimenDataGrid.Refresh();
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hotelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PopularRegimen((Hotel)this.hotelComboBox.SelectedItem);
        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
            if (DesdeDateTimePicker.Value < HastaDateTimePicker.Value)
            {
                if (FechaSistema.Instance.fecha.Date.CompareTo(this.DesdeDateTimePicker.Value.Date) < 0)
                {
                    List<Habitacion> habitacionesLibres =
                        RepositorioHabitacion.Instance.HabitacionesLibresEnFecha((Hotel)hotelComboBox.SelectedItem,
                            DesdeDateTimePicker.Value, HastaDateTimePicker.Value);

                    this.HabitacionesDisponiblesDataGrid.DataSource = habitacionesLibres;
                    this.HabitacionesDisponiblesDataGrid.Refresh();
                    this.CalcularPrecioHabitaciones();
                }
                else
                    MessageBox.Show("Nos encontramos en la fecha: " +
                                    FechaSistema.Instance.fecha.Date.ToShortDateString() + ".\n" +
                                    "No puede realizar una reserva con fecha anterior a esta.", "Atención",
                                    MessageBoxButtons.OK);
            }
            else
                    MessageBox.Show("La fecha de egreso no puede " +
                                    "ser anterior a la de ingreso.", "Atención", MessageBoxButtons.OK);
                
        }

        private void CalcularPrecioHabitaciones()
        {
            foreach (Habitacion habitacion in (List<Habitacion>)this.HabitacionesDisponiblesDataGrid.DataSource)
            {
                habitacion.cantidadPersonas = RepositorioHabitacion.Instance.CantidadPersonasParaHabitacion(habitacion);

                habitacion.precio = (((Regimen)this.RegimenDataGrid.CurrentRow.DataBoundItem).precio *
                                    habitacion.cantidadPersonas) + ((Hotel)hotelComboBox.SelectedItem).recarga;
            }
            this.HabitacionesDisponiblesDataGrid.Refresh();
        }

        private void RegimenDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            CalcularPrecioHabitaciones();
        }

        private void ConfirmarBoton_Click(object sender, EventArgs e)
        {
            if (HabitacionesDisponiblesDataGrid.SelectedRows.Count > 0)
            {
                DialogResult resultado = CalcularYMostrarPrecioTotal();
                VerificarHospedajaAnterior(resultado);
            }
            else 
            {
                MessageBox.Show("Debe seleccionar al menos una habitación \n" +
                                "para realizar una reserva", "Atención", MessageBoxButtons.OK);
            }
        }

        private DialogResult CalcularYMostrarPrecioTotal()
        {
            Decimal precioTotal = this.PrecioTotalPorHabitacionesSeleccionadas();

            DialogResult resultado = MessageBox.Show("El precio de su reserva es de $" +
                                                        precioTotal.ToString() + "\n" + "¿Desea continuar?"
                                                        , "Informe", MessageBoxButtons.YesNo);
            return resultado;
        }

        private Decimal PrecioTotalPorHabitacionesSeleccionadas()
        {
            Decimal precio = 0;
            for( int i = 0 ; i < this.HabitacionesDisponiblesDataGrid.SelectedRows.Count; i++ )
            {
                precio += ((Habitacion)this.HabitacionesDisponiblesDataGrid.SelectedRows[i].DataBoundItem).precio;
            }
            return precio;
        }

        private void VerificarHospedajaAnterior(DialogResult resultado)
        {

            if (resultado == DialogResult.Yes)
            {
                BuscarGenerarCliente();

                if (cliente.identificador != -1)
                {
                    ArmarReserva();
                    RealizarReserva();
                }
                else
                {
                    VolverAIntentarGenerarUsuarioOSalir();
                }
            }
        }

        private void VolverAIntentarGenerarUsuarioOSalir()
        {
            DialogResult volverAIntentar = MessageBox.Show("No se ha encontrado, ni se ha generado un nuevo cliente.\n" +
                                                   "¿Desea volver a intentarlo?", "Atención", MessageBoxButtons.YesNo);
            if (volverAIntentar == DialogResult.Yes)
                VerificarHospedajaAnterior(volverAIntentar);
            else
                this.Close();
        }

        private void RealizarReserva()
        {
            RepositorioReserva.Instance.GenerarReserva(reserva);
            if (usuario.tipo == "GUEST" | usuario.tipo == "CLIENTE")
                RepositorioUsuario.Instance.GenerarReserva(reserva, cliente);
            else
                RepositorioUsuario.Instance.GenerarReserva(reserva, cliente, usuario);
            for( int i = 0 ; i < this.HabitacionesDisponiblesDataGrid.SelectedRows.Count; i++ )
            {
                Habitacion habitacion = (Habitacion)this.HabitacionesDisponiblesDataGrid.SelectedRows[i].DataBoundItem;
                RepositorioHabitacion.Instance.ReservarHabitacion(reserva, habitacion);
            }

            MessageBox.Show("Su reserva ha sido generada exitosamente.\n" +
                            "Su código de reserva es: " + reserva.identificador.ToString() +
                            ".", "Información", MessageBoxButtons.OK);
            this.Close();
        }

        private void ArmarReserva()
        {
            reserva = new Reserva(-1, ((Hotel)this.hotelComboBox.SelectedItem).identificador,
                              ((Regimen)this.RegimenDataGrid.CurrentRow.DataBoundItem).identificador,
                              4000, this.DesdeDateTimePicker.Value, this.HastaDateTimePicker.Value);
        }

        private void BuscarGenerarCliente()
        {
            DialogResult result = MessageBox.Show("¿Se ha hospedado con anterioridad en nuestra cadena de hoteles?",
                                                   "Información", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                BuscarCliente();
            else
                GenerarClienteNuevo();
        }

        private void BuscarCliente()
        {
            using (var BusquedaCliente = new BuscarCliente())
            {
                DialogResult resultado = BusquedaCliente.ShowDialog(this);
                if (resultado == DialogResult.OK)
                {
                    cliente = BusquedaCliente.cliente;
                }
                else
                {
                    DialogResult generarNuevoUser = MessageBox.Show("No se ha encontrado al Cliente.\n" +
                                                             "¿Desea generar uno nuevo?", "Atención", MessageBoxButtons.YesNo);
                    if (generarNuevoUser == DialogResult.Yes)
                        this.GenerarClienteNuevo();
                    else
                        cliente = new Cliente();
                }
            }
        }

        private void GenerarClienteNuevo()
        {
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
        }

    }
}