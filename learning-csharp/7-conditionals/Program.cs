using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 7 - Condicionais");

            int idadeJoao = 16;
            int quantPessoas = 2;

            if (idadeJoao > 18)
            {
                Console.WriteLine("João possui mais de 18 anos de idade.");
            }
            else
            {
                if (quantPessoas == 2)
                {
                    Console.WriteLine("João está acompanhado, pode entrar.");
                }
                else
                {
                    Console.WriteLine("João possui menos de 18 anos de idade e não está acompanhado.");
                }
            }
           
            Console.WriteLine("Pressione Enter para sair da tela...");
            Console.ReadLine();
        }
    }
}
