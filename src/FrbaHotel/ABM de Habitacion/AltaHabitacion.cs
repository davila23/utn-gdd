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
    public partial class HabitacionAlta : Form
    {
        SQLConnector conexion;
        public HabitacionAlta(SQLConnector conec,Double id)
        {
            InitializeComponent();
            conexion = conec;
            txtHotel.Text = id.ToString();
            DataTable tiposHab = conexion.consulta("select Tipo_Hab_Desc from HOTEL_CUATRIVAGOS.TIPO_HABITACION");
            foreach(DataRow dr in tiposHab.Rows){
                cBTipoHabitacion.Items.Add(dr["Tipo_Hab_Desc"].ToString());
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtConVista.Text) || string.IsNullOrEmpty(txtDesc.Text) || string.IsNullOrEmpty(txtNroHabi.Text) || string.IsNullOrEmpty(txtPisoHotel.Text)
                || string.IsNullOrEmpty(cBTipoHabitacion.SelectedItem.ToString()))
            {
                MessageBox.Show("Por favor complete todos los campos");
            }
            else {
                DataTable codHab = conexion.consulta("SELECT Tipo_Hab_Id from HOTEL_CUATRIVAGOS.TIPO_HABITACION WHERE Tipo_Hab_Desc = '"+ cBTipoHabitacion.SelectedItem.ToString()+"'");
                string queryViolento = "EXEC HOTEL_CUATRIVAGOS.alta_habitacion "+txtNroHabi.Text+","+txtPisoHotel.Text+","+txtHotel.Text+","+
                    codHab.Rows[0].ItemArray[0].ToString()+",'"+txtConVista.Text+"','"+txtDesc.Text+"'";
                try
                {
                    conexion.executeOnly(queryViolento);
                    MessageBox.Show("Habitacion creada con exito.");
                    this.Close();
                }
                catch (Exception exce){
                    MessageBox.Show(exce.Message);
                }
            }
        }
    }
}
