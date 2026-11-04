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

            //6. Encontre o maior e o menor número entre três valores.
            int numero1, numero2, numero3, maior, menor;


            Console.WriteLine("Digite o número 1: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 2: ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número 3: ");
            numero3 = int.Parse(Console.ReadLine());

            //numero1 = 8
            //numero2 = 5
            //numero3 = 12

            //numero1 = 8
            //numero2 = 55
            //numero3 = 12

            //numero1 = 66
            //numero2 = 55
            //numero3 = 12

            //numero1 = 66
            //numero2 = 66
            //numero3 = 66

            maior = numero1; // maior = 8 // maior = 66

            // 66 < 55
            // 66 < 66
            if(maior < numero2)
            {
                maior = numero2;//maior = 55
            }

            // 8 < 12
            // 55 < 12
            // 66 < 66
            if (maior < numero3)
            {
                maior = numero3; // maior = 12
            }

            if (numero1 == numero2 && numero1 == numero3
                && numero2 == numero3)
            {
                Console.WriteLine("Os numeros são todos iguais");
            }
            else
            {
                Console.WriteLine("O maior numero é o: " + maior);// 12 //55 //66
            }


            #endregion

            Console.ReadKey();
        }
    }
}
