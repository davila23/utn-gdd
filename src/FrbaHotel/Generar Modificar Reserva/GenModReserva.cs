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

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class GenModReserva : Form
    {
        SQLConnector conexion;
        DateTime fechaActualSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
        public GenModReserva(SQLConnector conecc)
        {
            InitializeComponent();
            DataTable tiposHabs = conexion.consulta("select Tipo_Hab_Desc FROM HOTEL_CUATRIVAGOS.TIPO_HABITACION");
            foreach(DataRow dr in tiposHabs.Rows){
                cBtiposHabs.Items.Add(dr["Tipo_Hab_Desc"].ToString());
            }
            DataTable tiposRegis = conexion.consulta("SELECT Regimen_Desc FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA");
            foreach (DataRow dr in tiposRegis.Rows) {
                cBtipRegi.Items.Add(dr["Regimen_Desc"]).ToString();
            }
            txtFecSist.Text = fechaActualSistema.ToString("yyyyMMdd"); ;
            conexion = conecc;
        }

        private void cBtiposHabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cBtipRegi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}