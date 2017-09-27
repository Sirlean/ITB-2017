using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elabore uma aplicação que receba um número inteiro
            //e indique se o número é par ou ímpar.

            //Declaração de variável

            int npar = 0;
            int divisor = 2;
            int resto = 0;

            // Entrada de Dados

            while (true)
            {


                Console.WriteLine("Digite um número");
                npar = Convert.ToInt32(Console.ReadLine());

                resto = npar % divisor;

                if (resto == 0)
                {
                    Console.WriteLine("Número par");
                }
                else
                {
                    Console.WriteLine("Número Impar");
                }

            }

        }


    }
}
