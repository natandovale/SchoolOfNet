using static System.Console;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ListarCliente();
            ReadLine();
        }

        static void ListarCliente()
        {
            string connString = getStringConn();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select * from clientes order by id";

                using(SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        WriteLine("ID: {0}", dr["id"]);
                        WriteLine("Nome: {0}", dr["nome"]);
                        WriteLine("------------------------");
                    }
                }

            }
        }

        static string getStringConn()
        {
            string connString = "Server=DESKTOP-K7BEBRC\\SQLEXPRESS;Database=CSharpAdoNet;Trusted_Connection = True";
            return connString;
        }
    }
}




