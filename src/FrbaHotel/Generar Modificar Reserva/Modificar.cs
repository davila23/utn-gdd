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
    public partial class Modificar : Form
    {
        SQLConnector conexion;
        UsuarioLogueado usuario;
        DataTable regimenes;
        DataTable fechas;
        DateTime fechaSistema;
        string hotelID;
        string condi = null;
        string clienteId;
        string idregmin;
        Decimal porc;
        Decimal recargaHotel;
        public Modificar(SQLConnector conec, String condicion)
        {
            InitializeComponent();
            conexion = conec;
            condi = condicion;
            inicializar();
        }
        public Modificar(UsuarioLogueado user)
        {
            InitializeComponent();
            usuario = user;
            conexion = usuario.getConexion();
            inicializar();
        }
        private void inicializar()
        {
            fechaSistema = Convert.ToDateTime(ConfigurationSettings.AppSettings["fecha"]);
            dateTimePicker1.Value = fechaSistema;
            dateTimePicker2.Value = fechaSistema.AddDays(1);
        }

        private void btnCambiarRegimen_Click(object sender, EventArgs e)
        {
            Regimenes levantarRegimenes = new Regimenes(txtRegimenActual.Text, regimenes, this);
            this.Hide();
            levantarRegimenes.ShowDialog();
            this.Show();
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodReser.Text))
            {
                MessageBox.Show("Ingrese un codigo reserva");
            }
            else
            {
                try
                {
                    string query = "SELECT H.Habitacion_Id,H.Habitacion_Num,H.Habitacion_Piso,H.Habitacion_Hotel,H.Habitacion_Tipo,H.Habitacion_Vista,H.Habitacion_Desc,R.Reserva_Regimen FROM HOTEL_CUATRIVAGOS.RESERVAS R, HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION RPH, HOTEL_CUATRIVAGOS.HABITACIONES H WHERE H.Habitacion_Id = RPH.Habitacion_Id AND RPH.Reserva_Id =" + txtCodReser.Text + "AND R.Reserva_Id =" + txtCodReser.Text + " AND R.Reserva_Estado != 'Efectivizada' AND R.Reserva_Estado != 'Cancelada'";
                    dataGridView1.DataSource = conexion.consulta(query);
                    hotelID = dataGridView1.Rows[0].Cells["Habitacion_Hotel"].Value.ToString();
                    DataTable porcs = conexion.consulta("SELECT Tipo_Hab_Porc FROM HOTEL_CUATRIVAGOS.TIPO_HABITACION WHERE Tipo_Hab_Id = " + dataGridView1.Rows[0].Cells["Habitacion_Tipo"].Value.ToString());
                    porc = Convert.ToDecimal(porcs.Rows[0][0]);
                    DataTable recargas = conexion.consulta("SELECT Hotel_Recarga_Estrella FROM HOTEL_CUATRIVAGOS.HOTELES WHERE Hotel_Id =" + hotelID);
                    recargaHotel = Convert.ToDecimal(recargas.Rows[0][0]);
                    setClienteIdyRegimenId();
                    txtRegimenActual.Text = dataGridView1.Rows[0].Cells["Reserva_Regimen"].Value.ToString();
                    dataGridView1.Columns.Remove("Reserva_Regimen");
                    string habitacionesDisp = "SELECT H.Habitacion_Id,H.Habitacion_Num,H.Habitacion_Piso,H.Habitacion_Hotel,H.Habitacion_Tipo,H.Habitacion_Vista,H.Habitacion_Desc FROM HOTEL_CUATRIVAGOS.HABITACIONES H WHERE H.Habitacion_Ocupada = 0 AND H.Habitacion_Cerrada = 0 AND H.Habitacion_Hotel = " + hotelID + " AND H.Habitacion_Id NOT IN (SELECT RPH.Habitacion_Id FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION RPH where RPH.Reserva_Id=" + txtCodReser.Text + ")";
                    dataGridView2.DataSource = conexion.consulta(habitacionesDisp);
                    regimenes = conexion.consulta("SELECT R.Regimen_Id,R.Regimen_Desc,R.Regimen_Precio FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA R, HOTEL_CUATRIVAGOS.REGIMEN_X_HOTEL RH WHERE R.Regimen_Id = RH.Regimen_Id AND R.Regimen_Inactivo = 0 AND RH.Hotel_Id = " + hotelID);
                    fechas = conexion.consulta("SELECT R.Reserva_FechaIng FROM HOTEL_CUATRIVAGOS.RESERVAS R WHERE R.Reserva_Id =" + txtCodReser.Text);
                    dateTimePicker1.Value = Convert.ToDateTime(fechas.Rows[0][0].ToString());
                    dateTimePicker2.Value = dateTimePicker1.Value.AddDays(1);
                }
                catch
                {
                    MessageBox.Show("No se puede modificar una reserva efectivizada o cancelada.");
                    txtCodReser.Text = "";
                }
            }
        }

        private void btnQuitarHab_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    string deleteQuery = "DELETE FROM HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION WHERE Reserva_Id =" + txtCodReser.Text + " AND Habitacion_Id =" + dr.Cells["Habitacion_Id"].Value.ToString();
                    dataGridView1.Rows.RemoveAt(dr.Index);
                    conexion.executeOnly(deleteQuery);
                }
            }
        }
        private void btnAgregarHab_Click(object sender, EventArgs e)
        {
            DataTable reservadas = dataGridView1.DataSource as DataTable;
            DataTable agregar = new DataTable();
            if (dataGridView2.SelectedRows.Count >= 1)
            {
                foreach (DataGridViewRow dr in dataGridView2.SelectedRows)
                {
                    DataRow row = (dr.DataBoundItem as DataRowView).Row;
                    reservadas.ImportRow(row);
                    string miniQuery = "INSERT INTO HOTEL_CUATRIVAGOS.RESERVAS_X_HABITACION VALUES(" + txtCodReser.Text + "," + dr.Cells["Habitacion_Id"].Value.ToString() + ")";
                    conexion.executeOnly(miniQuery);
                    dataGridView2.Rows.RemoveAt(dr.Index);
                }
            }
            dataGridView1.DataSource = reservadas;
        }
        private DialogResult confirmarModificacion(Decimal unPrecio)
        {
            DialogResult resultado = MessageBox.Show("La modificacion cuesta: " + unPrecio.ToString() + " u$s.\n ¿Desea confimar ?", "confirmacion", MessageBoxButtons.YesNo);
            return resultado;
        }
        private void btnModificarReser_Click(object sender, EventArgs e)
        {
            Decimal precio = this.calcularPrecio();
            MessageBox.Show("La reserva ahora va a costar:" + precio.ToString());
            if (condi == null)
            {
                string query = "EXEC HOTEL_CUATRIVAGOS.modificar_reserva '" + fechaSistema.ToString("yyyyMMdd") + "','" + dateTimePicker1.Value.ToString("yyyyMMdd")
                    + "','" + dateTimePicker2.Value.ToString("yyyyMMdd") + "'," + idregmin + "," + clienteId + "," + usuario.conseguirIdUser() + "," + txtCodReser.Text + "," + hotelID;
                DataTable idReser = conexion.consulta(query);
                MessageBox.Show("Reserva modificada exitosamente.");
                this.Hide();
            }
            else
            {
                string query = "EXEC HOTEL_CUATRIVAGOS.modificar_reserva '" + fechaSistema.ToString("yyyyMMdd") + "','" + dateTimePicker1.Value.ToString("yyyyMMdd")
                    + "','" + dateTimePicker2.Value.ToString("yyyyMMdd") + "'," + idregmin + "," + clienteId + ",NULL," + txtCodReser.Text + "," + hotelID;
                DataTable idReser = conexion.consulta(query);
                MessageBox.Show("Reserva modificada exitosamente.");
                this.Hide();
            }
        }
        private void setClienteIdyRegimenId()
        {
            string query = "SELECT R.Reserva_Cliente,R.Reserva_Regimen FROM HOTEL_CUATRIVAGOS.RESERVAS R WHERE R.Reserva_Id =" + txtCodReser.Text;
            DataTable ids = conexion.consulta(query);
            foreach (DataRow dr in ids.Rows)
            {
                clienteId = dr["Reserva_Cliente"].ToString();
                idregmin = dr["Reserva_Regimen"].ToString();
            }
        }
        public void setearNuevoRegimen(DataGridViewRow row)
        {
            idregmin = row.Cells["Regimen_Id"].Value.ToString();
            txtRegimenActual.Text = row.Cells["Regimen_Id"].Value.ToString();
        }
        private Decimal calcularPrecio()
        {
            DataTable regimen = conexion.consulta("SELECT Regimen_Precio FROM HOTEL_CUATRIVAGOS.REGIMENES_ESTADIA WHERE Regimen_Id =" + idregmin);
            Decimal valorRegimen = Convert.ToDecimal(regimen.Rows[0][0]);


            return (valorRegimen * porc) + recargaHotel;
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }
    }
}