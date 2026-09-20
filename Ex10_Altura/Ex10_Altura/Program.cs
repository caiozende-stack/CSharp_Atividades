using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Altura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Francisco tem 1,50m e cresce 2 centímetros por ano, enquanto Sara tem 1,10m e cresce 3 centímetros por ano. 
             Faça um algoritmo que calcule e imprima na tela em quantos anos serão necessários para que Francisco seja maior que Sara.
             */

            double francisco = 1.50;
            double sara = 1.10;
            int anos=0;

            while (sara < francisco)
            {
                sara += 0.03;
                francisco += 0.02;
                anos++;
            }

            Console.WriteLine($"Sara passou francisco com {anos}");

        }
    }
}
