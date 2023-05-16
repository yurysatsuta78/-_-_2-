using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kurs
{
    internal class Database
    {
        static string connection = "Data Source=WIN-6HSKC983R9J;Initial Catalog=Sacuta-kurs;Integrated Security=True";
        SqlConnection cn = new SqlConnection(connection);
        public void openConnection() 
        {
            if (cn.State == System.Data.ConnectionState.Closed)
            {
                cn.Open();
            }
        }
        public void closeConnection()
        {
            if (cn.State == System.Data.ConnectionState.Open) 
            {
                cn.Close();
            }
        }
        public SqlConnection getConnection() 
        {
            return cn;
        }
    }
}
