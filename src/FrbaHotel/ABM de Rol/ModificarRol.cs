using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaHotel.Sistema;

namespace FrbaHotel.ABM_de_Rol
{
    public partial class ModificarRol : Form
    {
        SQLConnector conexion;
        string rolId;
        public ModificarRol(string[] listaValores ,SQLConnector conec)
        {
            InitializeComponent();
            conexion = conec;
            rolId = listaValores[0];
            DataTable funcActuales = conec.consulta("SELECT F.Func_Desc FROM HOTEL_CUATRIVAGOS.ROLES R, HOTEL_CUATRIVAGOS.FUNCIONALIDADES_X_ROL FR, HOTEL_CUATRIVAGOS.FUNCIONALIDADES F WHERE R.Rol_Id = FR.Rol_Id AND FR.Func_Id = F.Func_Id AND R.Rol_Id ="+rolId);
            foreach(DataRow row in funcActuales.Rows){
                cBFuncActuales.Items.Add(row["Func_Desc"].ToString());
            }
            DataTable funcSistema = conec.consulta("SELECT Func_Desc FROM HOTEL_CUATRIVAGOS.FUNCIONALIDADES");
            foreach (DataRow row in funcSistema.Rows)
            {
                cBFuncAAgregar.Items.Add(row["Func_Desc"].ToString());
            }
            txtEstado.Text = listaValores[2];
            txtNomRol.Text = listaValores[1];
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEstado.Text != "" || txtNomRol.Text != "")
                {
                    string query = "EXEC HOTEL_CUATRIVAGOS.modificacion_rol " + rolId + ",'" + txtNomRol.Text + "'," + txtEstado.Text;
                    conexion.executeOnly(query);
                }
                else
                {
                    MessageBox.Show("Complete los campos nombre y estado");
                }
                if (cBFuncAAgregar.SelectedIndex != -1)
                {
                    string query = "EXEC HOTEL_CUATRIVAGOS.alta_funcionalidad_por_rol '" + cBFuncAAgregar.SelectedItem.ToString() + "','" + txtNomRol.Text + "'";
                    conexion.executeOnly(query);
                }
                if (cBFuncActuales.SelectedIndex != -1)
                {
                    string query = "EXEC HOTEL_CUATRIVAGOS.baja_funcionalidad_por_rol '" + cBFuncActuales.SelectedItem.ToString() + "','" + txtNomRol.Text + "'";
                    conexion.executeOnly(query);
                }
                MessageBox.Show("Rol modificado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }
}
