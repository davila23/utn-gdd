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
using FrbaHotel.Generar_Modificar_Reserva;

namespace FrbaHotel.ABM_de_Cliente
{
    public partial class AltaCliente : Form
    {
        List<TextBox> txtBoxes = new List<TextBox>();
        SQLConnector conexion;
        Generar geneF = null;
        public AltaCliente(SQLConnector conec)
        {
            InitializeComponent();
            inicializar();
            conexion = conec;
        }
        public AltaCliente(SQLConnector conec, Generar_Modificar_Reserva.Generar genForm)
        {
            InitializeComponent();
            inicializar();
            conexion = conec;
            geneF = genForm;
        }
        private void inicializar()
        {
            txtBoxes.Add(txtNom);
            txtBoxes.Add(txtApellido);
            tipoDocSelector.Items.Add("DNI");
            tipoDocSelector.Items.Add("Pasaporte");
            tipoDocSelector.Items.Add("Cedula");
            txtBoxes.Add(txtNroDoc);
            txtBoxes.Add(txtMail);
            txtBoxes.Add(txtDireccion);
            txtBoxes.Add(txtNroCalle);
            txtBoxes.Add(txtNacionalidad);
            dateTimePicker1.Value = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string queryCliente = "";
            foreach (var texto in txtBoxes)
            {
                if (String.IsNullOrEmpty(texto.Text))
                {
                    MessageBox.Show("Complete todos los campos");
                    break;
                }
            }
            if (txtPiso.Text == "" && txtDepto.Text == "")
            {
                queryCliente = " declare @Id numeric(18,0) exec HOTEL_CUATRIVAGOS.alta_cliente '" + txtNom.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",'"
                    + tipoDocSelector.SelectedItem.ToString() + "'," + txtNroDoc.Text + ",'" + txtMail.Text + "','" + txtDireccion.Text + "'," + txtNroCalle.Text + ",NULL,NULL,'" + dateTimePicker1.Value.ToString("yyyyMMdd") + "','" + txtNacionalidad.Text + "',@Id out SELECT @Id";
            }
            else
            {
                queryCliente = " declare @Id numeric(18,0) exec HOTEL_CUATRIVAGOS.alta_cliente '" + txtNom.Text + "','" + txtApellido.Text + "'," + txtTelefono.Text + ",'"
                 + tipoDocSelector.SelectedItem.ToString() + "'," + txtNroDoc.Text + ",'" + txtMail.Text + "','" + txtDireccion.Text + "'," + txtNroCalle.Text + "," + txtPiso.Text + ",'" + txtDepto.Text + "','" + dateTimePicker1.Value.ToString("yyyyMMdd") + "','" + txtNacionalidad.Text + "',@Id out SELECT @Id";
            }
            try
            {
                DataTable clienteId = conexion.consulta(queryCliente);
                MessageBox.Show("Cliente registrado con exito ID:" + clienteId.Rows[0].ItemArray[0].ToString());
                cargarId(clienteId.Rows[0].ItemArray[0].ToString());
                this.Close();
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
        public void cargarId(string id)
        {
            if (!(geneF == null))
            {
                geneF.setClienteId(id);
                this.Close();
                geneF.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
