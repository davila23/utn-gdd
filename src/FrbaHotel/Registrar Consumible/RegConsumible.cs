using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class RegConsumible : Form
    {
        SQLConnector conexion;
        string descrip;
        public RegConsumible(SQLConnector conecc)
        {
            InitializeComponent();
            conexion = conecc;
        }
        public string getDesc() { return descrip; }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                conexion.consulta("if not exists (SELECT Reserva_Id FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION " +
                "WHERE Reserva_Id =" + txtNroReserva.Text +
                " AND Habitacion_Id =" + txtNroHab.Text + ") begin raiserror('Reserva no encontrada',16,1) end ");
                AgregarConsu levantar = new AgregarConsu(this, conexion);
                this.Hide();
                levantar.ShowDialog();
                this.Show();
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
        }
        public void agregarAlGrid(string descripcion, string cantidad) 
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = descripcion;
            row.Cells[1].Value = cantidad;
            dataGridView1.Rows.Add(row);
        }
        public void modificarGrid(string desc, string cantidad) 
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(desc))
                {
                    rowIndex = row.Index;
                    break;
                }
            }
            dataGridView1.Rows[rowIndex].Cells[1].Value = cantidad;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns[2].Index )
            {
                descrip = dataGridView1[0, e.RowIndex].Value.ToString();
                ModifConsu levantarModif = new ModifConsu(this);
                this.Hide();
                levantarModif.ShowDialog();
                this.Show();
            }
            else if (e.ColumnIndex == dataGridView1.Columns[3].Index ) 
            {
                dataGridView1.Rows.RemoveAt(e.RowIndex);
                dataGridView1.Refresh();
            }
            this.Show();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string rphId="";
            string cant="";
            DataTable consuId = new DataTable();
            if (txtNroHab.Text == "" || txtNroReserva.Text == "") { MessageBox.Show("Complete todos los campos"); }
            else
            {
                try
                {
                    DataTable phid = conexion.consulta("SELECT RPH_Id FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION WHERE Reserva_Id = " + txtNroReserva.Text + " AND Habitacion_Id = " + txtNroHab.Text);
                    rphId = phid.Rows[0].ItemArray[0].ToString();
                    for (int i =0; i< dataGridView1.RowCount-1;i++)
                    {
                        DataGridViewRow row = dataGridView1.Rows[i];
                        cant = row.Cells[1].Value.ToString();
                        string miniQuery = "SELECT Consumible_Id FROM HOTEL_CUATRIVAGOS.CONSUMIBLES WHERE Consumible_Desc LIKE '%" + row.Cells[0].Value.ToString() + "%'";
                        consuId = conexion.consulta(miniQuery);
                        string query=" EXEC HOTEL_CUATRIVAGOS.alta_consumible_habitacion " + rphId + "," + consuId.Rows[0].ItemArray[0].ToString() + "," + cant+" ";
                        conexion.executeOnly(query);
                    }
                    MessageBox.Show("Registracion exitosa");
                    this.Close();
                }
                catch (Exception exec) {
                    MessageBox.Show(exec.Message);
                }
            }
        }

    }
}
