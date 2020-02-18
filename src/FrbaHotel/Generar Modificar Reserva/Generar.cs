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

namespace FrbaHotel.Generar_Modificar_Reserva
{
    public partial class Generar : Form
    {
        SQLConnector coneccion;
        UsuarioLogueado usuario;
        DateTime fechaSistema;
        DataTable hoteles;
        Decimal precio = 0;
        string regimenId;
        string clienteId;
        string condi = "guest";

        public Generar(SQLConnector conec, String condicion)
        {
            InitializeComponent();
            coneccion = conec;
            inicializar();
            condi = condicion;
        }
        public Generar(UsuarioLogueado userLog)
        {
            InitializeComponent();
            usuario = userLog;
            coneccion = userLog.getConexion();
            coneccion = userLog.getConexion();
            condi = userLog.getRolAsignado();
            cBHoteles.Items.Add(usuario.getHotelAsignado());
            cBHoteles.SelectedIndex = 0;
            cBHoteles.Enabled = false;
            inicializar();
        }
        public void setClienteId(string cliente)
        {
            clienteId = cliente;
        }

        private void inicializar()
        {
            fechaSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            inicioDateTimePicker1.Value = fechaSistema;
            finDateTimePicker.Value = fechaSistema.AddDays(1);
            hoteles = coneccion.consulta("SELECT Hotel_Id,Hotel_Recarga_Estrella FROM HOTEL_CUATRIVAGOS.HOTELES");
            foreach (DataRow dr in hoteles.Rows)
            {
                cBHoteles.Items.Add(dr["Hotel_ID"].ToString());
            }
        }

