using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_creating_double_variables
{
    class Program
    {
        static void Main(string[] args)
        {

            double idade;

            idade = 5 / 3;
            Console.WriteLine("5 / 3 = " + idade);

            idade = 5.0 / 3;
            Console.WriteLine("5.0 / 3 = " + idade);

            Console.WriteLine("Execução finalizada, tecle enter para sair...");
            Console.ReadLine();
        }
    }
}
