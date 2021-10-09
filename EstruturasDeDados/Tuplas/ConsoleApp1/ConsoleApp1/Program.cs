using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //(string, string, double) brasil = ("Brasil", "Brasilia", 1269.33);
            //Write($"O {brasil.Item1}, cuja capital é {brasil.Item2}, tem a rpc de {brasil.Item3}");

            (string nome, string tipoGoverno, int populacao, string capital, double rpc) brasil = ("Brasil", "Presidencialismo", 200, "Brasilia", 1239.32);
            Write($"O {brasil.nome}, cuja capital é {brasil.capital} tem a rpc de R$ {brasil.rpc}");

            ReadKey();
        }
    }
}
