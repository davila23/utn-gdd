using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class ModifConsu : Form
    {
        RegConsumible consumible;
        public ModifConsu(RegConsumible consumibleForm)
        {
            InitializeComponent();
            consumible = consumibleForm;
            txtDesc.Text = consumible.getDesc();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "")
            {
                MessageBox.Show("Ingresa una nueva cantidad");
            }
            else 
            {
                consumible.modificarGrid(txtDesc.Text, txtCantidad.Text);
                this.Close();
            }
        }
    }
}
