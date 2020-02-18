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

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class ModificarReserva : Form
    {
        public Usuario usuario { get; set; }
        public Hotel hotel { get; set; }
        public Reserva reserva { get; set; }
        public Cliente cliente { get; set; }
        public List<Habitacion> habitacionesReservadas { get; set; }
        public List<Habitacion> habitacionesDisponibles { get; set; }
        public List<Regimen> regimenesPosibles { get; set; }
        public List<Habitacion> habitacionesRemovidas { get; set; }
        public List<Habitacion> habitacionesAgregadas { get; set; }
        public Regimen regimenActual { get; set; }
        public Regimen regimenCambiado { get; set; }
        public int contador { get; set; }

        public ModificarReserva(Usuario user, Reserva reserve, Hotel hotelSelec)
        {
            InitializeComponent();
            usuario = user;
            reserva = reserve;
            hotel = hotelSelec;
            habitacionesRemovidas = new List<Habitacion>();
            habitacionesAgregadas = new List<Habitacion>();
            contador = 1;
            PopularComboBoxesYGrillas();

            this.hotelComboBox.SelectedItem = this.BuscarHotelReserva();
            this.hotelComboBox.Enabled = false;
            this.PopularRegimen();

            CalcularPrecioHabitaciones(this.HabitacionesReservadasDataGrid);
            CalcularPrecioHabitaciones(this.HabitacionesDisponiblesDataGrid);

            if (habitacionesDisponibles.Count == 0)
                MessageBox.Show("No hay habitaciones disponibles para la fecha de la reserva.",
                                "Atención", MessageBoxButtons.OK);
        }

        private void CalcularPrecioHabitaciones(DataGridView dataGridView)
        {
            foreach (Habitacion habitacion in (List<Habitacion>)dataGridView.DataSource)
            {
                habitacion.cantidadPersonas = RepositorioHabitacion.Instance.CantidadPersonasParaHabitacion(habitacion);

                habitacion.precio = (/*((Regimen)this.RegimenDataGrid.CurrentRow.DataBoundItem).precio*/ 
                    (this.RegimenParaCalculo()).precio * 
                                    habitacion.cantidadPersonas) + ((Hotel)hotelComboBox.SelectedItem).recarga;
            }
            dataGridView.Refresh();
        }

        private Regimen RegimenParaCalculo()
        {
            return regimenCambiado == null ? regimenActual : regimenCambiado;
        }

        private Hotel BuscarHotelReserva()
        {
            Hotel hotelBuscado = hotel;

            foreach (Hotel hotelEnCombo in this.hotelComboBox.Items)
            {
                if (hotelEnCombo.identificador == hotel.identificador)
                    hotelBuscado = hotelEnCombo;
            }

            return hotelBuscado;
        }

        private Regimen BuscarRegimenReserva()
        {
            Regimen regimenBuscado = new Regimen();

            foreach (Regimen regimenEnCombo in this.regimenesPosibles)
            {
                if (regimenEnCombo.identificador == reserva.identificador_regimen)
                    regimenBuscado = regimenEnCombo;
            }

            return regimenBuscado;
        }

        private void PopularComboBoxesYGrillas()
        {
            PopularHotel();
           
            PopularHabitacionesDisponibles();
            PopularHabitacionesReservadas();

            DesdeDateTimePicker.Value = reserva.fechaDesde;
            HastaDateTimePicker.Value = reserva.fechaHasta;
            contador = 2;
        }

        private void PopularHotel()
        {
            this.hotelComboBox.DataSource = new List<Hotel>();
            this.hotelComboBox.Refresh();
            this.hotelComboBox.DisplayMember = "Calle"; //Sería mejor poner el nombre pero hay varios que no tienen.
            this.hotelComboBox.DataSource = RepositorioHotel.Instance.BuscarHoteles();
            this.hotelComboBox.Refresh();
        }

        private void PopularHabitacionesReservadas()
        {
            this.habitacionesReservadas = RepositorioHabitacion.Instance.HabitacionesReserva(reserva);
         
            PoblarHabitacionesReservadas();
        }

        private void PoblarHabitacionesReservadas()
        {
            this.HabitacionesReservadasDataGrid.DataSource = new List<Habitacion>();
            this.HabitacionesReservadasDataGrid.Refresh();
            this.HabitacionesReservadasDataGrid.Columns["identificador"].Visible = false;
            this.HabitacionesReservadasDataGrid.Columns["codigo_tipo"].Visible = false;
            this.HabitacionesReservadasDataGrid.Columns["codigo_hotel"].Visible = false;
            this.HabitacionesReservadasDataGrid.Columns["habilitada"].Visible = false;

            this.HabitacionesReservadasDataGrid.DataSource = RepositorioHabitacion.Instance.HabitacionesReserva(reserva);
            this.HabitacionesReservadasDataGrid.Refresh();
        }

        private void PopularHabitacionesDisponibles()
        {
            this.habitacionesDisponibles =
                RepositorioHabitacion.Instance.HabitacionesLibresEnFechaParaReserva(hotel, reserva);
            PoblarHabitacionesDisponibles();
        }

        private void PoblarHabitacionesDisponibles()
        {
            this.HabitacionesDisponiblesDataGrid.DataSource = new List<Habitacion>();
            this.HabitacionesDisponiblesDataGrid.Refresh();
            this.HabitacionesDisponiblesDataGrid.Columns["identificador"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["codigo_tipo"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["codigo_hotel"].Visible = false;
            this.HabitacionesDisponiblesDataGrid.Columns["habilitada"].Visible = false;

            this.HabitacionesDisponiblesDataGrid.DataSource =
                RepositorioHabitacion.Instance.HabitacionesLibresEnFecha(hotel, reserva.fechaDesde, reserva.fechaHasta);
            this.HabitacionesDisponiblesDataGrid.Refresh();
        }

        private void PopularRegimen()
        {
            this.regimenesPosibles = RepositorioRegimen.Instance.RegimenesPorHotel(hotel);

            regimenActual = this.regimenesPosibles.Find(regimen => regimen.identificador == reserva.identificador_regimen);
            this.regimenesPosibles.Remove(regimenActual);

            this.RegimenDataGrid.DataSource = regimenesPosibles;
            this.RegimenDataGrid.Columns["identificador"].Visible = false;
            this.RegimenDataGrid.Columns["habilitado"].Visible = false;
            this.RegimenDataGrid.Refresh();

            this.regimenActualDataGrid.DataSource = new List<Regimen>() { regimenActual };
            this.regimenActualDataGrid.Columns["identificador"].Visible = false;
            this.regimenActualDataGrid.Columns["habilitado"].Visible = false;
            this.regimenActualDataGrid.Refresh();            
        }

        private void CancelarBoton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void quitarBoton_Click(object sender, EventArgs e)
        {
            if (this.HabitacionesReservadasDataGrid.CurrentRow != null)
            {
                Habitacion habitacionRemovida = (Habitacion)this.HabitacionesReservadasDataGrid.CurrentRow.DataBoundItem;
                QuitarHabitacionReservadaYHabilitarla(habitacionRemovida);

                CalcularPrecioHabitaciones(this.HabitacionesReservadasDataGrid);
                CalcularPrecioHabitaciones(this.HabitacionesDisponiblesDataGrid);
            }
            else
                MessageBox.Show("Debe seleccionar una fila.", "Atención", MessageBoxButtons.OK);
        }

        private void QuitarHabitacionReservadaYHabilitarla(Habitacion habitacionRemovida)
        {
            var habitac = this.habitacionesReservadas.Find(habitacion => habitacion.identificador == habitacionRemovida.identificador);
            if (habitac != null)
            {
                this.HabitacionesDisponiblesDataGrid.DataSource = new List<Habitacion>();
                this.HabitacionesDisponiblesDataGrid.Refresh();
                this.HabitacionesReservadasDataGrid.DataSource = new List<Habitacion>();
                this.HabitacionesReservadasDataGrid.Refresh();

                var HabitacionesReservadaParaGrid = new List<Habitacion>();
                var HabitacionesDisponiblesParaGrid = new List<Habitacion>();
                this.habitacionesReservadas.Remove(habitac);
                this.habitacionesDisponibles.Add(habitac);
                HabitacionesReservadaParaGrid = this.habitacionesReservadas;
                HabitacionesDisponiblesParaGrid = this.habitacionesDisponibles;


                this.HabitacionesDisponiblesDataGrid.DataSource = HabitacionesDisponiblesParaGrid;
                this.HabitacionesDisponiblesDataGrid.Refresh();
               
                this.HabitacionesReservadasDataGrid.DataSource = HabitacionesReservadaParaGrid;
                this.HabitacionesReservadasDataGrid.Refresh();

                this.habitacionesRemovidas.Add(habitac);
            }
        }

        private void agregarBoton_Click(object sender, EventArgs e)
        {
            if(this.HabitacionesDisponiblesDataGrid.CurrentRow != null)
            {
                Habitacion habitacionAgregada = (Habitacion)this.HabitacionesDisponiblesDataGrid.CurrentRow.DataBoundItem;
                AgregarHabitacionDisponibleYSacarlaDeLibres(habitacionAgregada);

                CalcularPrecioHabitaciones(this.HabitacionesReservadasDataGrid);
                CalcularPrecioHabitaciones(this.HabitacionesDisponiblesDataGrid);
            }
            else
                MessageBox.Show("Debe seleccionar una fila.", "Atención", MessageBoxButtons.OK);
        }

        private void AgregarHabitacionDisponibleYSacarlaDeLibres(Habitacion habitacionAgregada)
        {
            var habitac = this.habitacionesDisponibles.Find(habitacion => habitacion.identificador == habitacionAgregada.identificador);
            if (habitac != null)
            {
                this.HabitacionesDisponiblesDataGrid.DataSource = new List<Habitacion>();
                this.HabitacionesDisponiblesDataGrid.Refresh();
                this.HabitacionesReservadasDataGrid.DataSource = new List<Habitacion>();
                this.HabitacionesReservadasDataGrid.Refresh();

                var HabitacionesReservadaParaGrid = new List<Habitacion>();
                var HabitacionesDisponiblesParaGrid = new List<Habitacion>();
                this.habitacionesDisponibles.Remove(habitac);
                this.habitacionesReservadas.Add(habitac);
                HabitacionesReservadaParaGrid = this.habitacionesReservadas;
                HabitacionesDisponiblesParaGrid = this.habitacionesDisponibles;

                this.HabitacionesReservadasDataGrid.DataSource = HabitacionesReservadaParaGrid;
                this.HabitacionesReservadasDataGrid.Refresh();

                this.HabitacionesDisponiblesDataGrid.DataSource = HabitacionesDisponiblesParaGrid;
                this.HabitacionesDisponiblesDataGrid.Refresh();

                this.habitacionesAgregadas.Add(habitac);
            }
        }

        private void cambiarBoton_Click(object sender, EventArgs e)
        {
            Regimen RegimenNuevo = (Regimen)this.RegimenDataGrid.CurrentRow.DataBoundItem;

            Regimen RegimenViejo = (Regimen)this.regimenActualDataGrid.CurrentRow.DataBoundItem;

            this.regimenesPosibles.Remove(RegimenNuevo);
            this.regimenesPosibles.Add(RegimenViejo);

            this.RegimenDataGrid.DataSource = this.regimenesPosibles;
            this.regimenActualDataGrid.DataSource = new List<Regimen>() { RegimenNuevo };

            this.regimenActualDataGrid.Refresh();
            this.RegimenDataGrid.Refresh();

            regimenCambiado = RegimenNuevo;
            CalcularPrecioHabitaciones(this.HabitacionesReservadasDataGrid);
            CalcularPrecioHabitaciones(this.HabitacionesDisponiblesDataGrid);
        }

        private void DesdeDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (contador != 1)
            {
                DialogResult resultado = MessageBox.Show("Si cambia la fecha, es posible que " +
                    "no pueda encontrar habitaciones disponibles.\n\n" +
                    "¿Esta seguro de realizar este cambio?", "Atención", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                    DesdeDateTimePicker.Value = reserva.fechaDesde;
                else
                    ValidarFechaDesdeMenorAFechaHasta();
            }
        }

        private void ValidarFechaDesdeMenorAFechaHasta()
        {
            if (DesdeDateTimePicker.Value < HastaDateTimePicker.Value)
                BuscarHabitacionesDisponiblesYValidarDisponibilidadReservadas();
            else
                MessageBox.Show("La fecha de egreso no puede \n" +
                        "ser anterior a la de ingreso.", "Atención", MessageBoxButtons.OK);
        }

        private void HastaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            if (contador != 1)
            {
                DialogResult resultado = MessageBox.Show("Si cambia la fecha, es posible que " +
                    "no pueda encontrar habitaciones disponibles.\n\n" +
                    "¿Esta seguro de realizar este cambio?", "Atención", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.No)
                    DesdeDateTimePicker.Value = reserva.fechaDesde;
                else
                    ValidarFechaDesdeMenorAFechaHasta();
            }
        }

        private void BuscarHabitacionesDisponiblesYValidarDisponibilidadReservadas()
        {
            var habitacionesLibresDisponiblesSinRepetidos = RepositorioHabitacion.Instance.HabitacionesLibresEnFecha(hotel,
                DesdeDateTimePicker.Value, HastaDateTimePicker.Value);

            ValidarDisponibilidadHabitacionesReservadas(habitacionesLibresDisponiblesSinRepetidos);
        }

        private void ValidarDisponibilidadHabitacionesReservadas(List<Habitacion> habitacionesLibresDisponiblesSinRepetidos)
        {
            List<Habitacion> habitacionesReservadasLibres = RepositorioHabitacion.Instance.
                HabitacionesReservadasDisponiblesPorCambioDeFecha(hotel, DesdeDateTimePicker.Value,
                HastaDateTimePicker.Value, reserva);

            if (habitacionesReservadasLibres.Count != this.habitacionesReservadas.Count)
                HabitacionesQueFaltan(habitacionesReservadasLibres, habitacionesLibresDisponiblesSinRepetidos);
            else
                RepopularGrillaHabitaciones(habitacionesLibresDisponiblesSinRepetidos);
        }

        private void RepopularGrillaHabitaciones(List<Habitacion> habitacionesLibresDisponiblesSinRepetidos)
        {
            this.HabitacionesDisponiblesDataGrid.DataSource = new List<Habitacion>();
            this.HabitacionesDisponiblesDataGrid.Refresh();
            this.HabitacionesReservadasDataGrid.DataSource = new List<Habitacion>();
            this.HabitacionesReservadasDataGrid.Refresh();

            this.HabitacionesReservadasDataGrid.DataSource = this.habitacionesReservadas;
            this.HabitacionesReservadasDataGrid.Refresh();

            this.habitacionesDisponibles = habitacionesLibresDisponiblesSinRepetidos;
            this.HabitacionesDisponiblesDataGrid.DataSource = habitacionesDisponibles;
            this.HabitacionesDisponiblesDataGrid.Refresh();
        }

        private void HabitacionesQueFaltan(List<Habitacion> habitacionesReservadasLibres,
            List<Habitacion> habitacionesLibresDisponiblesSinRepetidos)
        {
            List<Habitacion> habitaciones = new List<Habitacion>();
            foreach (Habitacion habit in habitacionesReservadas)
            {
                Habitacion habitAux = habitacionesReservadasLibres.Find(habitac => habitac.identificador == habit.identificador);
                if(habitAux != null)
                    habitaciones.Add(habit);
            }

            if (habitaciones.Count > 0)
            {
                MessageBox.Show("Hay habitaciones reservadas por usted, \n" +
                                "que no se encuentran disponibles teniendo en cuenta \n" +
                                "el cambio de fecha que ha realizado. \n" +
                                "Si desea realizar el cambio de fecha, deberá liberar \n" +
                                "las habitaciones que tiene actualmente reservadas.\n" +
                                "A menos que presione el botón de modificación, no perderá su reserva.",
                                "Atención", MessageBoxButtons.OK);

                contador = 1;
                DesdeDateTimePicker.Value = reserva.fechaDesde;
                HastaDateTimePicker.Value = reserva.fechaHasta;
                contador = 2;
            }
            else
                RepopularGrillaHabitaciones(habitacionesLibresDisponiblesSinRepetidos);
        }

        private void modificarBoton_Click(object sender, EventArgs e)
        {
            if (SeModificoLaReserva())
            {
                Decimal precio = PrecioTotalPorModificacionReserva();
                DialogResult resultado = MessageBox.Show("El precio tras los cambios es de: $" +
                    precio.ToString() + ".", "Atención", MessageBoxButtons.YesNo);

                if (resultado == DialogResult.Yes)
                {
                    if (this.habitacionesRemovidas.Count > 0)
                        foreach (Habitacion habitacionARemover in this.habitacionesRemovidas)
                            RepositorioHabitacion.Instance.QuitarReservaDeHabitacion(reserva, habitacionARemover);

                    if (this.habitacionesAgregadas.Count > 0)
                        foreach (Habitacion habitacionAAGregar in this.habitacionesAgregadas)
                            RepositorioHabitacion.Instance.ReservarHabitacion(reserva, habitacionAAGregar);


                    RepositorioReserva.Instance.ModificarReserva(reserva, this.DesdeDateTimePicker.Value,
                        this.HastaDateTimePicker.Value, (Regimen)this.regimenActualDataGrid.CurrentRow.DataBoundItem,
                        4001);

                    MessageBox.Show("Se ha modificado su reserva correctamente.", "Reporte", MessageBoxButtons.OK);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Si no desea realizar cambios, presione Salir.", "Atención", MessageBoxButtons.OK);
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("No se han realizado cambios.\n" +
                    "¿Desea salir?", "Atención", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                    this.Close();
            }

        }

        private Decimal PrecioTotalPorModificacionReserva()
        {
            Decimal precio = 0;
            foreach(Habitacion habitacion in ((List<Habitacion>)this.HabitacionesReservadasDataGrid.DataSource))
            {
                precio += habitacion.precio;
            }
            return precio;
        }

        private bool SeModificoLaReserva()
        {
            return this.DesdeDateTimePicker.Value != reserva.fechaDesde | 
                this.HastaDateTimePicker.Value != reserva.fechaHasta |
                reserva.identificador_regimen != ((Regimen)this.regimenActualDataGrid.CurrentRow.DataBoundItem).identificador |
                    this.habitacionesAgregadas.Count > 0 | this.habitacionesRemovidas.Count > 0;
        }

    }
}