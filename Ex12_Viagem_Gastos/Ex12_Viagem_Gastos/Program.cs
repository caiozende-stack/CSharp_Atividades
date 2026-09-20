using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_Viagem_Gastos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo que calcule a quantidade de litros de combustível gastos em uma viagem,
            sabendo que o carro faz 12km com um litro. 
            Deve-se fornecer ao usuário o tempo que será gasto na viagem a sua velocidade média, 
            distância percorrida e a quantidade de litros utilizados para fazer a viagem.

            Fórmula: distância = tempo x velocidade.
            litros usados = distância / 12.
             */
            double combustivel;
            double consumo = 12; // 12 km por litro
            double velocidade_media, distancia, tempo;

            Console.WriteLine("Informe o tempo de viagem em horas");
            tempo=double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a velocidade média");
            velocidade_media = double.Parse(Console.ReadLine());

            distancia = tempo * velocidade_media;
            combustivel = distancia / 12;

            Console.WriteLine($"Nessa viagem voce irá gastar {combustivel:F2} litros de combustível");



        }
    }
}
