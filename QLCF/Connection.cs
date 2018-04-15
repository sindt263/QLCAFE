using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCF
{
    class Connection
    {
        public static SqlConnection conmyconnection;

        // mở kết nối

        public void connect()
        {
            conmyconnection = new SqlConnection(@"Data Source = DESKTOP-JEI3U4R\SQL2008; Initial Catalog = QLCF; Integrated Security = True");

            try
            {
                conmyconnection.Open();

            }
            catch (Exception)
            {
            }
        }

        // đóng kết nối

        public void disconnect()

        {

            if ((conmyconnection != null) && (conmyconnection.State == ConnectionState.Open))

                conmyconnection.Close();

        }
        public void ExcuteNonQuery(string sql)
        {
            if (conmyconnection.State == ConnectionState.Closed)
                conmyconnection.Open();
            SqlCommand cmd = new SqlCommand(sql, conmyconnection);
            cmd.ExecuteNonQuery();
            conmyconnection.Close();
        }

        public void ExecuteNonQuery(string sql)

        {

            connect();

            SqlCommand cmd = new SqlCommand(sql, conmyconnection);

            cmd.ExecuteNonQuery();

            disconnect();
        }
    }
}
