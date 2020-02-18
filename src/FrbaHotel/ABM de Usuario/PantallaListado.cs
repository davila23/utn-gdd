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
    public partial class PantallaListado : Form
    {
        SQLConnector conexion;
        string criterioABM;
        public PantallaListado(string criterio, SQLConnector conec)
        {
            InitializeComponent();
            criterioABM = criterio;
            conexion = conec;
            cBEstado.Items.Add(0);
            cBEstado.Items.Add(1);
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
            txtNom.Text = "";
            cBEstado.SelectedIndex = -1;
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string queryFinal = "SELECT U.Usuario_Id,U.Usuario_datos,R.Rol_Desc,DP.Datos_Tipo_Ident,U.Usuario_name,U.Usuario_pass,DP.Datos_Nombre,DP.Datos_Apellido,DP.Datos_Nro_Ident,DP.Datos_Mail,DP.Datos_Telefono,DP.Datos_Dom_Calle,DP.Datos_Dom_Nro_Calle,DP.Datos_Dom_Piso,DP.Datos_Dom_Depto,UP.Hotel_Id,DP.Datos_Fecha_Nac  "
                + "FROM HOTEL_CUATRIVAGOS.USUARIOS U ,HOTEL_CUATRIVAGOS.DATOS_PERSONALES DP,HOTEL_CUATRIVAGOS.USUARIOS_X_ROL_X_HOTEL UP, HOTEL_CUATRIVAGOS.ROLES R WHERE U.Usuario_datos = DP.Datos_Id AND UP.Usuario_Id = U.Usuario_Id AND R.Rol_Id = UP.Rol_Id ";
            if (!string.IsNullOrEmpty(txtNom.Text)) {
                queryFinal += "AND U.Usuario_name LIKE '%" + txtNom.Text + "%'";
            }
            if(cBEstado.SelectedIndex != -1){
                queryFinal += "AND U.Usuario_baja =" + cBEstado.SelectedItem;
 
            }
            dataGridView1.DataSource = conexion.consulta(queryFinal);
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Seleccionar";
            col.Name = "Seleccionar";
            dataGridView1.Columns.Add(col);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
              var senderGrid = (DataGridView)sender;
              string[] valor = new string[e.ColumnIndex];

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                for (int i = 0; i < e.ColumnIndex; i++)
                {
                    valor[i] = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                }

                if (criterioABM == "baja")
                {
                    BajaUsuario levantarBaja = new BajaUsuario(valor, conexion);
                    levantarBaja.ShowDialog();
                    this.Close();
                }
                else
                {
                    ModificarUsuario levantarModif = new ModificarUsuario(valor, conexion);
                    levantarModif.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
