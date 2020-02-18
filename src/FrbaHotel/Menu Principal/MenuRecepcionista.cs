using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.Menu_Principal
{
    public partial class MenuRecepcionista : Form
    {
        UsuarioLogueado userLog;
        List<string> listaFuncionalidades = new List<string>();
        List<Button> listaBotones = new List<Button>();
        public MenuRecepcionista(UsuarioLogueado usuario)
        {
            InitializeComponent();
            userLog = usuario;
            String query = "SELECT FUNCIONALIDADES.Func_Desc FROM HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL FR, HOTEL_CUATRIVAGOS.FUNCIONALIDADES,HOTEL_CUATRIVAGOS.ROLES R" +
            " WHERE FR.Func_Id = FUNCIONALIDADES.Func_Id" +
            " AND R.Rol_Id = FR.Rol_Id" +
            " AND R.Rol_Desc ='" + usuario.getRolAsignado() + "'";
            DataTable funcionalidades = usuario.getConexion().consulta(query);
            foreach (DataRow func in funcionalidades.Rows)
            {
                listaFuncionalidades.Add(func[0].ToString());
            }
            agregarBotonesALista();
            activarBotones();
        }

        private void btnGENRESER_Click(object sender, EventArgs e)
        {
            FrbaHotel.Generar_Modificar_Reserva.Generar levantarGenerar = new FrbaHotel.Generar_Modificar_Reserva.Generar(userLog);
            this.Hide();
            levantarGenerar.ShowDialog();
            this.Show();
        }

        private void btnCancelReser_Click(object sender, EventArgs e)
        {
            Cancelar_Reserva.CancelReser levantarCancel = new FrbaHotel.Cancelar_Reserva.CancelReser(userLog.getConexion(), "recepcionista");
            this.Hide();
            levantarCancel.ShowDialog();
            this.Show();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.ABMCliente levantarCliente = new FrbaHotel.ABM_de_Cliente.ABMCliente(userLog.getConexion(), listaFuncionalidades);
            this.Hide();
            levantarCliente.ShowDialog();
            this.Show();
        }

        private void btnRegEst_Click(object sender, EventArgs e)
        {
            Registrar_Estadia.RegEstadia levantarReg = new FrbaHotel.Registrar_Estadia.RegEstadia(userLog, listaFuncionalidades);
            this.Hide();
            levantarReg.ShowDialog();
            this.Show();
        }

        private void btnRegConsu_Click(object sender, EventArgs e)
        {
            Registrar_Consumible.RegConsumible levantarReg = new FrbaHotel.Registrar_Consumible.RegConsumible(userLog.getConexion());
            this.Hide();
            levantarReg.ShowDialog();
            this.Show();
        }

        private void btnFacPub_Click(object sender, EventArgs e)
        {
            Facturar_Publicaciones.FacturarEstadia levantarFac = new FrbaHotel.Facturar_Publicaciones.FacturarEstadia(userLog);
            this.Hide();
            levantarFac.ShowDialog();
            this.Show();
        }

        private void btnListEsta_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.ListEstadistico levantarListado = new FrbaHotel.Listado_Estadistico.ListEstadistico(userLog.getConexion());
            this.Hide();
            levantarListado.ShowDialog();
            this.Show();
        }

        private void btnModReser_Click(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Modificar levantarModificar = new FrbaHotel.Generar_Modificar_Reserva.Modificar(userLog);
            this.Hide();
            levantarModificar.ShowDialog();
            this.Show();

        }
        private void agregarBotonesALista()
        {
            listaBotones.Add(btnABMCliente);
            listaBotones.Add(btnCancelReser);
            listaBotones.Add(btnFacPub);
            listaBotones.Add(btnGENRESER);
            listaBotones.Add(btnModReser);
            listaBotones.Add(btnRegConsu);
            listaBotones.Add(btnRegEst);
        }
        private void activarBotones()
        {
            foreach (Button boton in listaBotones)
            {
                if (listaFuncionalidades.Contains(boton.Text))
                {
                    boton.Enabled = true;
                    listaFuncionalidades.Remove(boton.Text);
                }
            }
        }
    }
}
