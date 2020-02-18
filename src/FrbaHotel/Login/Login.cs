using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;
using FrbaHotel.Menu_Principal;




namespace FrbaHotel.Login
{
    public partial class Login : Form
    {
        private Inicio inicio;
        private UsuarioLogueado userLog;
        private List<string> roles = new List<string>();
        public Login(SQLConnector connection)
        {
            InitializeComponent();
            inicio = new Inicio(connection);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "" || txtContraseña.Text == "")
            {
                MessageBox.Show("Por favor complete los campos de usuario y contraseña");
            }
            else
            {
                try
                {
                    userLog = inicio.login(txtUsuario.Text, txtContraseña.Text);
                    roles = userLog.conseguirRolesUsuario();
                    if (roles.Count() > 1)
                    {
                        EleccionRol levantarEleccionRol = new EleccionRol(roles, userLog);
                        this.Hide();
                        levantarEleccionRol.ShowDialog();

                    }
                    else
                    {
                        EleccionHotel levantarElecHotel = new EleccionHotel(roles.First(), userLog);
                        this.Hide();
                        levantarElecHotel.ShowDialog();
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                    this.limpiar();
                }
            }
        }
        private void limpiar() { txtContraseña.Text = String.Empty; txtUsuario.Text = String.Empty; }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
