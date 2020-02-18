using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Login
{
    public partial class EleccionRol : Form
    {
        UsuarioLogueado usuarioLog;
        public EleccionRol(List<string> rolesACargar, UsuarioLogueado userLog)
        {
            InitializeComponent();
            foreach (var rol in rolesACargar)
            {
                lBEleccionRoles.Items.Add(rol);
            }
            usuarioLog = userLog;
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(lBEleccionRoles.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor elija un rol");
            }
            string selected = lBEleccionRoles.SelectedItem.ToString();
            EleccionHotel levantarElecHotel = new EleccionHotel(selected, usuarioLog);
            levantarElecHotel.ShowDialog();
            this.Close();
        }

    }
}
