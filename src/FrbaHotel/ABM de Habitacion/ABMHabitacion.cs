using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ABMHabitacion : Form
    {
        SQLConnector conexion;
        Double hotelId;
        public ABMHabitacion(SQLConnector conec,UsuarioLogueado user) 
        {
            InitializeComponent();
            conexion = conec;
            hotelId = user.getHotelAsignado();
        }
        public ABMHabitacion(UsuarioLogueado userLog,List<string> listaFunc)
        {
            InitializeComponent();
            desactivarBotones();
            conexion = userLog.getConexion();
            hotelId = userLog.getHotelAsignado();
            if(listaFunc.Contains("Alta de Habitacion")){
                btnAlta.Enabled = true;
            }
            if (listaFunc.Contains("Baja de Habitacion"))
            {
                btnBaja.Enabled = true;
            }
            if (listaFunc.Contains("Modificacion de Habitacion"))
            {
                btnModificar.Enabled = true;
            }
        }
        private void desactivarBotones(){
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.HabitacionAlta levantarAlta = new HabitacionAlta(conexion,hotelId);
            this.Hide();
            levantarAlta.ShowDialog();
            this.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ListadoHabitacion levantarListado = new ListadoHabitacion("modificar",conexion,hotelId);
            this.Hide();
            levantarListado.ShowDialog();
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            ListadoHabitacion levantarListado = new ListadoHabitacion("baja",conexion,hotelId);
            this.Hide();
            levantarListado.ShowDialog();
            this.Show();

        }
    }
}
