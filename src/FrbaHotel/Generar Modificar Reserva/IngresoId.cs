using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Generar_Modificar_Reserva;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class IngresoId : Form
    {
        Generar genForm;
        public IngresoId(Generar unaForm)
        {
            InitializeComponent();
            genForm = unaForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                genForm.setClienteId(textBox1.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Complete el id");
            }
        }
    }
}
