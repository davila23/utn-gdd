using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Cancelar_Reserva;
using FrbaHotel.NINIRODIE.Clases;

namespace FrbaHotel.Registrar_Estadia
{
    public partial class IngresoOEgreso : Form
    {
        public Usuario usuario { get; set; }
        public Hotel hotelSeleccionado { get; set; }

        public IngresoOEgreso(Usuario user, Hotel hotelSelc)
        {
            InitializeComponent();
            usuario = user;
            hotelSeleccionado = hotelSelc;
        }

        private void IngresoBoton_Click(object sender, EventArgs e)
        {
            new BuscarReserva(usuario, ModoApertura.CHECKIN, hotelSeleccionado).Show();
            this.Close();
        }

        private void EgresoBoton_Click(object sender, EventArgs e)
        {
            new BuscarReserva(usuario, ModoApertura.CHECKOUT, hotelSeleccionado).Show();
            this.Close();
        }
    }
}
