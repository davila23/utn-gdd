using System;
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
    public partial class BajaCliente : Form
    {


        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        string clienteId;
        string datosId;
        public BajaCliente(string[] listaValores, SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            clienteId = listaValores[0];
            datosId = listaValores[1];
            this.generarBoxes();
            this.cargarBoxes(listaValores);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string queryViolento = "UPDATE HOTEL_CUATRIVAGOS.CLIENTES set Cliente_Deshabilitado = 1 WHERE Cliente_Id ='"+clienteId+"' AND Cliente_Datos = '"+datosId+"'";
            conexion.executeOnly(queryViolento);
            MessageBox.Show("Cliente dado de baja con exito!");
            this.Close();
        }
        private void cargarBoxes(string[] unaLista)
        {
            int i = 2;
            foreach (var txtB in boxes)
            {
                txtB.Text = unaLista[i];
                i++;
            }
        }
        private void generarBoxes()
        {
            boxes.Add(txt1);
            boxes.Add(txt2);
            boxes.Add(txt3);
            boxes.Add(txt4);
            boxes.Add(txt5);
            boxes.Add(txt6);
            boxes.Add(txt7);
            boxes.Add(txt8);
            boxes.Add(txt9);
            boxes.Add(txt10);
            boxes.Add(txt11);
            boxes.Add(txt12);
        }


    }
}
