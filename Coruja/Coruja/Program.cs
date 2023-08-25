using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1

            Console.WriteLine("Atividade 1 : Sucessor e Antecessor");
            Console.ReadLine();

            Console.Clear();

            int num_atv1 = 0;

            Console.WriteLine("Insira um número para encontrar o sucessor e antecessor: ");
            num_atv1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("O sucessor do número {0}, é {1} e o antecessor é {2}", num_atv1, num_atv1 + 1, num_atv1 - 1);
            Console.ReadLine();
            Console.Clear();

            #endregion


            #region Atividade 2

            Console.WriteLine("Atividade 2 : Ler nome, endereço e telefone e mostrar na ordem de entrada com os rotulos");
            Console.ReadLine();

            Console.WriteLine("Insira seu nome aqui: ");
            string nm = Console.ReadLine();

            Console.WriteLine("Insira seu endereço aqui: ");
            string address = Console.ReadLine();

            Console.WriteLine("Insira seu telefone aqui: ");
            string ph = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Seu nome é {0}", nm);
            Console.WriteLine("Seu endereço é {0}", address);
            Console.WriteLine("Seu telefone é {0}", ph);
            Console.ReadLine();

            Console.Clear();
            #endregion


            #region Atividade 3
            Console.WriteLine("Atividade 2 : Ler dois números inteiros e mostrar a soma, a subtração e a multiplicação.");
            Console.ReadLine();
            Console.Clear();
            int nm_at3 = 0;
            int nm_at3_1 = 0;
            
            Console.WriteLine("Digite o Primeiro número");
            nm_at3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo número");
            nm_at3_1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("A soma será feita é: {0}", nm_at3 + nm_at3_1);
            Console.ReadLine();
            Console.WriteLine("A multiplicação será: {0}", nm_at3 * nm_at3_1);
            Console.ReadLine();
            Console.WriteLine("A substração será: {0}",nm_at3 - nm_at3_1);
            Console.ReadLine();

            Console.Clear() ;
            #endregion

            #region Atividade 4
            
            Console.WriteLine("Atividade 4 : IMC");
            Console.ReadLine();
            Console.Clear();

            double al = 0;
            double ps = 0;

            Console.WriteLine("Digite sua altura:");
            al = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite seu peso:");
            ps = double.Parse(Console.ReadLine());

            Console.WriteLine("O seu imc será: {0}", ps / Math.Pow(al, 2));
            Console.ReadLine();
            Console.Clear();

            #endregion
        }
    }
}
