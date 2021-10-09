using static System.Console;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> p1 = new Stack<int>();
            p1.Push(1);
            p1.Push(2);
            p1.Push(3);
            p1.Push(4);
            p1.Push(5);
            p1.Push(6);

            WriteLine($"A pilha tem {p1.Count} itens.");
            //WriteLine(p1.ToArray().GetValue(3));
            
            //Retira e retorna o elemento da fila
            p1.Pop();
            //Apenas Retorna o elemento da fila
            WriteLine(p1.Peek());

            WriteLine($"A pilha tem {p1.Count} itens.");

            p1.Clear();
            WriteLine($"A pilha tem {p1.Count} itens.");

            ReadKey();
        }
    }
}
