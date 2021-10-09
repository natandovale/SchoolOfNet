using static System.Console;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = "Server=DESKTOP-K7BEBRC\\SQLEXPRESS;Database=CSharpAdoNet;User Id=sa;Password=20101914nm";
            SqlConnection conn = new SqlConnection(connString);

            WriteLine(conn);
        }
    }
}
