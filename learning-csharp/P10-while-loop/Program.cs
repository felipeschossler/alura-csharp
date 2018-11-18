using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P10_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando projeto 10 - laço de repetição while:");

            int count = 1;
            double valorInvestido = 1000;

            while (count <= 12)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("O retorno no mês " + count + " foi de " + valorInvestido);
                count++;
            }

            Console.WriteLine("Digite enter para sair da tela:");
            Console.ReadLine();
        }
    }
}
