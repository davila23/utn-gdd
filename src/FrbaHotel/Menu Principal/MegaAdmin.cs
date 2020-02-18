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
    public partial class MegaAdmin : Form
    {
        
        UsuarioLogueado admin;
        public MegaAdmin(UsuarioLogueado user)
        {
            InitializeComponent();
            admin = user;
        }
        private void btnGENRESER_Click(object sender, EventArgs e)
        {
            FrbaHotel.Generar_Modificar_Reserva.Generar levantarGenerar = new FrbaHotel.Generar_Modificar_Reserva.Generar(admin);
            this.Hide();
            levantarGenerar.ShowDialog();
            this.Show();
        }

        private void btnCancelReser_Click(object sender, EventArgs e)
        {
            Cancelar_Reserva.CancelReser levantarCancel = new FrbaHotel.Cancelar_Reserva.CancelReser(admin.getConexion(), "recepcionista");
            this.Hide();
            levantarCancel.ShowDialog();
            this.Show();
        }

        private void btnABMCliente_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.ABMCliente levantarCliente = new FrbaHotel.ABM_de_Cliente.ABMCliente(admin.getConexion());
            this.Hide();
            levantarCliente.ShowDialog();
            this.Show();
        }

        private void btnRegEst_Click(object sender, EventArgs e)
        {
            Registrar_Estadia.RegEstadia levantarReg = new FrbaHotel.Registrar_Estadia.RegEstadia(admin);
            this.Hide();
            levantarReg.ShowDialog();
            this.Show();
        }

        private void btnRegConsu_Click(object sender, EventArgs e)
        {
            Registrar_Consumible.RegConsumible levantarReg = new FrbaHotel.Registrar_Consumible.RegConsumible(admin.getConexion());
            this.Hide();
            levantarReg.ShowDialog();
            this.Show();
        }

        private void btnFacPub_Click(object sender, EventArgs e)
        {
            Facturar_Publicaciones.FacturarEstadia levantarFac = new FrbaHotel.Facturar_Publicaciones.FacturarEstadia(admin);
            this.Hide();
            levantarFac.ShowDialog();
            this.Show();
        }

        private void btnListEsta_Click(object sender, EventArgs e)
        {
            Listado_Estadistico.ListEstadistico levantarListado = new FrbaHotel.Listado_Estadistico.ListEstadistico(admin.getConexion());
            this.Hide();
            levantarListado.ShowDialog();
            this.Show();
        }

        private void btnModReser_Click(object sender, EventArgs e)
        {
            Generar_Modificar_Reserva.Modificar levantarModificar = new FrbaHotel.Generar_Modificar_Reserva.Modificar(admin);
            this.Hide();
            levantarModificar.ShowDialog();
            this.Show();
        }
        private void btnRol_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.ABMRol levantarRol = new FrbaHotel.ABM_de_Rol.ABMRol(admin.getConexion());
            this.Hide();
            levantarRol.ShowDialog();
            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.ABMUsuario levantarUsuario = new FrbaHotel.ABM_de_Usuario.ABMUsuario(admin.getConexion());
            this.Hide();
            levantarUsuario.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.ABMCliente levantarCliente = new FrbaHotel.ABM_de_Cliente.ABMCliente(admin.getConexion());
            this.Hide();
            levantarCliente.ShowDialog();
            this.Show();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.ABMHotel levantarHotel = new FrbaHotel.ABM_de_Hotel.ABMHotel(admin);
            this.Hide();
            levantarHotel.ShowDialog();
            this.Show();
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.ABMHabitacion levantarHabitacion = new FrbaHotel.ABM_de_Habitacion.ABMHabitacion(admin.getConexion(), admin);
            this.Hide();
            levantarHabitacion.ShowDialog();
            this.Show();
        }

        private void btnREGIMEN_Click(object sender, EventArgs e)
        {
            ABM_de_Regimen.ABMRegimen levantarRegimen = new FrbaHotel.ABM_de_Regimen.ABMRegimen();
            this.Hide();
            levantarRegimen.ShowDialog();
            this.Show();
        }

        private void MegaAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void MegaAdmin_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
        }

    }
}
