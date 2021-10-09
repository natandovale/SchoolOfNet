using static System.Console;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("Informe o saldo do cartão/banco.");
            var eSaldo = double.Parse(ReadLine());

            Write("Informe o valor da compra.");
            var eValor = double.Parse(ReadLine());
            
            Write("Informe o tipo de pagamento (C para credito e D para debito.");
            var eTipo = char.Parse(ReadLine());

            (double saldo, double compra, char tipo) pagamento = (eSaldo, eValor, eTipo);

            switch (pagamento.tipo)
            {
                case 'C' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de crédito não aprovado!");
                    break;
                case 'D' when pagamento.compra > pagamento.saldo:
                    WriteLine("Compra com cartão de débito não aprovado!");
                    break;
                default:
                    WriteLine("Compra aprovada");
                    break;
            }
        }
    }
}
