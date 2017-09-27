using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer5
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Elabore uma aplicação que receba um número inteiro e indique se o número é divisível por 5. 
          
            //Declaração de variável
            int N1 = 0;
            int Divisor = 5;
            int Resto = 0;

            //Entrada do Dividendo 
            Console.WriteLine("digite o valor");
            N1 = Convert.ToInt32(Console.ReadLine());

            Resto = N1 % Divisor;

            if (Resto == 0)
            {
                Console.WriteLine("o valor é divisivél por 5");
            }
            else
            {
                Console.WriteLine("errado");
            }
            Console.ReadLine();
            
        }

    }
}

