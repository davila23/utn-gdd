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

namespace FrbaHotel.Facturar_Publicaciones
{
    public partial class TarjetaDeCredito : Form
    {
        String facturaID;
        String tipoDeTarjeta;
        UsuarioLogueado usuario;
        public TarjetaDeCredito(String codigoCliente,String facturaIDIn, UsuarioLogueado loged)
        {

            InitializeComponent();
            label2.Text = codigoCliente;
            facturaID = facturaIDIn;
            tipoTarjeta.Items.Add("Master Card");
            tipoTarjeta.Items.Add("VISA");
            tipoTarjeta.Items.Add("American Express");
            tipoTarjeta.Items.Add("Otro");
            dateTimePicker1.Value = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            usuario = loged;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tipoDeTarjeta = tipoTarjeta.SelectedItem.ToString();
                if (tipoTarjeta.SelectedItem.ToString()== "Otro")
                {
                    //Lanzo una ventanita extra que pida una marca de tarjeta nueva
                }
                String queryTarjeta = "exec HOTEL_CUATRIVAGOS.agregar_tarjeta " + facturaID + " , " + nroTarjeta.Text + ",'" + duenioTarjeta.Text + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "','"+ tipoDeTarjeta +"'";
                usuario.getConexion().executeOnly(queryTarjeta);

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
