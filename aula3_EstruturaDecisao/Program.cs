using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
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

            //double objetivo = 100.00, total = 0, deposito = 0;
            //int contador = 0;

            ////0 < 100
            ////10 < 100
            ////50 < 100
            ////110 < 100
            ////while( deposito != 0)
            //while ( total  < 100)
            //{
            //    //1º -> 0 = 0 + 1
            //    //2º -> 1 = 1 + 1
            //    //3º -> 2 = 2 + 1
            //    contador = contador + 1;

            //    //1º -> 10
            //    //2º -> 40
            //    //3º -> 60
            //    Console.WriteLine("Digite o valor do " + contador + "º deposito: ou digite 0 para terminar");
            //    deposito = double.Parse(Console.ReadLine());//10

            //    if (deposito == 0)
            //    {
            //        break;
            //        //continue;
            //    }


            //    //1º -> 0 = 0 + 10
            //    //2º -> 10 = 10 + 40
            //    //2º -> 50 = 50 + 60
            //    total = total + deposito;

            //    //2º -> total = 50
            //    //2º -> contador = 2

            //    //3º -> total = 110
            //    //3º -> contador = 3
            //}

            //Console.WriteLine("Objetivo alcançado ao " + contador + "º depoito, com o valor de " + total+ " €." );



            //Não vamos abordar
            //foreach
            //do while

            #endregion


            #region Revisoes aulas anteriores

            //int idade = 7;

            //double salario = 15.5;

            //string nome = "Joana";

            //bool estaAChoverOuNao = true;

            //////
            // Operadores
            //
            //      ()
            //  *  | / | %
            //  +  | -
            //  =

            // Conversores
            //
            //int soma = 50, quantidade = 3;
            ////double soma = 50, quantidade = 3;
            //double media;
            //string mediaEmTexto;

            //media = (double) soma / quantidade;

            //mediaEmTexto = "0" + media.ToString();

            //Console.WriteLine("Resultado: " + mediaEmTexto);

            //// Estruturas de decisão
            ////if , else if , else 

            //// Ler e mostrar menor de 3 valores inteiros e mostrar se forem os 3 iguais
            //int valor1, valor2, valor3;

            //Console.WriteLine("1º Valor: ");
            //valor1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2º Valor: ");
            //valor2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("3º Valor: ");
            //valor3 = int.Parse(Console.ReadLine());

            // valor1 = 5
            // valor2 = 5
            // valor3 = 8

                // valor1 = 8
                // valor2 = 5
                // valor3 = 5

                // valor1 = 5
                // valor2 = 8
                // valor3 = 5

                // valor1 = 4
                // valor2 = 5
                // valor3 = 8

                // valor1 = 8
                // valor2 = 5
                // valor3 = 4

                // 4 == 5 && 4 == 8
                // 8 == 5 && 8 == 4
                // 5 == 5 && 5 == 8

                //INCLUI CENARIO EM ESCRITO CASO VENHAM 2 VALORES IGUAIS
                //if (valor1 == valor2 && valor1 == valor3)
                //{
                //    Console.WriteLine("O valores são iguais.");
                //}// 4 < 5 && 4 < 8 // 8 < 5 && 8 < 4 // 5 <= 5 && 5 <= 8
                //else if (valor1 < valor2 && valor1 < valor3)
                //{
                //   Console.WriteLine("O valor, " + valor1 + " é o menor.");    
                //}// 5 < 5 && 5 < 8 // 5 < 8 && 5 < 4
                //else if (valor2 < valor1 && valor2 < valor3) // 5 < 5 && 5 < 8
                //{
                //   Console.WriteLine("O valor, " + valor2 + " é o menor.");       
                //} // 4 < 8 && 4 < 5
                //else if (valor3 < valor1 && valor3 < valor2)
                //{
                //  Console.WriteLine("O valor, " + valor3 + " é o menor.");          
                //} // 5 == 5 && 5 < 8 // 8 == 5 && 8 < 5
                //else if (valor1 == valor2 && valor1 < valor3)
                //{
                //    Console.WriteLine("O valor1 e o valor2 são os menores.");
                //}// 5 == 5 && 5 < 8
                //else if (valor2 == valor3 && valor2 < valor1)
                //{
                //    Console.WriteLine("O valor2 e o valor3 são os menores.");
                //}//5 == 5 && 5 < 8
                //else if (valor1 == valor3 && valor1 < valor2)
                //{
                //    Console.WriteLine("O valor1 e o valor3 são os menores.");
                //}

                //CENARIO DE FORMA GENERICA
                // valor1 = 5
                // valor2 = 5
                // valor3 = 4

                // 5 <= 5 && 5 <= 8 - Quando se utiliza a versão
                // && as condições tem de ser todas iguais
                // se fosse || bastava uma das condições ser verdade
                //if (valor1 <= valor2 || valor1 <= valor3)
                // 5 <= 5 || 5 <= 4 -> entra e diz que o valor 1 = 5 é menor erradamente para o 
                // cenario Valor1= 5, valor2= 5 e valor3 =4

            //if (valor1 == valor2 && valor1 == valor3)
            //{
            //    Console.WriteLine("O valores são iguais.");
            //}
            //else if (valor1 <= valor2 && valor1 <= valor3)
            //{
            //    Console.WriteLine("O valor, " + valor1 + " é o menor.");
            //}
            //else if (valor2 <= valor1 && valor2 <= valor3)
            //{
            //    Console.WriteLine("O valor, " + valor2 + " é o menor.");
            //} 
            //else
            //{
            //    Console.WriteLine("O valor, " + valor3 + " é o menor.");
            //}

            // for 
            // calcular uma media de idades uma quatidade definida de valores

            //int quantidade, idade, soma = 0;
            //double media;

            //Console.WriteLine("Quantidade de idades a verificar: ");
            //quantidade = int.Parse(Console.ReadLine());// 3

            ////0; 0 < 3; 0 -> 1 -> 2
            //// 1 < 3; 1
            //// 2 < 3; 2
            //// 3 < 3; -> sai fora
            //for (int i = 0; i < quantidade; i++)
            //{
            //    Console.WriteLine("Digite a " + (i + 1) + "º idade: ");
            //    idade = int.Parse(Console.ReadLine());//20, 10, 40

            //    //Alternativa soma += idade
            //    soma = soma + idade;
            //    //1º 0 = 0 + 20
            //    //2º 20 = 20 + 10
            //    //3º 30 = 30 + 40

            //    //soma = 20
            //    //soma = 30
            //    //soma = 70
            //}

            //media = (double) soma / quantidade;

            //Console.WriteLine("Media: " + Math.Round(media, 2));

            // while 
            // calcular uma media de idades uma quatidade indefinida de valores
            //int contador = 0, idade = 0, soma = 0;
            //double media;

            //// 0 != -1 -> verdade | -1 != -1 ->  Falso
            //while (idade != -1)
            //{
            //    Console.WriteLine("Digite a " + (contador + 1) + "º idade ou -1 para terminar: ");//  0 + 1 -> 1 + 1
            //    idade = int.Parse(Console.ReadLine());//20, 10, 40

            //    // -1 == -1 -> verdade
            //    if (idade == -1)
            //    {
            //        break;// Entra no if e sai do while devido ao break
            //    }

            //    //Alternativa soma += idade
            //    soma = soma + idade;
            //    //    //1º 0 = 0 + 20
            //    //    //2º 20 = 20 + 10
            //    //    //3º 30 = 30 + 40

            //    //    //soma = 20
            //    //    //soma = 30
            //    //    //soma = 70

            //    contador++;
            //    //0
            //    //1
            //    //2
            //}

            //media = (double) soma / contador;

            //Console.WriteLine("Media: " + Math.Round(media, 2));

            #endregion

            Console.ReadKey();
        }
    }
}
 