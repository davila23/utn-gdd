using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Menu_Principal
{
    public partial class MenuGuest : Form
    {
        SQLConnector conexion;
        public MenuGuest(SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
        }

        private void bnCancelGuest_Click(object sender, EventArgs e)
        {
            Cancelar_Reserva.CancelReser levantarCancel = new FrbaHotel.Cancelar_Reserva.CancelReser(conexion,"guest");
            this.Hide();
            levantarCancel.ShowDialog();
            this.Show();
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Generar levantarCancel = new FrbaHotel.Generar_Modificar_Reserva.Generar(conexion, "guest");
            this.Hide();
            levantarCancel.ShowDialog();
            this.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Modificar levantarGenMod = new FrbaHotel.Generar_Modificar_Reserva.Modificar(conexion, "guest");
            this.Hide();
            levantarGenMod.ShowDialog();
            this.Show();
        }
    }
}
