using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula3_EstruturaDecisao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            #region Estrutura de decisão - if, else if, else
            //1. Leia o nome e a idade de duas pessoas e mostre o
            //nome da pessoa mais velha(if-else).
            //string nome1, nome2;
            //int idade1, idade2;

            //Console.WriteLine("Digite o nome da pessoa 1: ");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite a idade da pessoa 1: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome da pessoa 2: ");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite a idade da pessoa 2: ");
            //idade2 = int.Parse(Console.ReadLine());

            //if (idade1 > idade2)
            //{
            //    Console.WriteLine("A pessoa 1 com o nome " + nome1 + " é a mais velha.");
            //}
            //else if (idade2 > idade1)
            //{
            //    Console.WriteLine("A pessoa 2 com o nome " + nome2 + " é a mais velha.");
            //}
            //else
            //{
            //    Console.WriteLine("As duas pessoas tem a mesma idade.");

            //}



            //2. Simule uma calculadora com as operações básicas:
            //adição, subtração, multiplicação e divisão(if-else if).
            //Evite a divisão por zero.

            //string operador = "";
            //int numero1, numero2; 
            //double resultado;

            //Console.WriteLine("*************** Calculadora ***************");
            //Console.WriteLine("Digite o número 1: ");
            //numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número 2: ");
            //numero2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Escolha a operação pretendida digitando +, -, x ou /: ");
            //operador = Console.ReadLine();

            //if (operador == "+")
            //{
            //    resultado = numero1 + numero2;
            //    Console.WriteLine(numero1 + " + " + numero2 + " = " + resultado);
            //}
            //else if (operador == "-")
            //{
            //    resultado = numero1 - numero2;
            //    Console.WriteLine(numero1 + " - " + numero2 + " = " + resultado);
            //}
            //else if (operador == "x")
            //{
            //    resultado = numero1 * numero2;
            //    Console.WriteLine(numero1 + " x " + numero2 + " = " + resultado);
            //}
            //else if (operador == "/")
            //{
            //    if (numero2 > 0 && numero1 > 0)
            //    {
            //        resultado = (double) numero1 / numero2;
            //        Console.WriteLine(numero1 + " / " + numero2 + " = " + resultado);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Divisão por 0 não é possivel. \nPor favor coloque valores validos!");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Operação invalida. Digite +, -, x ou /.");
            //}

            ////6. Encontre o maior e o menor número entre três valores.
            //int numero1, numero2, numero3, maior;
            //bool evitarRepeticao = false;


            //Console.WriteLine("Digite o número 1: ");
            //numero1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número 2: ");
            //numero2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o número 3: ");
            //numero3 = int.Parse(Console.ReadLine());

            ////numero1 = 8
            ////numero2 = 5
            ////numero3 = 12

            ////numero1 = 8
            ////numero2 = 55
            ////numero3 = 12

            ////numero1 = 66
            ////numero2 = 55
            ////numero3 = 12

            ////numero1 = 66
            ////numero2 = 66
            ////numero3 = 66

            //maior = numero1; // maior = 8 // maior = 66

            //// 66 < 55
            //// 66 < 66
            //if(maior < numero2)
            //{
            //    maior = numero2;//maior = 55
            //}

            //// 8 < 12
            //// 55 < 12
            //// 66 < 66
            //if (maior < numero3)
            //{
            //    maior = numero3; // maior = 12
            //}

            //if (numero1 == numero2 && numero1 == numero3
            //    && numero2 == numero3)
            //{
            //    Console.WriteLine("Os numeros são todos iguais");
            //    evitarRepeticao = true;
            //}
            //else
            //{
            //    Console.WriteLine("O maior numero é o: " + maior);// 12 //55 //66
            //}

            ////numero1 = 1
            ////numero2 = 5
            ////numero3 = 8

            ////numero1 = 9
            ////numero2 = 5
            ////numero3 = 8

            ////numero1 = 9
            ////numero2 = 66
            ////numero3 = 8

            ////Menor
            ////1 < 5 && 1 < 8
            ////9 < 5 && 9 < 8
            ////9 < 66 && 9 < 8
            //if (numero1 < numero2 && numero1 < numero3)
            //{
            //    Console.WriteLine("O menor numero é o: " + numero1);// 1
            //}//5 < 9 && 5 < 8 // 66 < 9 && 66 < 8
            //else if (numero2 < numero1 && numero2 < numero3)
            //{
            //    Console.WriteLine("O menor numero é o: " + numero2);
            //}// 8 < 9 && 8 < 66
            //else if (numero3 < numero1 && numero3 < numero2)
            //{
            //    Console.WriteLine("O menor numero é o: " + numero3);
            //}
            //else if (evitarRepeticao != true)
            //{
            //    Console.WriteLine("Os numeros são todos iguais");
            //}


            #endregion

            #region Estrutura de repetição

            //for (para) -> temos por norma o valor limite

            //int quantidade = 3, idade, soma = 0, contador = 0;
            //double media;

            //Console.WriteLine("Digite a quantidade de idades a verificar: ");
            //quantidade = int.Parse(Console.ReadLine());

            //// i = 0; 0 < 3; 0 = 0 + 1
            ////Motivação pedir 1000 idades manualmente
            //for (int i = 0; i < quantidade; i++)
            //{
            //    Console.WriteLine("Digite a " + (i+1) + "º idade : ");
            //    idade = int.Parse(Console.ReadLine());

            //    soma = soma + idade;

            //    contador = contador + 1;
            //}

            //media = (double) soma / contador;
            //Console.WriteLine("A média de idades é " + media);

            //while (enquanto) -> não sabemos quando acaba

            double objetivo = 100.00, total = 0, deposito = 0;
            int contador = 0;

            //0 < 100
            //10 < 100
            //50 < 100
            //110 < 100
            //while( deposito != 0)
            while ( total  < 100)
            {
                //1º -> 0 = 0 + 1
                //2º -> 1 = 1 + 1
                //3º -> 2 = 2 + 1
                contador = contador + 1;

                //1º -> 10
                //2º -> 40
                //3º -> 60
                Console.WriteLine("Digite o valor do " + contador + "º deposito: ou digite 0 para terminar");
                deposito = double.Parse(Console.ReadLine());//10

                if (deposito == 0)
                {
                    break;
                    //continue;
                }


                //1º -> 0 = 0 + 10
                //2º -> 10 = 10 + 40
                //2º -> 50 = 50 + 60
                total = total + deposito;

                //2º -> total = 50
                //2º -> contador = 2

                //3º -> total = 110
                //3º -> contador = 3
            }

            Console.WriteLine("Objetivo alcançado ao " + contador + "º depoito, com o valor de " + total+ " €." );



            //Não vamos abordar
            //foreach
            //do while

            #endregion

            Console.ReadKey();
        }
    }
}
