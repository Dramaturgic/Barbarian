using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aguia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1

            Console.WriteLine("Atividade 1 : Tabuada ");
            Console.ReadLine();

            Console.Clear();

            int nm_tb = 0;

            Console.WriteLine("Digite o Número que deseja fazer a tabuada:");
            nm_tb = int.Parse(Console.ReadLine());

            Console.WriteLine("Tabuada do {0}",nm_tb);
            Console.WriteLine("1 x {0}, é {1}",nm_tb, nm_tb * 1);
            Console.WriteLine("2 x {0}, é {1}",nm_tb, nm_tb * 2);
            Console.WriteLine("3 x {0}, é {1}",nm_tb, nm_tb * 3);
            Console.WriteLine("4 x {0}, é {1}",nm_tb, nm_tb * 4);
            Console.WriteLine("5 x {0}, é {1}",nm_tb, nm_tb * 5);
            Console.WriteLine("6 x {0}, é {1}",nm_tb, nm_tb * 6);
            Console.WriteLine("7 x {0}, é {1}",nm_tb, nm_tb * 7);
            Console.WriteLine("8 x {0}, é {1}",nm_tb, nm_tb * 8);
            Console.WriteLine("9 x {0}, é {1}",nm_tb, nm_tb * 9);
            Console.WriteLine("10 x {0}, é {1}",nm_tb, nm_tb * 10);
            Console.ReadLine() ;

            Console.Clear();
            #endregion
            
            #region Atividade 2
            
            Console.WriteLine("Atividade 2 : Valor de Lauda ");
            Console.ReadLine();

            Console.Clear();

            double ld_0 = 0;

            Console.WriteLine("Insira sua quantidade de laudas:");
            ld_0 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Sua quantidade de laudas original é {0}", ld_0);
            Console.WriteLine("O preço total é {0:c}",ld_0 * 50);
            Console.WriteLine("A quantidade de parcelas iguais de 3 partes será {0:c}", (ld_0 * 50) / 3);

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Atividade 3

            Console.WriteLine("Atividade 3 : Imprima seu nome na primeira linha, na segunda linha imprima uma mensagem de boas-vindas e na terceira imprima “Tecle ENTER para finalizar”  ");
            Console.ReadLine();

            Console.Clear();

            string nm = "";
            string msg = "Bem-vindo(a) ao nosso espaço acolhedor!, é com grande alegria que recebemos você aqui.";

            Console.WriteLine("Digite seu LINDISSIMO nome:");

            nm = Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Olá {0}\n{1}", nm, msg);
            Console.WriteLine("Tecle enter para continuar");
            Console.ReadLine();
            Console.Clear();
            #endregion

        }
    }
}
