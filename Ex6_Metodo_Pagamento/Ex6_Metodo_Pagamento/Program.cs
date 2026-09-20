using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6_Metodo_Pagamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            6-	Faça um algoritmo que leia o valor de um produto
            e determine o valor que deve ser pago, conforme a escolha da forma de pagamento pelo comprador 
            e imprima na tela o valor final do produto a ser pago.
            Utilize os códigos da tabela de condições de pagamento para efetuar o cálculo adequado.

 Tabela de Código de Condições de Pagamento
 
 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto
 2 - À Vista no cartão de crédito, recebe 10% de desconto
 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros
 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%

             
             */

            double preco;
            int escolha , qtd_Parcelas;


            Console.WriteLine("Digite o valor do produto");
            preco=double.Parse(Console.ReadLine());

            Console.WriteLine("Metodos de Pagamento");
            Console.WriteLine("" +
                " 1 - À Vista em Dinheiro ou Pix, recebe 15% de desconto\n" +
                " 2 - À Vista no cartão de crédito, recebe 10% de desconto\n" +
                " 3 - Parcelado no cartão em duas vezes, preço normal do produto sem juros\n" +
                " 4 - Parcelado no cartão em três vezes ou mais, preço normal do produto mais juros de 10%");

            Console.WriteLine("Qual vai ser seu metodo de pagamento?");
            escolha = int.Parse(Console.ReadLine());

            if (escolha == 1)
            {

                Console.WriteLine($"\nPreço do produto:{preco:F2}\n" +
                    $"Desconto: {preco * 0.15:F2}\n" +
                    $"Preço final:{preco - (preco * 0.15)}");

            }


            else if (escolha == 2)
            {
                Console.WriteLine($"\nPreço do produto:{preco:F2}\n" +
                     $"Desconto: {preco * 0.10:F2}\n" +
                     $"Preço final:{preco - (preco * 0.10)}");
            }


            else if (escolha == 3) {

                Console.WriteLine("Quantidade de Parcelas");
                Console.WriteLine($"1- 1x {preco} sem juros\n" +
                                  $"2- 2x {preco/2} sem juros");
                qtd_Parcelas=int.Parse(Console.ReadLine());
                if (qtd_Parcelas == 1)
                {
                    Console.WriteLine($"Quantidade de parcelas: {qtd_Parcelas}");
                    Console.WriteLine($"Valor das parcelas:{preco}");
                    Console.WriteLine($"Preço final: {preco}");

                }
                if (qtd_Parcelas == 2)
                {

                    Console.WriteLine($"Quantidade de parcelas: {qtd_Parcelas}");
                    Console.WriteLine($"Valor das parcelas:{preco/2}");
                    Console.WriteLine($"Preço final: {preco}");

                }
            }
            else
            {
                Console.WriteLine("Quantidade de Parcelas");
                Console.WriteLine($"3- 3x {(preco+(preco*0.10))/3:F2} com juros\n" +
                                  $"4- 4x {(preco + (preco * 0.10)) / 4:F2} com juros\n" +
                                  $"5- 5x {(preco + (preco * 0.10)) / 5:F2} com juros\n" +
                                  $"6- 6x {(preco + (preco * 0.10)) / 6:F2} com juros\n" +
                                  $"7- 7x {(preco + (preco * 0.10)) / 7:F2} com juros\n" +
                                  $"8- 8x {(preco + (preco * 0.10)) / 8:F2} com juros\n" +
                                  $"9- 9x {(preco + (preco * 0.10)) / 9:F2} com juros\n" +
                                  $"10- 10x {(preco + (preco * 0.10)) / 10:F2} com juros\n");



                qtd_Parcelas = int.Parse(Console.ReadLine());
                

                    Console.WriteLine($"Quantidade de parcelas: {qtd_Parcelas}");
                    Console.WriteLine($"Valor do Juros:{preco * 0.10:F2}");
                    Console.WriteLine($"Valor das parcelas:{(preco+(preco*0.10))/qtd_Parcelas:F2}");
                    Console.WriteLine($"Preço final: {preco+(preco*0.10)}");

                
            }



        }
    }
}
