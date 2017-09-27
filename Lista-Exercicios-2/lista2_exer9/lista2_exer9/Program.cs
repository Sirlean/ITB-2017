using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore uma aplicação que receba quatro números inteiros
            //e apresentar os números que são divisíveis por 2 ou 3.

            //Declaração de variável
            int n1 = 0, n2 = 0, n3 = 0, n4 = 0;
            int Divisor2 = 2;
            int Divisor3 = 3;
            int resto2 = 0, resto3 = 0;
            string numerosDivisiveisPor2ou3 = "";


            //Entrada de dados
            Console.WriteLine("Digite quatro números");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());

            //Execucao
            resto2 = n1 % Divisor2;
            resto3 = n1 % Divisor3;
            if (resto2 == 0 || resto3 == 0)
            {
                numerosDivisiveisPor2ou3 = numerosDivisiveisPor2ou3 + " " + n1;
            }

            if ((n2 % Divisor2) == 0 || (n2 % Divisor3) == 0)
            {
                numerosDivisiveisPor2ou3 = numerosDivisiveisPor2ou3 + " " + n2;
            }
            if ((n3 % Divisor2) == 0 || (n3 % Divisor3) == 0)
            {
                numerosDivisiveisPor2ou3 = numerosDivisiveisPor2ou3 + " " + n3;
            }
            if ((n4 % Divisor2) == 0 || (n4 % Divisor3) == 0)
            {
                numerosDivisiveisPor2ou3 = numerosDivisiveisPor2ou3 + " " + n4;
            }

            //Saida
            Console.WriteLine("Os números divisíveis por 2 ou 3 são " + numerosDivisiveisPor2ou3);
            Console.ReadLine();            

            //string numerosDivisiveisPor2 = "";
            //string numerosDivisiveisPor3 = "";

            //resto = n1 % Divisor2;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor2 = numerosDivisiveisPor2 + " " + n1;
            //}

            //resto = n2 % Divisor2;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor2 = numerosDivisiveisPor2 + " " + n2;
            //}

            //resto = n3 % Divisor2;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor2 = numerosDivisiveisPor2 + " " + n3;
            //}

            //resto = n4 % Divisor2;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor2 = numerosDivisiveisPor2 + " " + n4;
            //}

            //resto = n1 % Divisor3;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor3 = numerosDivisiveisPor3 + " " + n1;
            //}

            //resto = n2 % Divisor3;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor3 = numerosDivisiveisPor3 + " " + n2;
            //}

            //resto = n3 % Divisor3;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor3 = numerosDivisiveisPor3 + " " + n3;
            //}

            //resto = n4 % Divisor3;

            //if (resto == 0)
            //{
            //    numerosDivisiveisPor3 = numerosDivisiveisPor3 + " " + n4;
            //}


            //Console.WriteLine("numeros divisiveis por 2 são " + numerosDivisiveisPor2);
            //Console.WriteLine("numeros divisiveis por 3 são " + numerosDivisiveisPor3);


            //Console.ReadLine();

        }
    }
}
