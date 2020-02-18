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


namespace FrbaHotel.Cancelar_Reserva
{
    public partial class CancelReser : Form
    {
        DateTime fechaActualSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
        SQLConnector conexion;
        string idGral = null;
        public CancelReser(SQLConnector conecc, string criterio)
        {
            InitializeComponent();
            txtFecCancel.Text = fechaActualSistema.ToString("yyyyMMdd");
            conexion = conecc;
        }
        public CancelReser(UsuarioLogueado userLog)
        {
            idGral = userLog.conseguirIdUser();
            conexion = userLog.getConexion();
            txtFecCancel.Text = fechaActualSistema.ToString("yyyyMMdd");
        }

        private void btnAceptarCancel_Click(object sender, EventArgs e)
        {
            string queryCancel = "";
            if (idGral == null && !string.IsNullOrEmpty(txtMotivo.Text) && !string.IsNullOrEmpty(txtNroReserva.Text))
            {
                queryCancel = "EXEC HOTEL_CUATRIVAGOS.cancelar_reserva '" + txtFecCancel.Text + "'," + txtNroReserva.Text + ",NULL,'" + txtMotivo.Text + "'";
            }
            else if (!string.IsNullOrEmpty(txtMotivo.Text) && !string.IsNullOrEmpty(txtNroReserva.Text) &&
                    !string.IsNullOrEmpty(idGral))
            {
                queryCancel = "EXEC HOTEL_CUATRIVAGOS.cancelar_reserva '" + txtFecCancel.Text + "'," + txtNroReserva.Text + "," + idGral + ",'" + txtMotivo.Text + "'";
            }
            else
            {
                MessageBox.Show("Por favor complete todo los campos");
                this.limpiarCampos();
                return;
            }
            try
            {
                conexion.executeOnly(queryCancel);
                MessageBox.Show("Reserva Cancelada con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        private void limpiarCampos() { txtNroReserva.Text = ""; txtMotivo.Text = ""; }

    }
}
