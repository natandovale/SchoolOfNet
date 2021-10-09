using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            foreach (var item in diasSemanas)
            {
                WriteLine($"Dia => {item}");
            }
        }
    }
}
