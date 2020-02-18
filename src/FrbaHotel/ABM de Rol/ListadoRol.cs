using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class ListadoRol : Form
    {
        SQLConnector conexion;
        string criterioABM;
        public ListadoRol(string condicion, SQLConnector conec)
        {
            InitializeComponent();
            criterioABM = condicion;
            conexion = conec;
            cBEstadoRol.Items.Add("1");
            cBEstadoRol.Items.Add("0");
            DataTable funcionalidades = conexion.consulta("SELECT Func_Desc FROM HOTEL_CUATRIVAGOS.FUNCIONALIDADES");
            foreach (DataRow row in funcionalidades.Rows) 
            {
                cBFuncionalidades.Items.Add(row["Func_Desc"]);
            }
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            txtNomRol.Text = "";
            cBEstadoRol.SelectedIndex = -1;
            cBFuncionalidades.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string queryFinal = "SELECT R.Rol_Id,R.Rol_Desc,R.Rol_estado FROM HOTEL_CUATRIVAGOS.ROLES R, HOTEL_CUATRIVAGOS.FUNCIONALIDADES F ";
            Boolean condicion = false;
            string condiciones = " WHERE ";
            if (!string.IsNullOrEmpty(txtNomRol.Text)) 
            {
                condicion = true;
                queryFinal += condiciones+ " R.Rol_Desc LIKE '%"+txtNomRol.Text+"%'";
            }
            if (cBFuncionalidades.SelectedIndex != -1) 
            {
                if (condicion) { queryFinal += " AND F.Func_Desc LIKE '%" + cBFuncionalidades.SelectedItem.ToString() + "%'"; }
                else
                {
                    condicion = true; 
                    queryFinal += condiciones +"  F.Func_Desc LIKE '%" + cBFuncionalidades.SelectedItem.ToString() + "%'"; }
                
            }
            if (cBEstadoRol.SelectedIndex != -1) 
            {
                if (condicion) { queryFinal += " AND R.Rol_Estado LIKE '%" + cBEstadoRol.SelectedItem.ToString() + "%'"; }
                else { queryFinal += condiciones+"  R.Rol_Estado LIKE '%" + cBEstadoRol.SelectedItem.ToString() + "%'"; }
                
            }
            queryFinal += " GROUP BY R.Rol_Id,R.Rol_Desc,R.Rol_estado";
              dataGridView1.DataSource =  conexion.consulta(queryFinal);
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
                    BajaRol levantarBaja = new BajaRol(valor, conexion);
                    this.Close();
                    levantarBaja.ShowDialog();
                }
                else
                {
                    ModificarRol levantarModif = new ModificarRol(valor, conexion);
                    this.Close();
                    levantarModif.ShowDialog();
                }
            }
        }
    }
}
