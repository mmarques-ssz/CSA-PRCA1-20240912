using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace projFuncoes
{
    internal class Program
    {

        static int geral; // EXEMPLO DE DECLARAÇÃO DE VARIÁVEL GLOBAL 
                          // QUE DEVE SER EVITADO
        static void Main(string[] args)
        {
            string nome;
            string fone;
            int idade;
            geral = 111;

            Console.WriteLine("Estou na parte principal do programa");
            nome = entra("Digite seu nome: ", 10, 5);
            fone = entra("Digite seu telefone: ", 10, 9);
            idade = int.Parse(entra("Digite sua idade: ", 10, 13));
            Console.WriteLine("Nome: {0}, Fone: {1}, Idade: {2}", 
                nome, fone, idade);
            tracinhos(40);

            Console.WriteLine("Resultado: {0}", 
                   soma(
                   int.Parse(entra("Entre com um numero inteiro: ", 10, 20)),
                   int.Parse(entra("Entre com outro numero inteiro: ", 10, 30))
                   )
                );
            tracinhos(40);
        }

        static string entra(string msg, int col, int lin)
        {
            string s;
            Console.SetCursorPosition(col, lin);
            Console.Write(msg);
            s = Console.ReadLine();
            return s;
        }

        static int soma(int x, int y)
        {
            return x + y;
        }

        static void tracinhos(int qtde)
        {
            Console.WriteLine(geral);
            int i;
            for (i = 1; i <= qtde; ++i)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

    }
}
