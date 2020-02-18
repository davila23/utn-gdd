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
    public partial class ListadoCliente : Form
    {
        SQLConnector conexion;
        string criterioABM;
        public ListadoCliente(string condicion, SQLConnector conec)
        {
            InitializeComponent();
            cBtipoIdent.Items.Add("DNI");
            cBtipoIdent.Items.Add("Pasaporte");
            cBtipoIdent.Items.Add("Cedula");
            criterioABM = condicion;
            conexion = conec;
        }



        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            txtApe.Text = "";
            txtMail.Text = "";
            txtNDoc.Text = "";
            txtNom.Text = "";
            cBtipoIdent.SelectedIndex = -1;
            dGVListadoSeleccionados.DataSource = null;
            dGVListadoSeleccionados.Columns.Clear();
            dGVListadoSeleccionados.Refresh();
        }

        /*private void btnBusqueda_Click(object sender, EventArgs e)
        {
            
            string queryFinal = "SELECT C.Cliente_Id,D.Datos_Id,D.Datos_Tipo_Ident,D.Datos_Nombre,D.Datos_Apellido,D.Datos_Telefono,D.Datos_Nro_Ident,D.Datos_Mail,D.Datos_Dom_Calle,D.Datos_Dom_Nro_Calle,D.Datos_Dom_Piso,D.Datos_Dom_Depto,C.Cliente_Nacionalidad,D.Datos_Fecha_Nac"
                + " FROM HOTEL_CUATRIVAGOS.DATOS_PERSONALES D, HOTEL_CUATRIVAGOS.CLIENTES C WHERE D.Datos_Id = C.Cliente_Datos";
            string agregarCondicion;
            if (!string.IsNullOrEmpty(txtApe.Text))
            {
                agregarCondicion = " AND D.Datos_Apellido LIKE '%" + txtApe.Text + "%'";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtNom.Text))
            {
                agregarCondicion = " AND D.Datos_Nombre LIKE '%" + txtNom.Text + "%'";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtNDoc.Text))
            {
                agregarCondicion = " AND D.Datos_Nro_Ident LIKE '%" + txtNDoc.Text + "%'";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                agregarCondicion = " AND D.Datos_Mail LIKE '%" + txtMail.Text + "%'";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(cBtipoIdent.SelectedItem.ToString()))
            {
                agregarCondicion = " AND D.Datos_Tipo_Ident ='" + cBtipoIdent.SelectedItem.ToString() + "'";
                queryFinal += agregarCondicion;
            }
            dGVListadoSeleccionados.DataSource = conexion.consulta(queryFinal);
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Seleccionar";
            col.Name = "Seleccionar";
            dGVListadoSeleccionados.Columns.Add(col); */

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

            string queryFinal = "SELECT C.Cliente_Id,D.Datos_Id,D.Datos_Tipo_Ident,D.Datos_Nombre,D.Datos_Apellido,D.Datos_Telefono,D.Datos_Nro_Ident,D.Datos_Mail,D.Datos_Dom_Calle,D.Datos_Dom_Nro_Calle,D.Datos_Dom_Piso,D.Datos_Dom_Depto,C.Cliente_Nacionalidad,D.Datos_Fecha_Nac"
                + " FROM HOTEL_CUATRIVAGOS.DATOS_PERSONALES D, HOTEL_CUATRIVAGOS.CLIENTES C WHERE D.Datos_Id = C.Cliente_Datos";
            string agregarCondicion;
            if (!string.IsNullOrEmpty(txtApe.Text))
            {
                agregarCondicion = " AND D.Datos_Apellido LIKE '%'" + txtApe.Text + "%''";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtNom.Text))
            {
                agregarCondicion = " AND D.Datos_Nombre LIKE '%'" + txtNom.Text + "%''";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtNDoc.Text))
            {
                agregarCondicion = " AND D.Datos_Nro_Ident LIKE '%" + txtNDoc.Text + "%'";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(txtMail.Text))
            {
                agregarCondicion = " AND D.Datos_Mail LIKE '%'" + txtMail.Text + "%''";
                queryFinal += agregarCondicion;
            }
            if (!string.IsNullOrEmpty(cBtipoIdent.SelectedItem.ToString()))
            {
                agregarCondicion = " AND D.Datos_Tipo_Ident ='" + cBtipoIdent.SelectedItem.ToString() + "'";
                queryFinal += agregarCondicion;
            }
            dGVListadoSeleccionados.DataSource = conexion.consulta(queryFinal);
            DataGridViewButtonColumn col = new DataGridViewButtonColumn();
            col.UseColumnTextForButtonValue = true;
            col.Text = "Seleccionar";
            col.Name = "Seleccionar";
            dGVListadoSeleccionados.Columns.Add(col);
            
        }
        private void dGVListadoSeleccionados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string[] valor = new string[e.ColumnIndex];

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                for (int i = 0; i < e.ColumnIndex; i++)
                {
                    valor[i] = dGVListadoSeleccionados.Rows[e.RowIndex].Cells[i].Value.ToString();
                }

                if (criterioABM == "baja")
                {
                    BajaCliente levantarBaja = new BajaCliente(valor, conexion);
                    this.Close();
                    levantarBaja.Show();
                }
                else
                {
                    ModifCliente levantarModif = new ModifCliente(valor, conexion);
                    this.Close();
                    levantarModif.Show();
                }
            }
        }

        private void ListadoCliente_Load(object sender, EventArgs e)
        {

        }

        private void txtNom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }


    }
}
