using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ABMCliente : Form
    {
        SQLConnector coneccion;
        public ABMCliente(SQLConnector conexion) 
        {
            InitializeComponent();
            coneccion = conexion;
        }
        public ABMCliente(SQLConnector conexion,List<string> lista)
        {
            InitializeComponent();
            desactivarBotones();
            coneccion = conexion;
            if (lista.Contains("Alta de Cliente")) {
                btnAlta.Enabled = true;
            }
            if (lista.Contains("Baja de Cliente"))
            {
                btnBaja.Enabled = true;
            }
            if (lista.Contains("Modificacion de Cliente"))
            {
                btnModificar.Enabled = true;
            }
        }
        private void desactivarBotones()
        {
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            btnModificar.Enabled = false;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            FrbaHotel.ABM_de_Cliente.AltaCliente levantarAlta = new AltaCliente(coneccion);
            this.Hide();
            levantarAlta.ShowDialog();
            //this.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            ListadoCliente levantarListado = new ListadoCliente("modificar", coneccion);
            this.Hide();
            levantarListado.ShowDialog();
            //this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            ListadoCliente levantarListado = new ListadoCliente("baja",coneccion);
            this.Hide();
            levantarListado.ShowDialog();
            //this.Show();
        }

        private void ABMCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
