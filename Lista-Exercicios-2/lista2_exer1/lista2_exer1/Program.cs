using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer1
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Elabore uma aplicação que receba dois valores quaisquer 
            //e em seguida realizar a subtração do maior número pelo menor número. 
            
            //Declaração de variáveis
            double N1 = 0;
            double N2 = 0;
            double resultado = 0;

            // Receber valor N1
            Console.WriteLine("entre com primeiro valor");
            N1 = Convert.ToDouble(Console.ReadLine());

            // Receber Valor N2
            Console.WriteLine("entre com o segundo valor");
            N2 = Convert.ToDouble(Console.ReadLine());

            if (N1 > N2)
            {
                resultado = N1 - N2;
            }
            else
            {
                resultado = N2 - N1;
            }
            Console.WriteLine("resultado final " + resultado);
            Console.ReadLine();
        }
    }
}
