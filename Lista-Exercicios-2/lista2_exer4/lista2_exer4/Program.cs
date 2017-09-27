using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2_exer4
{
    class Program
    {
        static void Main(string[] args)
        {
           //Declaração de Variável
            int somatorio = 0, totalpares = 0, i = 0;
            double media;

            
           //Processamento,Contar de 50 a 70
            for(i=50;i<=70; i++)
            {
           //Verificar se é par
                if(i%2==0)
                {
           //console.WriteLine(i);
                    somatorio = somatorio + i;
           //totalpares++
                    totalpares = totalpares + 1;
                }
            }
            media = somatorio / totalpares;
            Console.WriteLine("total:" + somatorio);
            //Console.WriteLine("total de pares:"+totalpares);
            Console.WriteLine("Média de nº pares:" + media);

            Console.WriteLine("Digite algo para sair...");
            Console.ReadKey();


        }
    }
}
