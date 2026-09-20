using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex8_Tempo_Vida
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             Faça um algoritmo que leia o ano em que uma pessoa nasceu, imprima na tela quantos anos, meses e dias essa pessoa ja viveu. 
            Leve em consideração o ano com 365 dias e o mês com 30 dias.
             (Ex: 5 anos, 2 meses e 15 dias de vida)
             */




            int ano_nascimento,dia_nascimento,mes_nascimento;

            //pegar a data atual
            int ano_atual=DateTime.Now.Year, mes_atual=DateTime.Now.Month, dia_atual=DateTime.Now.Day;

            //ler a data de nascimento
            Console.WriteLine("Em que Dia Voce nasceu");
            dia_nascimento=int.Parse(Console.ReadLine());
            Console.WriteLine("Em que mes Voce nasceu");
            mes_nascimento =int.Parse(Console.ReadLine());
            Console.WriteLine("Em que ano Voce nasceu");
            ano_nascimento = int.Parse(Console.ReadLine());

            //descobrir quantos dias viveu e quantos dias tem ate hoje
            int totalDiaNasc = (ano_nascimento * 365) + (mes_nascimento * 30) + dia_nascimento;
            int totalDiaAtual= (ano_atual * 365) + (mes_atual * 30) + dia_atual;

            //Descobrir o Total de dias Vividos
            int totalDiasVividos = totalDiaAtual - totalDiaNasc;

            //descobrir quantos anos viveu
            int anosVividos = totalDiasVividos / 365;

            //descobrir os meses
            int restoDias = totalDiasVividos % 365;// vai separar o resto de dias que restaram depois de descobrir os anos inteiros
            int mesVividos = restoDias / 30; //vai separar quantos meses viveu depois de ter começado o ultimo ano vivido
            int diasVividos = restoDias % 30;// vai determinar quantos dias viveu depois que completou o ultimo mes

            Console.WriteLine($"Voce viveu por {anosVividos} anos, {mesVividos} meses e  {diasVividos} dias");
            



        }
    }
}
