using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class Regimenes : Form
    {
        Modificar modificarForm;
        public Regimenes(string regimenActual, DataTable regimenes, Modificar form)
        {
            InitializeComponent();
            modificarForm = form;
            DataTable nuevoR;
            nuevoR = regimenes;
            dataGridView1.DataSource = nuevoR;

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("por favor elija un nuevo regimen");
            }
            else
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    modificarForm.setearNuevoRegimen(dr);
                }
                this.Close();
            }
        }
    }
}