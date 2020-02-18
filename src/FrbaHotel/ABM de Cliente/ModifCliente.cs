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

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class ModifCliente : Form
    {
        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        string clienteId;
        string datosId;
        public ModifCliente(string[] listaValores,SQLConnector conec)
        {
            
            InitializeComponent();
            conexion = conec;
            clienteId = listaValores[0];
            datosId = listaValores[1];
            tipoDocSelector.SelectedItem = listaValores[2];
            dateTimePicker1.Value = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            this.generarBoxes();
            this.cargarBoxes(listaValores);
            tipoDocSelector.Items.Add("DNI");
            tipoDocSelector.Items.Add("Pasaporte");
            tipoDocSelector.Items.Add("Cedula");
            
        }
        private void cargarBoxes(string[] unaLista)
        {
            int i = 3;        
            foreach(var txtB in boxes)
            {
                txtB.Text = unaLista[i];
                i++;
            }
            dateTimePicker1.Value = Convert.ToDateTime(unaLista[i]);
        }

        private void generarBoxes(){
            boxes.Add(txt1);
            boxes.Add(txt2);
            boxes.Add(txt3);
            boxes.Add(txt5);
            boxes.Add(txt6);
            boxes.Add(txt7);
            boxes.Add(txt8);
            boxes.Add(txt9);
            boxes.Add(txt10);
            boxes.Add(txt12);
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            string queryModif = "EXEC HOTEL_CUATRIVAGOS.modificacion_cliente '"+txt1.Text+"','"+txt2.Text+"',"+txt3.Text+",'"+ tipoDocSelector.SelectedItem.ToString() +"',"+txt5.Text+",'"+txt6.Text+"','"+txt7.Text+"',"+txt8.Text+","+txt9.Text+",'"+txt10.Text+"','"+dateTimePicker1.Value.ToString("yyyyMMdd")+"','"+txt12.Text+"',"+clienteId;
            try
            {
                conexion.executeOnly(queryModif);
                MessageBox.Show("Cliente modificado con exito");
                this.Close();
            }
            catch(Exception exe) 
            {
                MessageBox.Show(exe.Message);
            }
        }
    }
}
