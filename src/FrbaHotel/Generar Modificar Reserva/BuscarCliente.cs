using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;
using FrbaHotel.Registrar_Estadia;

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class BuscarCliente : Form
    {
        UsuarioLogueado usuario;
        SQLConnector conec;
        string clienteId;
        Generar generarForm;
        Ingreso_Egreso ingreso;
        public BuscarCliente(UsuarioLogueado userLog, Generar genForm)
        {
            InitializeComponent();
            usuario = userLog;
            conec = usuario.getConexion();
            cBTipoDoc.Items.Add("DNI");
            cBTipoDoc.Items.Add("Pasaporte");
            cBTipoDoc.Items.Add("Cedula");
            generarForm = genForm;
            ingreso = null;
        }
        public BuscarCliente(SQLConnector conexion, Generar genForm)
        {
            InitializeComponent();
            conec = conexion;
            cBTipoDoc.Items.Add("DNI");
            cBTipoDoc.Items.Add("Pasaporte");
            cBTipoDoc.Items.Add("Cedula");
            generarForm = genForm;
            ingreso = null;
        }
        public BuscarCliente(UsuarioLogueado userLog, Ingreso_Egreso ingForm)
        {
            InitializeComponent();
            usuario = userLog;
            conec = userLog.getConexion();
            ingreso = ingForm;
            generarForm = null;
            cBTipoDoc.Items.Add("DNI");
            cBTipoDoc.Items.Add("Pasaporte");
            cBTipoDoc.Items.Add("Cedula");

        }

        private void btnBusquedaClie_Click(object sender, EventArgs e)
        {
            string query = "";
            try
            {
                query = "SELECT * FROM HOTEL_CUATRIVAGOS.CLIENTES C, HOTEL_CUATRIVAGOS.DATOS_PERSONALES DP WHERE C.Cliente_Datos = DP.Datos_Id";
                if (ingreso != null)
                {
                    query += " AND C.Cliente_Id != " + ingreso.getClienteInicial() + " ";
                    //query += " AND C.Cliente_Id = " + ingreso.getClienteInicial() + " ";
                }
                if (txtMail.Text != "")
                {
                    query += " AND DP.Datos_Mail LIKE '%'" +txtMail.Text+ "%''";
                }
                if (cBTipoDoc.SelectedIndex != -1)
                {
                    query += " AND DP.Datos_Tipo_Ident LIKE '%'" + cBTipoDoc.SelectedItem.ToString() + "%''";
                }
                if (txtNDoc.Text != "")
                {
                    query += " AND DP.Datos_Nro_Ident =" + txtNDoc.Text + "";
                    
                }
                dataGridView1.DataSource = conec.consulta(query);
                DataGridViewButtonColumn col = new DataGridViewButtonColumn();
                col.UseColumnTextForButtonValue = true;
                col.Text = "Seleccionar";
                col.Name = "Seleccionar";
                dataGridView1.Columns.Add(col);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString() + " en query: " + query);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string[] valor = new string[e.ColumnIndex];

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                clienteId = dataGridView1.Rows[e.RowIndex].Cells["Cliente_Id"].Value.ToString();
                cargarId(clienteId);
                this.Close();
            }
        }
        public void cargarId(string id)
        {
            if (ingreso == null)
            {
                generarForm.setClienteId(id);
                generarForm.Show();
            }
            else
            {
                ingreso.setClienteID(id);
                ingreso.Show();
            }
        }

        private void btnLimpieza_Click(object sender, EventArgs e)
        {
            txtMail.Text = "";
            txtNDoc.Text = "";
            cBTipoDoc.SelectedIndex = -1;
        }
    }
}
