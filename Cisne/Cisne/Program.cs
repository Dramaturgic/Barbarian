using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio 1 : Soma ");
            Console.ReadLine();

            Console.Clear();


            // Exercicio 1 // 

            Console.WriteLine("Insira seu numero aqui: ");
            string inputsm = Console.ReadLine();

            Console.WriteLine("Insira outro número aqui: ");
            string inputsm_2 = Console.ReadLine();

            int input_1 = int.Parse(inputsm);
            int input_2 = int.Parse(inputsm_2);

            int soma = input_1 + input_2;

            Console.WriteLine($"A soma desses numeros é:\n{soma} :)");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Exercicio 2 : Terceira parte de número reais");
            Console.ReadLine();

            Console.Clear();



            // Exercicio 2 // 


            Console.WriteLine("Insira Um Número que será dividido em 3");
            string input3r = Console.ReadLine();

            double convinput = double.Parse(input3r);

            double div = convinput / 3;

            Console.WriteLine($"A terceira parte do numero será:\n{div}");
            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Exercicio 3 : Média Aritmetica de Reais");
            Console.ReadLine();

            Console.Clear();


            // Exercicio 3 // 

            Console.WriteLine("Insira o Primeiro número da Media:");
            string inputm_1 = Console.ReadLine();

            Console.WriteLine("Agora Insira o segundo numero da media aritmetica:");
            string inputm_2 = Console.ReadLine();

            double t_i = double.Parse(inputm_1);
            double t_i1 = double.Parse(inputm_2);

            double md_a = (t_i + t_i1) / 2;

            Console.WriteLine($"A média desses 2 é \n{md_a} ");
            Console.ReadLine();

            Console.Clear();

            //Exercicio 4 //

            Console.WriteLine("Exercicio 4 : Fazer um programa que possa entrar com o saldo de uma aplicação e imprima o novo saldo, considerando o reajuste de 1% no saldo. ");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Insira o Saldo que deseja inserir :");
            string inputsal = Console.ReadLine();

            double inputsl = double.Parse(inputsal);

            double calsal = inputsl * 1.01;

            Console.WriteLine($"O saldo com reajuste seria\n{calsal} \nConfirmar?\nPara confirmar aperte enter");
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Obrigado por utilizar nosso programa :)");
            Console.ReadLine();


            Console.Clear();

            // Exercicio 5 //

            Console.WriteLine("Exercicio 5 : Entrar com as notas da NOTA_PROVA1, NOTA_PROVA2, NOTA_PROVA3 e NOTA_PROVA4 e imprimir a média final.");
            Console.ReadLine();

            Console.Clear();


            Console.WriteLine("Bom comecemos, digite a primeira nota:");
            string nta_prova1 = Console.ReadLine();

            Console.WriteLine("Agora a Segunda:");
            string nta_prova2 = Console.ReadLine();

            Console.WriteLine("Agora a terceira:\nVamos estamos quase lá ");
            string nta_prova3 = Console.ReadLine();

            Console.WriteLine("Agora finalmente a quarta:");
            string nta_prova4 = Console.ReadLine();

            double nota1 = double.Parse(nta_prova1);
            double nota2 = double.Parse(nta_prova2);
            double nota3 = double.Parse(nta_prova3);
            double nota4 = double.Parse(nta_prova4);

            double md_nota = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine($"A média dessas notas é: \n{md_nota}");
            Console.ReadLine();
        }
    }
}
