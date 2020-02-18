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
    public partial class ModifHabitacion : Form
    {
        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        string habitacionId;
        public ModifHabitacion(string[] listaValores,SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            habitacionId = listaValores[0];
            this.generarBoxes();
            this.cargarBoxes(listaValores);
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
        private void generarBoxes() 
        {
            boxes.Add(txtNHab);
            boxes.Add(txtPH);
            boxes.Add(txtH);
            boxes.Add(txtTHab);
            boxes.Add(txtUbi);
            boxes.Add(txtDesc);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string queryModif = "EXEC HOTEL_CUATRIVAGOS.modificacion_habitacion "+txtNHab.Text+","+txtPH.Text+","+txtH.Text+","+txtTHab.Text+",'"+txtUbi.Text+"','"+txtDesc.Text+"',"+habitacionId;
            try
            {
                conexion.executeOnly(queryModif);
                MessageBox.Show("Habitación modificada con exito");
                this.Close();
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
