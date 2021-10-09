using static System.Console;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=DESKTOP-K7BEBRC\\SQLEXPRESS;Database=CSharpAdoNet;Trusted_Connection = True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "select * from clientes order by id";

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                WriteLine("ID: {0}", dr["id"]);
                WriteLine("Nome: {0}", dr["nome"]);
                WriteLine("E-mail: {0}", dr["email"]);
                WriteLine("----------------------");
            }
            conn.Close();

           ReadLine();
        }
    }
}
