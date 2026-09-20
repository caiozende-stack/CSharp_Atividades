using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7_Troca_valores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo que receba um valor A e B, e troque o valor de A por B e o valor de B por A e imprima na tela os valores.
             */
            double a, b, c;

            Console.WriteLine("Informe o valor de A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o valor de B");
            b = double.Parse(Console.ReadLine());

            c = a;
            a = b;
            b = c;
            Console.WriteLine($"Valor novo de A é {a} e o valor novo de B é {b}");


        }
    }
}
