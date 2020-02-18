using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;


namespace FrbaHotel.Sistema
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1001:TypesThatOwnDisposableFieldsShouldBeDisposable")]
    public class SQLConnector
    {
        private SqlConnection connection;

        public SQLConnector()
        {
            try
            {

                connection = new SqlConnection();
                connection.ConnectionString = ConfigurationSettings.AppSettings["ConexionBD"];
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
        }
        public Object executeQueryEscalar(string query)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;

            sqlCommand.Connection = this.connection;
            sqlCommand.CommandText = query;

            return sqlCommand.ExecuteScalar();
        }
        public void executeOnly(string query)
        {
            SqlCommand queryCommand = new SqlCommand();
            queryCommand.CommandTimeout = 999999999;

            queryCommand.Connection = this.connection;
            queryCommand.CommandText = query;
            queryCommand.ExecuteNonQuery();
            queryCommand.Dispose();
            queryCommand = null;
        }
        public DataTable consulta(string consulta)
        {
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.CommandTimeout = 999999999;

            sqlCommand.Connection = this.connection;
            sqlCommand.CommandText = consulta;

            SqlDataAdapter dataAdapter = new SqlDataAdapter(consulta, this.connection);

            DataTable dataTable = new DataTable();
            dataTable.Locale = System.Globalization.CultureInfo.InvariantCulture;

            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public UsuarioLogueado registrarse()
        {
            return null;
        }



    }
}