        private void cBHoteles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cBHoteles.SelectedIndex != -1)
            {
                dGVRegimen.DataSource = coneccion.consulta("SELECT R.Regimen_Id,R.Regimen_Desc,R.Regimen_Precio FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA R, HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL RH WHERE R.Regimen_Id = RH.Regimen_Id AND R.Regimen_Inactivo = 0 AND RH.Hotel_Id = " + cBHoteles.SelectedItem);
            }
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            string query = "";
            if (cBHoteles.SelectedIndex == -1 || dGVRegimen.SelectedCells == null)
            {
                MessageBox.Show("Complete todos los campos");
            }
            else
            {
                query = "SELECT TH.Tipo_Hab_Desc,H.Habitacion_Piso,H.Habitacion_Vista,H.Habitacion_Id,H.Habitacion_Num,TH.Tipo_Hab_Porc FROM HOTEL_CUATRIVAGOS.HABITACIONES H, HOTEL_CUATRIVAGOS.TIPO_HABITACION TH,HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL RH WHERE Habitacion_Cerrada != 1 AND Habitacion_Ocupada != 1"
                    + "AND H.Habitacion_Hotel = " + cBHoteles.SelectedItem + " GROUP BY TH.Tipo_Hab_Desc,H.Habitacion_Piso,H.Habitacion_Vista,H.Habitacion_Id,H.Habitacion_Num,TH.Tipo_Hab_Porc";
                try
                {
                    dataGridView1.DataSource = coneccion.consulta(query);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString() + " en query: " + query);
                }
            }
        }

        private void btnConfirmacion_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 1)
            {
                MessageBox.Show("Elija una habitacion para generar la reserva");
            }
            else
            {

                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    precio += this.calcularPrecio();
                }
                if (confirmarReserva(precio) == DialogResult.Yes)
                {
                    if (clienteEnSistema() == DialogResult.Yes)
                    {
                        BuscarCliente levantarBusqueda = new BuscarCliente(coneccion, this);
                        this.Hide();
                        levantarBusqueda.ShowDialog();
                        finalizarReserva();
                    }
                    else
                    {
                        FrbaHotel.ABM_de_Cliente.AltaCliente levantarAlta = new FrbaHotel.ABM_de_Cliente.AltaCliente(coneccion, this);
                        this.Hide();
                        levantarAlta.ShowDialog();
                        finalizarReserva();
                    }
                }
                else
                {
                    DialogResult resul = MessageBox.Show("La reserva no se ha efectuado, ¿desea hacer otra?", "confirmacion", MessageBoxButtons.YesNo);
                    if (resul == DialogResult.Yes)
                    {
                        limpiarTODO();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        private void finalizarReserva()
        {
            try
            {
                if (condi == null)
                {
                    string query = "declare @idReserva numeric(18,0) EXEC HOTEL_CUATRIVAGOS.generar_reserva '" + fechaSistema.ToString("yyyyMMdd") + "','" + inicioDateTimePicker1.Value.ToString("yyyyMMdd")
                        + "','" + finDateTimePicker.Value.ToString("yyyyMMdd") + "'," + regimenId + "," + clienteId + "," + cBHoteles.SelectedItem + "," + usuario.conseguirIdUser() + ",@idReserva out SELECT @idReserva";
                    DataTable idReser = coneccion.consulta(query);
                    foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                    {
                        string miniQuery = "INSERT INTO HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION VALUES(" + idReser.Rows[0][0].ToString() + "," + dr.Cells["Habitacion_Id"].Value.ToString() + ")";
                        coneccion.executeOnly(miniQuery);
                    }
                    MessageBox.Show("Reserva generada exitosamente.\n ID:" + idReser.Rows[0][0].ToString());
                    this.Hide();
                }
                else
                {
                    string query = "declare @idReserva numeric(18,0) EXEC HOTEL_CUATRIVAGOS.generar_reserva '" + fechaSistema.ToString("yyyyMMdd") + "','" + inicioDateTimePicker1.Value.ToString("yyyyMMdd")
                             + "','" + finDateTimePicker.Value.ToString("yyyyMMdd") + "'," + regimenId + "," + clienteId + "," + cBHoteles.SelectedItem + ",NULL,@idReserva out SELECT @idReserva";
                    DataTable idReser = coneccion.consulta(query);
                    foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                    {
                        string miniQuery = "INSERT INTO HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION VALUES(" + idReser.Rows[0][0].ToString() + "," + dr.Cells["Habitacion_Id"].Value.ToString() + ")";
                        coneccion.executeOnly(miniQuery);
                    }
                    MessageBox.Show("Reserva generada exitosamente.\n ID:" + idReser.Rows[0][0].ToString());
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void limpiarTODO()
        {
            precio = 0;
            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dGVRegimen.Refresh();
        }

        private DialogResult confirmarReserva(Decimal unPrecio)
        {
            DialogResult resultado = MessageBox.Show("La reserva cuesta: " + unPrecio.ToString() + " u$s.\n ¿Desea confirmar?", "confirmacion", MessageBoxButtons.YesNo);
            return resultado;
        }
        public DialogResult clienteEnSistema()
        {
            return MessageBox.Show("¿Ya esta registrado como cliente en nuestra cadena hotelera?", "confirmacion", MessageBoxButtons.YesNo);
        }
        private Decimal calcularPrecio()
        {
            Decimal valorFinal = 0;
            Decimal porcHab = 0;
            Decimal recargaHotel = 0;
            Decimal valorRegimen = 0;
            foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
            {
                porcHab += Convert.ToDecimal(dr.Cells["Tipo_Hab_Porc"].Value);
            }
            foreach (DataRow dr in hoteles.Rows)
            {
                if (dr["Hotel_ID"].ToString() == cBHoteles.SelectedItem.ToString())
                {
                    recargaHotel = Convert.ToDecimal(dr["Hotel_Recarga_Estrella"]);
                }
            }
            foreach (DataGridViewRow dr in dGVRegimen.SelectedRows)
            {
                valorRegimen = Convert.ToDecimal(dr.Cells["Regimen_Precio"].Value);
                regimenId = Convert.ToString(dr.Cells["Regimen_Id"].Value);

            }
            valorFinal = (valorRegimen * porcHab) + recargaHotel;
            return valorFinal;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}