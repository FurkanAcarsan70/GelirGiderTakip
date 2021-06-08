using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsGelirGiderTakip.Bağlantı
{
    class ConnectionClass
    {
        private static string SQLBağlantı = @"Server=(localdb)\MSSQLLocalDB; Database=GELİR_GİDER_TAKİP_DB; Trusted_Connection=true;";
        private static SqlConnection connection = new SqlConnection();
        private static SqlCommand command = new SqlCommand();
        private static SqlDataAdapter adapter = new SqlDataAdapter();
        public static SqlException sqlException = null;

        public static void Bağlantı()
        {
            connection = new SqlConnection(SQLBağlantı);
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static object Command(string Query)
        {
            object Obje = null;
            sqlException = null;
            command.Connection = connection;
            command.CommandText = Query;
            try
            {
                Obje = command.ExecuteScalar();
            }
            catch (SqlException SqlEx)
            {
                sqlException = SqlEx;
                MessageBox.Show(SqlEx.GetType().Name + " - " + SqlEx.Message);
            }
            return Obje;
        }

        public static DataTable DataTable(string Query)
        {
            DataTable data = new DataTable();
            sqlException = null;
            command.Connection = connection;
            command.CommandText = Query;
            adapter.SelectCommand = command;
            try
            {
                adapter.Fill(data);
            }
            catch (SqlException SqlEx)
            {
                sqlException = SqlEx;
                MessageBox.Show(SqlEx.GetType().Name + " - " + SqlEx.Message);
            }
            return data;
        }
    }
}
