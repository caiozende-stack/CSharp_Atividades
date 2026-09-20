using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex9_Converter_temp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo que leia uma temperatura em Fahrenheit e calcule a temperatura correspondente em grau Celsius.
             Imprima na tela as duas temperaturas.
             Fórmula: C = (5 * ( F-32) / 9)
             */
            double f, c;
            Console.WriteLine("Digite a temperatura em Fahrenheit ( 0 °F a 100 °F)");
            f=double.Parse(Console.ReadLine());
            c = 5 * (f - 32) / 9;
            Console.WriteLine($"Fahrenheit : {f}°F ");
            Console.WriteLine($"Celsius : {c}ºC");
        }
    }
}
