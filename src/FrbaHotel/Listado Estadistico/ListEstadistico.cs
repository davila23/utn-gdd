using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Listado_Estadistico
{
    public partial class ListEstadistico : Form
    {
        SQLConnector conector;
        public ListEstadistico(SQLConnector conec)
        {
            InitializeComponent();
            cBListado.Items.Add("Hoteles con mayor cantidad de reservas canceladas");
            cBListado.Items.Add("Hoteles con mayor cantidad de consumibles facturados");
            cBListado.Items.Add("Hoteles con mayor cantidad de días fuera de servicio");
            cBListado.Items.Add("Habitaciones con mayor cantidad de días y veces que fueron ocupadas");
            cBListado.Items.Add("Clientes con mayor cantidad de puntos");
            conector = conec;
            DataTable anios = conector.consulta("SELECT DISTINCT YEAR(Reserva_Fecha) FROM HOTEL_CUATRIVAGOS.RESERVAS GROUP BY Reserva_Fecha ");
            foreach (DataRow row in anios.Rows)
            {
                cBanios.Items.Add(row[0].ToString());
            }

        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            cBListado.SelectedIndex = -1;
            cBanios.SelectedIndex = -1;
            txtMFIN.Text = "";
            txtMFIN.Enabled = false;
            txtMINI.Text = "";
            txtMINI.Enabled = false;
            dGVListEsta.ClearSelection();
            dGVListEsta.Refresh();
        }


        private void btnLanzarConsulta_Click(object sender, EventArgs e)
        {
            if (txtMFIN.Text == "" || txtMINI.Text == "") { MessageBox.Show("Complete los meses"); }
            else
            {
                string queryFinal;
                try
                {
                    switch (cBListado.SelectedItem.ToString())
                    {
                        case "Hoteles con mayor cantidad de reservas canceladas":
                            queryFinal = "SELECT * FROM HOTEL_CUATRIVAGOS.hoteles_reservas_mas_canceladas (" + cBanios.SelectedItem.ToString() + "," + txtMINI.Text + "," + txtMFIN.Text + ")";
                            dGVListEsta.DataSource = conector.consulta(queryFinal);
                            break;
                        case "Hoteles con mayor cantidad de consumibles facturados":
                            queryFinal = "SELECT * FROM HOTEL_CUATRIVAGOS.hoteles_consumibles_facturados (" + cBanios.SelectedItem.ToString() + "," + txtMINI.Text + "," + txtMFIN.Text + ")";
                            dGVListEsta.DataSource = conector.consulta(queryFinal);
                            break;
                        case "Hoteles con mayor cantidad de días fuera de servicio":
                            queryFinal = "SELECT * FROM HOTEL_CUATRIVAGOS.hoteles_fuera_de_servicio (" + cBanios.SelectedItem.ToString() + "," + txtMINI.Text + "," + txtMFIN.Text + ")";
                            dGVListEsta.DataSource = conector.consulta(queryFinal);
                            break;
                        case "Habitaciones con mayor cantidad de días y veces que fueron ocupadas":
                            queryFinal = "SELECT * FROM HOTEL_CUATRIVAGOS.habitaciones_mas_ocupadas (" + cBanios.SelectedItem.ToString() + "," + txtMINI.Text + "," + txtMFIN.Text + ")";
                            dGVListEsta.DataSource = conector.consulta(queryFinal);
                            break;
                        case "Clientes con mayor cantidad de puntos":
                            queryFinal = "SELECT * FROM HOTEL_CUATRIVAGOS.clientes_mas_puntos (" + cBanios.SelectedItem.ToString() + "," + txtMINI.Text + "," + txtMFIN.Text + ")";
                            dGVListEsta.DataSource = conector.consulta(queryFinal);
                            break;
                        default:
                            return;

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void habilatarMeses()
        {
            txtMINI.Enabled = true;
            txtMFIN.Enabled = true;
        }

        private void cBanios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBanios.SelectedIndex != -1)
            {
                this.habilatarMeses();
            }
        }

        private void dGVListEsta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ListEstadistico_Load(object sender, EventArgs e)
        {

        }

    }
}
