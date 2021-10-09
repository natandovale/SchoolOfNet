using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[] { "Natan", "Bruce Wayne" };

            for(int i = 0; i < nomes.Length; i++)
            {
                WriteLine($"Olá {nomes[i]}");
            }
        }
    }
}
