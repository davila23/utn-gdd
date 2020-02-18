using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Hotel
{
    public partial class BajaHotel : Form
    {
        SQLConnector conexion;
        string hotelId;
        List<TextBox> boxes = new List<TextBox>();
        public BajaHotel(string[] valores,SQLConnector conec)
        {
            InitializeComponent();
            hotelId = valores[0];
            conexion = conec;
            this.generarBoxes();
            this.cargarBoxes(valores);
        }
        private void generarBoxes()
        {
            boxes.Add(txtNom);
            boxes.Add(txtMail);
            boxes.Add(txtTelefono);
            boxes.Add(txtDom);
            boxes.Add(txtNroCalle);
            boxes.Add(txtCiudad);
            boxes.Add(txtPais);
            boxes.Add(txtEstrellas);
            boxes.Add(txtFecNac);
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

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string query = "UPDATE HOTEL_CUATRIVAGOS.HOTELES set Hotel_Cerrado = 1 WHERE Hotel_Id ="+hotelId;
            conexion.executeOnly(query);
            MessageBox.Show("A continuación ingrese el periodo de cierre del hotel.");
            periodoHotel levantarCierre = new periodoHotel(hotelId,conexion);
            levantarCierre.ShowDialog();
            this.Close();
        }
    }
}
