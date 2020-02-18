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

namespace FrbaHotel.Registrar_Estadia
{
    public partial class Ingreso_Egreso : Form
    {
        DateTime fechaSistema;
        UsuarioLogueado usuario;
        SQLConnector conexion;
        double cantPasajeros = 0;
        string clienteInicial = null;
        string rphId;
        public Ingreso_Egreso(UsuarioLogueado userLog)
        {
            InitializeComponent();
            fechaSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            usuario = userLog;
            conexion = usuario.getConexion();
        }
        public void configurarOUT()
        {
            btnIngresar.Text = "Egreso";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNroReser.Text))
            {
                MessageBox.Show("Complete el nro de reserva");
            }
            else if (btnIngresar.Text == "Registrar")
            {
                string query = "SELECT R.Reserva_Cliente,R.Reserva_CantNoches,H.Habitacion_Num,H.Habitacion_Tipo,H.Habitacion_Vista,H.Habitacion_Tipo,R.Reserva_FechaIng,RPH.RPH_Id FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION RPH, HOTEL_CUATRIVAGOS.HABITACIONES H, HOTEL_CUATRIVAGOS.RESERVAS R WHERE H.Habitacion_Id = RPH.Habitacion_Id AND R.Reserva_Id = RPH.Reserva_Id AND RPH.Reserva_Id =" + txtNroReser.Text + " AND R.Reserva_Estado <> 'Efectivizada' AND R.Reserva_Estado != 'Cancelada'";
                dataGridView1.DataSource = conexion.consulta(query);
            }
            else
            {
                string query = "SELECT R.Reserva_Cliente,R.Reserva_CantNoches,H.Habitacion_Num,H.Habitacion_Tipo,H.Habitacion_Vista,H.Habitacion_Tipo,R.Reserva_FechaIng,RPH.RPH_Id FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION RPH, HOTEL_CUATRIVAGOS.HABITACIONES H,HOTEL_CUATRIVAGOS.RESERVAS R, HOTEL_CUATRIVAGOS.ESTADIAS E WHERE H.Habitacion_Id = RPH.Habitacion_Id AND R.Reserva_Id = RPH.Reserva_Id AND RPH.Reserva_Id =" + txtNroReser.Text + " AND R.Reserva_Estado = 'Efectivizada' AND E.Estadia_RPH = RPH.RPH_Id AND E.Estadia_Fecha_Salida is null";
                dataGridView1.DataSource = conexion.consulta(query);
            }
            if (dataGridView1.DataSource == null)
            {
                MessageBox.Show("No hay reservas para mostrar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNroReser.Text = "";
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            cantPasajeros = 0;
            rphId = "";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {

                if (btnIngresar.Text == "Registrar")
                {
                    clienteInicial = row.Cells["Reserva_Cliente"].Value.ToString();
                    string query = "SELECT Tipo_Cant_Maxima_Huespedes FROM HOTEL_CUATRIVAGOS.TIPO_HABITACION WHERE Tipo_Hab_Id =" + row.Cells["Habitacion_Tipo"].Value.ToString();
                    cantPasajeros = Convert.ToDouble(conexion.consulta(query).Rows[0].ItemArray[0]);
                    rphId = row.Cells["RPH_Id"].Value.ToString();
                    cargarPasajeros(cantPasajeros, clienteInicial);
                    try
                    {
                        string queryFinal = "EXEC HOTEL_CUATRIVAGOS.check_in  " + row.Cells["RPH_Id"].Value.ToString() + "," + fechaSistema.ToString("yyyyMMdd");
                        conexion.executeOnly(queryFinal);
                        MessageBox.Show("Check In realizado con exito");
                        this.Close();
                    }
                    catch (Exception exec)
                    {
                        MessageBox.Show(exec.Message);
                    }
                }
                else
                {
                    try
                    {
                        string queryFinal = "EXEC HOTEL_CUATRIVAGOS.check_out  " + row.Cells["RPH_Id"].Value.ToString() + ",'" + fechaSistema.ToString("yyyyMMdd") + "'";
                        conexion.executeOnly(queryFinal);
                        MessageBox.Show("Check Out realizado con exito");
                        this.Close();
                    }
                    catch (Exception ex) { MessageBox.Show(ex.Message); }
                }
            }
        }
        private void cargarPasajeros(double cantidad, string clienteInicial)
        {
            setClienteID(clienteInicial);
            MessageBox.Show("A continuacion registre a los huespedes restantes.");
            for (double i = 2; i < cantidad; i++)
            {
                Generar_Modificar_Reserva.Generar generar = new FrbaHotel.Generar_Modificar_Reserva.Generar(usuario);
                DialogResult resultado = generar.clienteEnSistema();
                if (resultado == DialogResult.Yes)
                {
                    Generar_Modificar_Reserva.BuscarCliente levantarBusqueda = new FrbaHotel.Generar_Modificar_Reserva.BuscarCliente(usuario, this);
                    this.Hide();
                    levantarBusqueda.ShowDialog();
                    this.Show();
                }
                else
                {
                    FrbaHotel.ABM_de_Cliente.AltaCliente levantarAlta = new FrbaHotel.ABM_de_Cliente.AltaCliente(conexion);
                    this.Hide();
                    levantarAlta.ShowDialog();
                    Object obj = conexion.executeQueryEscalar("SELECT MAX(Cliente_Id) FROM HOTEL_CUATRIVAGOS.CLIENTES");
                    this.setClienteID(obj.ToString());
                    this.Show();
                }
            }
            MessageBox.Show("Huespedes registrados con exito");
        }
        public void setClienteID(string id)
        {
            string query = "INSERT INTO HOTEL_CUATRIVAGOS.HUESPEDES_X_HABITACION VALUES (" + rphId + "," + id + ")";
            conexion.executeOnly(query);
        }
        public string getClienteInicial()
        {
            return clienteInicial;
        }
    }
}
