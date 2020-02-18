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

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class periodoHotel : Form
    {
        string idHotel="";
        DateTime fechaSist = new DateTime();
        SQLConnector conec;
        public periodoHotel(string hotelId,SQLConnector conexion)
        {
            InitializeComponent();
            fechaSist = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            dateTimePicker1.Value = fechaSist;
            idHotel = hotelId;
            conec = conexion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtMotivo.Text.Equals(""))
            {
                MessageBox.Show("Complete todos los campos");
            }
            else {
                try
                {
                    string queryEXEC = "exec HOTEL_CUATRIVAGOS.alta_periodo_cierre " + idHotel + ", " + fechaSist.ToString("yyyyMMdd") + ","
                        + dateTimePicker1.Value.ToString("yyyyMMdd") + "," + "'" + txtMotivo.Text + "'";
                    conec.executeOnly(queryEXEC);
                    MessageBox.Show("Baja de hotel hecha con exito");
                    this.Close();
                }
                catch (Exception excep) {
                    MessageBox.Show(excep.Message);
                }
            }
        }
    }
}
