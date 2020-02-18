using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class BajaRol : Form
    {
        SQLConnector conexion;
        List<TextBox> boxes = new List<TextBox>();
        public BajaRol(string[] listaValores,SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            boxes.Add(txtId);
            boxes.Add(txtDesc);
            boxes.Add(txtEST);
            this.cargarBoxes(listaValores);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            string queryBaja = "UPDATE HOTEL_CUATRIVAGOS.ROLES set Rol_estado = 1 WHERE Rol_Id ="+txtId.Text;
            try {
                conexion.executeOnly(queryBaja);
                MessageBox.Show("Rol dado de baja con exito");
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void cargarBoxes(string[] unaLista)
        {
            int i = 0;
            foreach (var txtB in boxes)
            {
                txtB.Text = unaLista[i];
                i++;
            }
        }
    }
}
