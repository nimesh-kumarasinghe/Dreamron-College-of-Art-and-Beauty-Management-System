using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dreamron_College
{
    class Database
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        SqlDataReader dreader;

        public Database()
        {
            con = new SqlConnection(""); //put your database string
            con.Open(); 
        }

        public SqlCommand command(string command)
        {
            cmd = new SqlCommand(command, con);
            System.Console.WriteLine(command);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            return cmd;
        }
        public SqlDataAdapter Adapter(string command)
        {
            adpt = new SqlDataAdapter(command, con);
            return adpt;
        }
        public SqlDataReader dataReader(string command)
        {
            cmd = new SqlCommand(command, con);
            SqlDataReader da= cmd.ExecuteReader();
            cmd.Dispose();
            return da;
        }
        public String dataScalar(string command)
        {
            cmd = new SqlCommand(command, con);
            var data = cmd.ExecuteScalar() as String;
            cmd.Dispose();
            return data;
        }
        SqlDataAdapter da;
        public DataTable getDatatable(String command)
        {
            da = new SqlDataAdapter(command, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }
    }
}
