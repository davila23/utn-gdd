using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using FrbaCommerce.Sistema;


namespace FrbaCommerce.Login
{
    class LoginDatos
    {
        public static int logeoSql(string nombreUsuario, string passHaseada) {
            SQLConnector conec = SQLConnector.getInstance();
            string querito = "exec HOTEL_CUATRIVAGOS.proc_login User_Id,Userpass FROM HOTEL_CUATRIVAGOS.Usuario where (User_Id ='" +nombreUsuario+"')and (Userpass = '" +passHaseada+"')";
            int valorLogeo = conec.logearse(querito);
            return valorLogeo;
            }
        public static List<string> cantidadDeRoles(string nombreUsuario) {
        List<string> rolesUsuario = new List<string>();
            //ACA HAY QUE HACER EL SELECT PARA PEDIR TODOS LOS ROLES QUE TIENE
        SQLConnector conec = SQLConnector.getInstance();
        string querito = "SELECT User_Id,Userpass FROM HOTEL_CUATRIVAGOS.Usuario where (User_Id ='" + nombreUsuario + "')";
        rolesUsuario = conec.ObtenerRoles(querito);
        return rolesUsuario;
        }
    }
}
