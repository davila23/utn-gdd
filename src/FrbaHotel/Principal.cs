using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel
{
    public partial class Principal : Form
    {
        private SQLConnector coneccion;
        public Principal()
        {
            InitializeComponent();
            coneccion = new SQLConnector();
        }

        private void btnExecLogin_Click(object sender, EventArgs e)
        {
            FrbaHotel.Login.Login levantarLogeo = new FrbaHotel.Login.Login(coneccion);
            this.Hide();
            levantarLogeo.ShowDialog();

        }

        private void btnInvitado_Click(object sender, EventArgs e)
        {
            Menu_Principal.MenuGuest levantarGuest = new FrbaHotel.Menu_Principal.MenuGuest(coneccion);
            this.Hide();
            levantarGuest.ShowDialog();

        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }
    }
}
