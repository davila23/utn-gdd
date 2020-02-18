using System;
using System.Configuration;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Usuario
{
    public partial class ModificarUsuario : Form
    {
        Administrador admin;
        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        Inicio inicio;
        string usuarioId;
        string datosPersId;
        public ModificarUsuario(string[] valores,SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            admin = new Administrador(conec);
            List<string> rolesActuales = admin.rolesSistema();
            foreach (var rol in rolesActuales) {
                cBRolesAAsignar.Items.Add(rol);
            }
            usuarioId = valores[0];
            datosPersId = valores[1];
            cBRolesAAsignar.SelectedItem = valores[2];
            tipoDocSelector.SelectedItem = valores[3];
            this.generarBoxes();
            this.cargarBoxes(valores);
            dateTimePicker1.Value = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            inicio = new Inicio(conexion);
            tipoDocSelector.Items.Add("DNI");
            tipoDocSelector.Items.Add("Pasaporte");
            tipoDocSelector.Items.Add("Cedula");
        }
        private void generarBoxes() {
            boxes.Add(txtUser);
            boxes.Add(txtPass);
            boxes.Add(txtNom);
            boxes.Add(txtApellido);
            boxes.Add(txtNDoc);
            boxes.Add(txtMail);
            boxes.Add(txtTelefono);
            boxes.Add(txtCalle);
            boxes.Add(txtNcalle);
            boxes.Add(txtPiso);
            boxes.Add(txtDepto);
            boxes.Add(txtHotelTrabaja);
        }
        private void cargarBoxes(string[] listaVal)
        {
            int i = 4;        
            foreach(var txtB in boxes)
            {
                txtB.Text = listaVal[i];
                i++;
            }
            dateTimePicker1.Value = Convert.ToDateTime(listaVal[i]);
            boxes.Remove(txtPass);
            txtPass.Text = "";
        }

        private void btnModUser_Click(object sender, EventArgs e)
        {
            if (boxes.Where(b => string.IsNullOrEmpty(b.Text)).Any() || string.IsNullOrEmpty(txtHotelTrabaja.Text) || cBRolesAAsignar.SelectedIndex == -1 || tipoDocSelector.SelectedIndex == -1)
            {
                MessageBox.Show("Complete todo los campos");
            }
            else
            {
                string pass;
                if (txtPass.Text.Equals(""))
                {
                    pass = "NULL";
                }
                else
                {
                    pass = inicio.SHA256Encripta(txtPass.Text);
                }
                string query = "EXEC HOTEL_CUATRIVAGOS.modificacion_usuario '" + txtUser.Text + "','" + pass + "','" + txtNom.Text + "','" + txtApellido.Text +
                    "'," + txtTelefono.Text + ",'" + tipoDocSelector.SelectedItem.ToString() + "'," + txtNDoc.Text + ",'" + txtMail.Text + "','" + txtCalle.Text + "'," + txtNcalle.Text + "," + txtPiso.Text
                    + ",'" + txtDepto.Text + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "'," + usuarioId + "," +  txtHotelTrabaja.Text +", '"+cBRolesAAsignar.SelectedItem.ToString()+"'";
                try
                {
                    conexion.executeOnly(query);
                    MessageBox.Show("Usuario modificado con exito");
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.Message);
                }
                this.Close();
            }
        }


    }
}
