using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCommerce.Login
{
    public partial class Form2EleccionRol : Form
    {
        public Form2EleccionRol(List<string> roles)
        {
            foreach (var rol in roles)
            {
                LBlistaRoles.Items.Add(rol);
            }
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            string selected = LBlistaRoles.SelectedValue.ToString();
            Menu_Principal.Form1MenuPrincipal lanzarMenu = new Menu_Principal.Form1MenuPrincipal(selected);
        }
    }
}