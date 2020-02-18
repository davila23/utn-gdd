using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;


namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ABMHotel : Form
    {
        UsuarioLogueado usuario;
        public ABMHotel(UsuarioLogueado user) 
        {
            InitializeComponent();
            usuario = user;
        }
        public ABMHotel(UsuarioLogueado user, List<string> listaFunc)
        {
            InitializeComponent();
            desactivarBotones();
            usuario = user;
            if (listaFunc.Contains("Alta de Hotel"))
            {
                btnAlta.Enabled = true;
            }
            if (listaFunc.Contains("Baja de Hotel"))
            {
                btnBaja.Enabled = true;
            }
            if (listaFunc.Contains("Modificacion de Hotel"))
            {
                btnModif.Enabled = true;
            }
        }
        private void desactivarBotones()
        {
            btnAlta.Enabled = false;
            btnBaja.Enabled = false;
            btnModif.Enabled = false;
        }
        private void btnAlta_Click(object sender, EventArgs e)
        {
            AltaHotel levantarAlta = new AltaHotel(usuario);
            this.Hide();
            levantarAlta.ShowDialog();
            this.Show();
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            ListadoHotel levantarLista = new ListadoHotel("baja", usuario.getConexion());
            this.Hide();
            levantarLista.ShowDialog();
            this.Show();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            ListadoHotel levantarLista = new ListadoHotel("modificar", usuario.getConexion());
            this.Hide();
            levantarLista.ShowDialog();
            this.Show();
        }
    }
}
