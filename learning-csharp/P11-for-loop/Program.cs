using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P11_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 11 - laço de repetição for:");

            double valorInvestido = 1000;

            for(int count = 1; count <= 12; count++)
            {
                valorInvestido = valorInvestido * 1.0036;
                Console.WriteLine("O retorno no mês " + count + " foi de " + valorInvestido);
            }


            Console.WriteLine("Digite enter para sair da tela:");
            Console.ReadLine();

        }
    }
}
