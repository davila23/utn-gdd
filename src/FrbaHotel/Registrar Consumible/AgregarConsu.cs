using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Registrar_Consumible
{
    public partial class AgregarConsu : Form
    {
        RegConsumible form;
        SQLConnector conexion;
        public AgregarConsu(RegConsumible consumibleForm,SQLConnector conec)
        {
            InitializeComponent();
            form = consumibleForm;
            conexion = conec;
            try{
                DataTable consus =conexion.consulta("SELECT Consumible_Desc FROM HOTEL_CUATRIVAGOS.CONSUMIBLES");
                foreach (DataRow row in consus.Rows) {
                    cBlistado.Items.Add(row[0].ToString());
                }
            }
            catch (Exception exec)
            {
                MessageBox.Show(exec.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtCantidad.Text == "" || cBlistado.SelectedIndex==-1) 
            {
                MessageBox.Show("Complete los campos");
            }
            else
            {
                form.agregarAlGrid(cBlistado.SelectedItem.ToString(), txtCantidad.Text);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
