using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula6_exercicios_extra_preparacao_ficha
{
    internal class Program
    {
        static double FahrenheitParaCelsius(double fahrenheit)
        {
            double Celsius;
 
            Celsius = (fahrenheit - 32) / 1.8 +5;

            return Celsius;
        }

        static double MaisBaixo(double p1, double p2, double p3)
        {
            double menor = p1;

            if (p2 < menor) menor = p2;
            if (p3 < menor) menor = p3;

            return menor;
        }

        static int MaisVelha(int i1, int i2, int i3)
        {
            int maior = i1;

            if (i2 > maior) maior = i2;
            if (i3 > maior) maior = i3;

            return maior;
        }

        static double preco3ValoresMaisBaixo(double preco1, double preco2, double preco3)
        {
            double menor;

            if (preco1 < preco2 && preco1 < preco3)
            {
                menor = preco1;
            }
            else if (preco2 < preco1 && preco2 < preco3)
            {
                menor = preco2;
            }
            else
            {
                menor = preco3;
            }

            return menor;
        }

        static int As3MaisVelhas(int idade1, int idade2, int idade3)
        {
            int idadeMaisVelha;

            if (idade1 < idade2 && idade1 < idade3)
            {
                //return idade1;
                idadeMaisVelha = idade1;    
            }
            else if (idade2 < idade1 && idade2 < idade3)
            {
                // return idade2;
                idadeMaisVelha = idade2;
            }
            else
            {
                //return idade3;
                idadeMaisVelha = idade3;
            }        

            return idadeMaisVelha;
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Exercícios Preparação para a Ficha de Avaliação

            //Exercícios treino:

            //1.Implemente um programa para calcular o menor de 4 valores.
            //int valor1, valor2, valor3, valor4, menor;

            //Console.WriteLine("Digite o 1º valor: ");
            //valor1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º valor: ");
            //valor2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 3º valor: ");
            //valor3 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 4º valor: ");
            //valor4 = int.Parse(Console.ReadLine());

            //if (valor1 == valor2 && valor1 == valor3 && valor1 == valor4)
            //{
            //    Console.WriteLine("São todos iguais.");
            //}
            //else
            //{

            //    menor = valor1;

            //    if (valor2 < menor)
            //    {
            //        menor = valor2;
            //    }

            //    if (valor3 < menor)
            //    {
            //        menor = valor3;
            //    }

            //    if (valor4 < menor)
            //    {
            //        menor = valor4;
            //    }

            //    Console.WriteLine("O menor valor é o " + menor);
            //}


            //2.Insira o valor da compra de um produto, e mostre o novo valor, tendo em conta um aumento de 6 % de juros.
            //double valor, novoValor;

            //Console.Write("Valor da compra: ");
            //valor = double.Parse(Console.ReadLine());

            //novoValor = valor + (valor * 0.06);
            //novoValor = valor * 1.06;

            //Console.WriteLine("Novo valor com 6% de juros: " + Math.Round(novoValor,2) + " €");

            //3.Ler seis números, e apresente uma mensagem a mencionar quantos números inseridos são negativos.
            //utilize o for e o while.

            //Versão for
            //int negativos = 0;
            //double num;

            ////Pedir a quantidade ao utilizador

            ////for (int i = 1; i <= quantidade; i++)
            //for (int i = 0; i < 6; i++)
            //{
            //    Console.Write("Número " + (i +1)+"º: ");
            //    num = double.Parse(Console.ReadLine());

            //    if (num < 0)
            //    {
            //        negativos++;
            //    }

            //}

            //Console.WriteLine("Foram inseridos " + negativos + " números negativos.");

            // Versão com while
            //int negativos = 0;
            //int contador = 0;
            //double numero;

            //while (contador < 6)
            //{
            //    Console.Write("Número " + (contador + 1) + ": ");
            //    numero = double.Parse(Console.ReadLine());

            //    if (numero < 0)
            //    {
            //        // negativos = negativos + 1;
            //        negativos++;
            //    }

            //    // contador = contador + 1;
            //    contador++;
            //}

            ////do
            ////{

            ////}while(contador < 6);

            //Console.WriteLine("Foram inseridos " + negativos + " números negativos.");


            //4.Fazer a conversão de temperatura na escala Fahrenheit para a escala Celsius.
            // Fórmula: C = (F - 32) / 1.8
            // Utilize um método
            //double fahrenheit, celsius;

            //Console.WriteLine("Temperatura em Fahrenheit: ");
            //fahrenheit = double.Parse(Console.ReadLine());

            //celsius = FahrenheitParaCelsius(fahrenheit);

            //Console.WriteLine(fahrenheit + " ºF = " + Math.Round(celsius, 2) + " ºC");

            //----
            //1. Leia N valores.
            //Depois peça o valor ao utilizador do tipo de dados inteiro 
            // dentro do for e some os valores inseridos.
            //No final mostre a soma de todos os números. (for)

            //int quantidade, valor, somar = 0;

            //Console.WriteLine("Quantidade de valores a verificar: ");
            //quantidade = int.Parse(Console.ReadLine());//3

            ////1 <= 3 
            ////2 <= 3 
            ////3 <= 3 

            //for(int i = 0; i < quantidade; i++)
            //{
            //    Console.WriteLine("Digite o " + (1+i) + "º valor: ");
            //    valor = int.Parse(Console.ReadLine());// 5 10 7

            //    //somar += valor;
            //    somar = somar + valor;
            //}

            //Console.WriteLine("Total da soma dos valores: " + somar);


            // 2. Peça o valor.
            // Mostre todos os números pares entre 0 e o valor digitado. (for)
            // Mostre a quantidade de números pares encontrados.
            //Console.WriteLine("\n--- Exercício 2 (Parte 2) ---");
            //Console.Write("Insira um valor: ");
            //int valor = int.Parse(Console.ReadLine());

            //int quantidade = 0;

            //Console.Write("Números pares: ");
            //for (int i = 0; i <= valor; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.Write(i + " ");
            //        quantidade++;
            //    }
            //}

            //Console.WriteLine($"\nQuantidade de números pares: {quantidade}");

            //3. Leia os golos marcados por uma equipa num número desconhecido de jogos e, no fim, 
            // mostre a média de golos por jogo(while)
            //int golos = 0, contador = 0, somar = 0;
            //double media;

            //while ( golos != -1)
            //{
            //    Console.WriteLine("Quantidade de golos no jogo ou -1 para terminar: ");
            //    golos = int.Parse(Console.ReadLine());//-1

            //    //if (golos == -1)
            //    //{
            //    //    break;
            //    //}

            //    if (golos != -1)
            //    {
            //        //somar += golos;
            //        somar = somar + golos;

            //        //contador = contador + 1;
            //        contador++;
            //    }
            //}

            //media = (double)somar / contador;

            //Console.WriteLine("Media de golos por jogo: " + Math.Round(media, 2));

            //4. Leia notas até aparecer - 1.
            //Mostre quantas foram lidas, a média, a maior e a menor. (while)

            //double nota = 0, media, maior = double.MinValue, menor = double.MaxValue, somar = 0;
            //int contador = 0;

            //while(nota != -1)
            //{
            //    Console.WriteLine("Digite a nota ou -1 para terminar: ");
            //    nota = double.Parse(Console.ReadLine());

            //    //if(nota == -1)
            //    //{
            //    //    break;
            //    //}

            //    if (nota != -1)
            //    {
            //        // MEDIA
            //        //        //somar += nota;
            //        somar = somar + nota;
            //        //        //contador = contador + 1;
            //        contador++;


            //        //maior = nota;
            //        //menor = nota;

            //        // nota = 20
            //        // maior = 0
            //        // 
            //        // 20 > 20
            //        // maior = 20
            //        // 
            //        // nota = 15
            //        // maior = 20
            //        // 
            //        // 15 > 20
            //        //
            //        if (nota > maior)
            //        {
            //            maior = nota;
            //            //maior = 20
            //        }

            //        // nota = 20
            //        // menor = 20
            //        // 
            //        // 20 < 20
            //        // menor = 20
            //        // 
            //        // nota = 15
            //        // menor = 20
            //        // 
            //        // 15 < 20
            //        //
            //        // menor = 15
            //        if (nota < menor)
            //        {
            //            menor = nota;
            //        }

            //    }
            //}

            //media = (double) somar / contador;

            //Console.WriteLine("Valor da media: " + Math.Round(media, 2));
            //Console.WriteLine("Valor da maior nota: " + Math.Round(maior, 2));
            //Console.WriteLine("Valor da menor nota: " + Math.Round(menor, 2));


            //5. Método que recebe 3 preços e devolve o mais baixo.
            //double preco1, preco2, preco3, menor;

            //Console.WriteLine("Digite preço 1: ");
            //preco1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite preço 2: ");
            //preco2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite preço 3: ");
            //preco3 = double.Parse(Console.ReadLine());

            //menor = preco3ValoresMaisBaixo(preco1, preco2, preco3);

            //Console.WriteLine("O menor valor é " + Math.Round(menor, 2));

            ////6. Método que recebe 3 idades e devolve a mais velha.
            //int idade1, idade2, idade3, maisVelha;

            //Console.Write("Idade 1: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.Write("Idade 2: ");
            //idade2 = int.Parse(Console.ReadLine());

            //Console.Write("Idade 3: ");
            //idade3 = int.Parse(Console.ReadLine());

            //maisVelha = As3MaisVelhas(idade1, idade2, idade3);

            //Console.WriteLine("A idade mais velha é " + maisVelha);


            #endregion
        }
    }
}
