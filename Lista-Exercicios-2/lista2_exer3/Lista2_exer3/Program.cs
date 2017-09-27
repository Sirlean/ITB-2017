using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista2_exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elabore uma aplicação web que receba os valores da base e do expoente de uma potência e em
            //seguida execute o cálculo desta potência (obs.faça o cálculo usando laços de repetição e desvio
            //condicionais). 
            int valorBase = 0;
            int valorExpoente = 0;

            Console.WriteLine("Digite da base:");
            valorBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite da expoente:");
            valorExpoente = Convert.ToInt32(Console.ReadLine());

            // 2 ^ 4
            // 2 * 2 * 2 * 2

            int valorRetorno = valorBase;

            for (int i = 1; i < valorExpoente; i++)
            {
                valorRetorno = valorRetorno * valorBase;
            }

            Console.WriteLine("O valor retornado é [{0}]", valorRetorno);

            Console.Read();
        }
    }
}
