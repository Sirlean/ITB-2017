using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_02_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string nome = null;
            int idade = 0;

            //mensagens para usuário(saída de dados)
            Console.WriteLine("Digite seu nome");

            //Armazenar o dado em uma variável(Entrada de dados)
            nome = Console.ReadLine();

            //mensagens para usuário
            Console.WriteLine("Digite sua idade");

            /* Armazenar o dado em uma variável de tipo diferente
             Necessário converter os dados*/
            idade = Convert.ToInt32(Console.ReadLine());

            //Processamento
         
            //Testar se é possível classificar
            if(idade >=5)
            {
            //Possível
           if (idade <=8 )
            {
             Console.WriteLine("categaria infantil");
            }
             else
             {
             if (idade <=13)
             {
              Console.WriteLine("categaria infantil B");
             }
             else
             {
              if(idade <=17)
               {
                Console.WriteLine("categaria Juvenil");
               }
              else
                {

                 }
                 Console.WriteLine("categaria Profissional");

                    }

                  }

         

            }
            //saída de dados
            Console.WriteLine("nome do atleta" + nome);
            Console.WriteLine("Digite algo para sair");
            Console.ReadKey();



        }
    }
}
