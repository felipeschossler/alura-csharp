using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_conversion_and_other_types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4:");

            double salario;
            salario = 1200.50;

            int salarioInt;
            salarioInt = (int)salario;

            Console.WriteLine("Valor salario: " + salarioInt);

            long universeYearsOld = 13000000000;

            short smallNumber = 17500;

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
