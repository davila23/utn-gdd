using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;

namespace FrbaHotel.Sistema
{
    public class Administrador
    {
        SQLConnector conexion;
        public Administrador(SQLConnector conec)
        {
            conexion = conec;
        }
        public List<String> vendedoresConMayorFacturacion()
        {
            return null;
        }
        public List<String> vendedoresConMayoresCalificaciones()
        {
            return null;
        }
        public List<String> clientesConMayorCantidadDePublicacionesSinCalificar()
        {
            return null;
        }
        public List<String> rolesSistema()
        {
            string queryRoles = "SELECT R.Rol_Desc FROM HOTEL_CUATRIVAGOS.ROLES R GROUP BY R.Rol_Desc";
            DataTable roles = conexion.consulta(queryRoles);
            List<string> rolesSistema = new List<string>();
            foreach (DataRow row in roles.Rows)
            {
                rolesSistema.Add((string)row[0]);
            }
            return rolesSistema;
        }
    }
}
