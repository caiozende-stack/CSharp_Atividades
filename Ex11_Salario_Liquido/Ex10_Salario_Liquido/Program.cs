using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_Salario_Liquido
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Faça um algoritmo que efetue o cálculo do salário líquido de um professor.
             As informações fornecidas serão: valor da hora aula, número de aulas lecionadas no mês e percentual de desconto do INSS. 
             Imprima na tela o salário líquido final.
             */

            double valor_h_aula;
            int num_aulas;
            double perc_desconto_inss;
            double salario_liquido;

            Console.WriteLine("Informe o valor da hora aula");
            valor_h_aula = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero de aulas no mes");
            num_aulas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe quantos porcento é o desconto do INSS");
            perc_desconto_inss = double.Parse(Console.ReadLine());
            perc_desconto_inss = perc_desconto_inss / 100;// transformar um valor em porcentagem em decimal
            // salario liquido vai ser o valor total (valor da hora * numero de aulas)- o desconto( (valor da hora*numero aulas) *porcentagem de desconto)
            salario_liquido = (valor_h_aula * num_aulas)-((valor_h_aula*num_aulas)*perc_desconto_inss);
            Console.WriteLine($"Salario Liquido:{salario_liquido}");

        }
    }
}
