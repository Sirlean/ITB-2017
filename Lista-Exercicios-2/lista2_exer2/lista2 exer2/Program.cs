using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore uma aplicação que mostre o resultado das potencias de 3, variando de 0 a 20. 

            //Declaração de variável
            int @base = 0;
         
            Console.WriteLine("Digite o valor da base.");
            @base = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 20; i++)
            {
                double potencia = Math.Pow(@base, i);
                Console.WriteLine("O resultado de {0} ^ {1} = {2}", @base, i, potencia);
                double potencia2 = Math.Pow(i, @base);
                Console.WriteLine("O resultado de {0} ^ {1} = {2}", i, @base, potencia2);
                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();
        }
    }
}
