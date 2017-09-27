using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_01_2017
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variável do tipo string com valor inicial nulo
            string nome = null;

            //Comando para escrever a mensagem na tela(prompt)
            Console.WriteLine("digite seu nome");
            nome = Console.ReadLine();

            //Armazena na variável o conteúdo digitadi pelo usuário
            Console.WriteLine("Olá Mundo");
            Console.WriteLine("parabéns, " + nome + " você irá aprender a programar!!");

            //Comando para escrever a mensagem na tela (prompt)
            Console.WriteLine("digite a algo para sair");

            //Linha comando para não fechar sozinho, aguardar o usuário  digitar uma tecla
            Console.ReadLine();


        }
    }
}
