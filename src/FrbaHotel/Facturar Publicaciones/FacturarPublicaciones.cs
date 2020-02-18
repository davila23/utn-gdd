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
    public partial class FacturarEstadia : Form
    {
        UsuarioLogueado usuario;
        String fechaSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]).ToString("yyyyMMdd");
        string RPH_ID = "";
        public FacturarEstadia(UsuarioLogueado userLog)
        {
            InitializeComponent();
            btnFacturar.Enabled = false;
            usuario = userLog;
            cBFormaPago.Items.Add("Efectivo");
            cBFormaPago.Items.Add("Tarjeta de credito");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtClieCod.Text == "")
            {
                MessageBox.Show("Ingrese cliente");
            }
            else
            {
                string query = "SELECT * FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION, HOTEL_CUATRIVAGOS.RESERVAS, HOTEL_CUATRIVAGOS.ESTADIAS, HOTEL_CUATRIVAGOS.FACTURA_ITEM WHERE Reserva_Cliente =" + txtClieCod.Text + " AND Reserva_Hotel =" + usuario.getHotelAsignado() + " AND RESERVAS.Reserva_Id = RESERVAS_X_HABITACION.Reserva_Id AND RESERVAS_X_HABITACION.RPH_Id = ESTADIAS.Estadia_RPH AND FACTURA_ITEM.Item_Factura_Id = ESTADIAS.Estadia_Id AND FACTURA_ITEM.Item_Factura IS NULL AND ESTADIAS.Estadia_Fecha_Salida is not null ";
                dataGridViewEsta.DataSource = usuario.getConexion().consulta(query);
            }
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            txtClieCod.Text = "";
            cBFormaPago.SelectedIndex = -1;
            dataGridViewEsta.DataSource = null;
            dataGridViewEsta.Refresh();
            dataGridViewConsu.DataSource = null;
            dataGridViewConsu.Refresh();
        }

        private void btnBuscarConsu_Click(object sender, EventArgs e)
        {
            if (dataGridViewEsta.SelectedRows.Count >= 1)
            {
                btnFacturar.Enabled = true;
                foreach (DataGridViewRow dr in dataGridViewEsta.SelectedRows)
                {
                   RPH_ID = dr.Cells["RPH_Id"].Value.ToString();
                    string query = "SELECT CONSUMIBLES.Consumible_Desc, CONSUMIBLES_X_HABITACION.Consumible_Cantidad FROM HOTEL_CUATRIVAGOS.CONSUMIBLES_X_HABITACION, HOTEL_CUATRIVAGOS.CONSUMIBLES WHERE CONSUMIBLES_X_HABITACION.RPH_Id =" + RPH_ID + "AND CONSUMIBLES.Consumible_Id = CONSUMIBLES_X_HABITACION.Consumible_Id";
                    dataGridViewConsu.DataSource = usuario.getConexion().consulta(query);
                }
            }
            else { MessageBox.Show("Eliga una estadia para facturar"); }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                string queryFinal = "declare @facturaId numeric(18,0) EXEC HOTEL_CUATRIVAGOS.generar_factura " + txtClieCod.Text + "," + fechaSistema + ",@facturaId out"
                                    + " SELECT @facturaId";
                string facturaID = usuario.getConexion().consulta(queryFinal).Rows[0].ItemArray[0].ToString();
                usuario.getConexion().executeOnly("EXEC HOTEL_CUATRIVAGOS.agregar_items " + facturaID + "," + RPH_ID);
                MessageBox.Show("Cliente: " + txtClieCod.Text +
                                "\n Total a pagar:" + usuario.getConexion().consulta("SELECT Factura_Total FROM HOTEL_CUATRIVAGOS.FACTURAS WHERE Factura_Id =" + facturaID).Rows[0].ItemArray[0].ToString());
                if (cBFormaPago.SelectedItem.ToString().Equals("Tarjeta de credito"))
                {
                    TarjetaDeCredito tarjetaDeCredito = new TarjetaDeCredito(txtClieCod.Text, facturaID, usuario);
                    this.Hide();
                    tarjetaDeCredito.ShowDialog();
                    //this.Show();
                }
                MessageBox.Show("Facturacion realizada con exito");
                this.btnLimpieza_Click(sender, e);

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cBFormaPago_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
