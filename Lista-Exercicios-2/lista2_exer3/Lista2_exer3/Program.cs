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

           //Declaração de variável

            int valorbase = 0;
            int valorexpoente = 0;
            int valorretorno = 0;

            // Entrada de dados
            Console.WriteLine("Digite a base");
            valorbase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o expoente");
            valorexpoente = Convert.ToInt32(Console.ReadLine());

            //Processamento dos dados
            valorbase = valorexpoente;
            for (int i = 1; i < valorexpoente; i++);
            {
                valorretorno = valorbase * valorexpoente;
            }
                Console.WriteLine("o valor retorno");
                Console.WriteLine(valorretorno);
                Console.Read();

        }
    }
}
