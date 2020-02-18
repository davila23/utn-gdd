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
    public partial class BajaHabitacion : Form
    {
        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        string habitacionId;
        public BajaHabitacion(string[] listaValores,SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            this.generarBoxes();
            this.cargarBoxes(listaValores);
            habitacionId = listaValores[0];
        }

        private void btnDARBAJA_Click(object sender, EventArgs e)
        {
            string query = "UPDATE HOTEL_CUATRIVAGOS.HABITACIONES set Habitacion_Cerrada = 1 WHERE Habitacion_Id ="+habitacionId;
            conexion.executeOnly(query);
            MessageBox.Show("BAJA REALIZADA CON EXITO ");
            this.Close();
        }
        private void generarBoxes() 
        {
            boxes.Add(txtNHab);
            boxes.Add(txtPisoHotel);
            boxes.Add(txtHotel);
            boxes.Add(txtTipoHab);
            boxes.Add(txtUbicacion);
            boxes.Add(txtDesc);
        }
        private void cargarBoxes(string[] unaLista) 
        {
            int i = 1;
            foreach (var txtB in boxes)
            {
                txtB.Text = unaLista[i];
                i++;
            }
        }
    }
}
