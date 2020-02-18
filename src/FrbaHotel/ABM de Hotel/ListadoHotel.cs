using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class ListadoHotel : Form
    {
        SQLConnector conexion;
        string criterioABM;
        public ListadoHotel(string criterio, SQLConnector conec)
        {
            InitializeComponent();
            criterioABM = criterio;
            conexion = conec;
        }

        private void btnLimpia_Click(object sender, EventArgs e)
        {
            txtCantStar.Text = "";
            txtCity.Text = "";
            txtNom.Text = "";
            txtPais.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string queryFinal = "SELECT Hotel_Id,Hotel_Nombre,Hotel_Mail,Hotel_Telefono,Hotel_Calle,Hotel_Nro_Calle,Hotel_Ciudad,Hotel_Pais,Hotel_Cant_Est,Hotel_Fecha_Creacion FROM HOTEL_CUATRIVAGOS.HOTELES";
            string condicion = " Where ";
                        Boolean existeCondicion = false;
                        Boolean anterior = false;
                            if(txtCity.Text !=""){
                                condicion += ("Hotel_Ciudad = '"+ txtCity.Text + "'");
                                existeCondicion= true;
                                anterior= true;
                            }
                            if(txtNom.Text !=""){
                                existeCondicion= true;
                                if(anterior){
                                    condicion += " AND ";    
                                 }
                                condicion += ("Hotel_Nombre = '"+ txtNom.Text + "'");
                                anterior= true;
                            }
                            if(txtPais.Text !=""){
                                    existeCondicion= true;
                                    if(anterior){
                                    condicion += " AND ";
                            }
                                    condicion += ("Hotel_Pais = '"+ txtPais.Text + "'");
                                    anterior= true;    
                            }
                            if(txtCantStar.Text !=""){
                                    existeCondicion= true;
                                    if(anterior)
                                    {
                                        condicion += " AND ";    
                                    }
                                    condicion += ("Hotel_Cant_Est = "+ txtCantStar.Text);
                                     }
                            if(existeCondicion){
                                queryFinal += condicion;

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
                    BajaHotel levantarBaja = new BajaHotel(valores, conexion);
                    this.Close();
                    levantarBaja.ShowDialog();
                }
                else
                {
                    ModifHotel levantarModif = new ModifHotel(valores, conexion);
                    this.Close();
                    levantarModif.ShowDialog();
                }
            }
        }
    }
}
