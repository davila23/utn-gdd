using System;
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
    public partial class BajaUsuario : Form
    {
        SQLConnector conexion;
        string usuarioId;
        string datosPersId;
        List<TextBox> boxes = new List<TextBox>();
        public BajaUsuario(string[] valores, SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            usuarioId = valores[0];
            datosPersId = valores[1];
            DataTable data = conec.consulta("SELECT Rol_Desc,Hotel_Id FROM HOTEL_CUATRIVAGOS.USUARIOS, HOTEL_CUATRIVAGOS.ROLES, HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL WHERE USUARIOS.Usuario_Id = USUARIOS_X_ROL_X_HOTEL.Usuario_Id AND ROLES.Rol_Id = USUARIOS_X_ROL_X_HOTEL.Rol_Id AND USUARIOS.Usuario_Id = '"+usuarioId+"'");
            txtRolAsignado.Text = data.Rows[0].ItemArray[0].ToString();
            txtHotelTrabaja.Text = data.Rows[0].ItemArray[1].ToString();
            
            this.generarBoxes();
            this.cargarBoxes(valores);

        }
        private void generarBoxes()
        {
            boxes.Add(txtUser);
            boxes.Add(txtPass);
            boxes.Add(txtNom);
            boxes.Add(txtApellido);
            boxes.Add(txtTDoc);
            boxes.Add(txtNDoc);
            boxes.Add(txtMail);
            boxes.Add(txtTelefono);
            boxes.Add(txtCalle);
            boxes.Add(txtNcalle);
            boxes.Add(txtPiso);
            boxes.Add(txtDepto);
            boxes.Add(txtFecNac);
        }
        private void cargarBoxes(string[] listaVal)
        {
            int i = 2;
            foreach (var txtB in boxes)
            {
                txtB.Text = listaVal[i];
                i++;
            }
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string query = "UPDATE HOTEL_CUATRIVAGOS.USUARIOS set Usuario_Baja = 1 WHERE Usuario_Id = '"+usuarioId+"'";
            conexion.executeOnly(query);
            this.Hide();
            MessageBox.Show("Usuario dado de baja con exito");
        }

        private void BajaUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
