using static System.Console;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[3];
            x[0] = 5;
            x[1] = 10;
            x[2] = 15;

            string[] nomes = new string[2];
            nomes[0] = "Gilson";
            nomes[1] = "Tio Patinhas";

            string[] diasSemanas = new string[] { "Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sab" };

            WriteLine(x[0]);
            WriteLine(nomes[1]);
            WriteLine(diasSemanas[3]);
            ReadKey();
        }
    }
}
