using static System.Console;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            fila.Enqueue("Gilson");
            fila.Enqueue("Amanda");
            fila.Enqueue("Tio Patinhas");
            fila.Enqueue("Tony Stark");

            WriteLine($"A fila tem {fila.Count} itens.");

            WriteLine($"O item {fila.Dequeue()} foi retirado.");

            ReadKey();
        }
    }
}
