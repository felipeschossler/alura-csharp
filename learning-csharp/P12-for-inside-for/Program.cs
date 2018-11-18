using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P12_for_inside_for
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Executando projeto 12 - laço de repetição for dentro de outro for:");

            double valorInvestido = 1000;
            double fatorRendimento = 1.0036;

            for(int contAno = 1; contAno <=5; contAno++)
            {
                for(int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;
                }
                fatorRendimento += 0.0010;
            }

            Console.WriteLine("Ao término do praz do investimento o valor total é de: R$" +valorInvestido);


            Console.WriteLine("Digite enter para sair da tela:");
            Console.ReadLine();

        }
    }
}
