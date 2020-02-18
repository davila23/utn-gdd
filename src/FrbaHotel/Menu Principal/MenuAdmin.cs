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
    public partial class MenuAdmin : Form
    {
        UsuarioLogueado userLog;
        List<string> listaFuncionalidades = new List<string>();
        public MenuAdmin(UsuarioLogueado usuario)
        {
            InitializeComponent();
            userLog = usuario;
            String query = "SELECT FUNCIONALIDADES.Func_Desc FROM HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL FR, HOTEL_CUATRIVAGOS.FUNCIONALIDADES, HOTEL_CUATRIVAGOS.ROLES R" +
            " WHERE FR.Func_Id = FUNCIONALIDADES.Func_Id" +
            " AND R.Rol_Id = FR.Rol_Id" +
            " AND R.Rol_Desc ='" + usuario.getRolAsignado() + "'";
            DataTable funcionalidades = usuario.getConexion().consulta(query);
            foreach (DataRow func in funcionalidades.Rows)
            {
                listaFuncionalidades.Add(func[0].ToString());
            }
        }

        private void btnRol_Click(object sender, EventArgs e)
        {
            ABM_de_Rol.ABMRol levantarRol = new FrbaHotel.ABM_de_Rol.ABMRol(userLog,listaFuncionalidades);
            this.Hide();
            levantarRol.ShowDialog();
            this.Show();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            ABM_de_Usuario.ABMUsuario levantarUsuario = new FrbaHotel.ABM_de_Usuario.ABMUsuario(userLog, listaFuncionalidades);
            this.Hide();
            levantarUsuario.ShowDialog();
            this.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            ABM_de_Cliente.ABMCliente levantarCliente = new FrbaHotel.ABM_de_Cliente.ABMCliente(userLog.getConexion(), listaFuncionalidades);
            this.Hide();
            levantarCliente.ShowDialog();
            this.Show();
        }

        private void btnHotel_Click(object sender, EventArgs e)
        {
            ABM_de_Hotel.ABMHotel levantarHotel = new FrbaHotel.ABM_de_Hotel.ABMHotel(userLog,listaFuncionalidades);
            this.Hide();
            levantarHotel.ShowDialog();
            this.Show();
        }

        private void btnHabitacion_Click(object sender, EventArgs e)
        {
            ABM_de_Habitacion.ABMHabitacion levantarHabitacion = new FrbaHotel.ABM_de_Habitacion.ABMHabitacion(userLog,listaFuncionalidades);
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
    }
}
