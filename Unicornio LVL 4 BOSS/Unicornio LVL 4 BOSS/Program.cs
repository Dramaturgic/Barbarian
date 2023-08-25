using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unicornio LVL 4 BOSS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("BOSS FINAL: UNICORNIO");
            Console.ReadLine();

            Console.Clear();

            string nomeCompleto = "";

            Console.WriteLine("Digite seu nome completo:");

            nomeCompleto = Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Todo o nome: {0}", nomeCompleto);
            Console.WriteLine("Primeiro caractere: {0}", nomeCompleto[0]);
            Console.WriteLine("Último caractere: {0}", nomeCompleto[nomeCompleto.Length - 1]);
            Console.WriteLine("Do Primeiro até o Terceiro: {0}", nomeCompleto.Substring(0, 3));
            Console.WriteLine("Quarto caractere: {0}", nomeCompleto[3]);
            Console.WriteLine("Todos menos o Primeiro: {0}", nomeCompleto.Substring(1));
            Console.WriteLine("Os Dois Últimos: {0}", nomeCompleto.Substring(nomeCompleto.Length - 2));

            Console.ReadLine() ;
        }
    }
}
