using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer6
{
    class Program
    {
        static void Main(string[] args)
        {
            //decalração de uma variável
            int n1 = 0;

            Console.WriteLine("entre com primeiro valor");

            while (true)
            { 

            n1 = Convert.ToInt32(Console.ReadLine());

            if (n1 == 1)
            {
                Console.WriteLine("um");
            }
            else if (n1 == 2)
            {
                Console.WriteLine("dois");
            }
            else if (n1 == 3)
            {
                Console.WriteLine("Três");
            }
            else if (n1 == 4)
            {
                Console.WriteLine("Quatro");
            }
            else if (n1 == 5)
            {
                Console.WriteLine("Cinco");
            }
            else if (n1 == 6)
            {
                Console.WriteLine("seis");
            }
            else if (n1 == 7)
            {
                Console.WriteLine("sete");
            }
            else if (n1 == 8)
            {
                Console.WriteLine("oito");
            }
            else if (n1 == 9)
            {
                Console.WriteLine("nove");
            }
            else if (n1 == 10)
            {
                Console.WriteLine("dez");
            }
            else
            {
                Console.WriteLine("fora da faixa");
            }
        }
        }
    }
}
