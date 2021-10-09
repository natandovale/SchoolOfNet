using System;
using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario = 0;
            double gastosMensais = 0;
            bool temDecimoTerceiro = false;

            Write("Informe seu salario: ");
            salario = double.Parse(ReadLine());

            Write("Informe seu gasto mensal: ");
            gastosMensais = double.Parse(ReadLine());

            Write("Tem décimo terceiro?: true ou false: ");
            Boolean.TryParse(ReadLine(), out temDecimoTerceiro);

            if (temDecimoTerceiro)
            {
                salario += salario;
            }

            if(gastosMensais > salario)
            {
                WriteLine("Precisa economizar:");
            }else if (gastosMensais == salario)
            {
                WriteLine("Precisa melhorar");
            }
            else
            {
                WriteLine("Boa!!");
            }

            ReadKey();
        }
    }
}
