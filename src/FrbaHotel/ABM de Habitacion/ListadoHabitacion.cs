using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Habitacion
{
    public partial class ListadoHabitacion : Form
    {
        SQLConnector conexion;
        string criterioABM;
        Double hotelAsignad;
        public ListadoHabitacion(string criterio,SQLConnector conec,Double hotelId)
        {
            InitializeComponent();
            conexion = conec;
            hotelAsignad = hotelId;
            DataTable tiposHab = conexion.consulta("SELECT Habitacion_Tipo FROM HOTEL_CUATRIVAGOS.HABITACIONES GROUP BY Habitacion_Tipo");
            foreach (DataRow dr in tiposHab.Rows)
            {
                cBTipoHabitacion.Items.Add(dr["Habitacion_Tipo"].ToString());
            }
            cBVista.Items.Add("SI");
            cBVista.Items.Add("NO");
            criterioABM = criterio;
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            txtPisoHotel.Text = "";
            cBTipoHabitacion.SelectedIndex = -1;
            cBVista.SelectedIndex = -1;
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string queryFinal = "select * FROM HOTEL_CUATRIVAGOS.HABITACIONES WHERE Habitacion_Hotel ="+hotelAsignad;
            if (!String.IsNullOrEmpty(txtPisoHotel.Text)) {
                queryFinal += "and Habitacion_Piso =" + txtPisoHotel.Text;
            }
            if (!String.IsNullOrEmpty(cBTipoHabitacion.SelectedText)) 
            {
                queryFinal += "and Habitacion_Tipo =" + cBTipoHabitacion.SelectedText;
            }
            if (!String.IsNullOrEmpty(cBVista.SelectedText))
            {
                queryFinal += "and Habitacion_Vista =" + cBVista.SelectedText;
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
            string[] valores = new string[e.ColumnIndex];
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {

                for (int i = 0; i < e.ColumnIndex; i++)
                {
                    valores[i] = dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                }

                if (criterioABM == "baja")
                {
                    BajaHabitacion levantarBaja = new BajaHabitacion(valores, conexion);
                    this.Close();
                    levantarBaja.Show();
                }
                else
                {
                    ModifHabitacion levantarModif = new ModifHabitacion(valores, conexion);
                    this.Close();
                    levantarModif.Show();
                }
            }
        }
    }
}
