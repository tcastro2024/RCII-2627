using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace aula5_metodos
{
    internal class Program
    {

        //"tipo de dado de retorno" "designação" "( recebe parametros. ex.: int val1, int val2 ...)"
        static double Media3ValoresInteiros(int valor1, int valor2, int valor3)
        {
            double media = 0;

            media = (double) (valor1 + valor2 + valor3) / 3;

            return media;
        }

        static double Media2Idades(int idade1,  int idade2)
        {
            double media;

            //media = (double) (idade1 + idade2) / 2;
            media = (double) (idade1 + idade2) / 2;

            return media;
        }

        static void Main(string[] args)
        {
            //media de 3 valores inteiros
            // int valor1, valor2, valor3;
            // double media = 0;

            // Console.WriteLine("1º Valor: ");
            // valor1 = int.Parse(Console.ReadLine());

            // Console.WriteLine("2º Valor: ");
            // valor2 = int.Parse(Console.ReadLine());

            // Console.WriteLine("3º Valor: ");
            // valor3 = int.Parse(Console.ReadLine());

            // //media = (valor1 + valor2 + valor3) / 3;
            // media = Media3ValoresInteiros(valor1, valor2, valor3) + 50; 

            // Console.WriteLine("Media: " + Math.Round(media, 2));


            //media = Media3ValoresInteiros(valor1, valor2, valor3);

            #region Correção da Ficha

            //1.Faça um programa que calcule a área do triangulo.Formula: área = (base x altura) / 2.
            double area, base1, altura;

            Console.WriteLine("Digite o valor da base: ");
            base1 = double.Parse( Console.ReadLine());

            Console.WriteLine("Digite o valor da altura: ");
            altura = double.Parse(Console.ReadLine());

            area = (base1 *  altura) / 2;

            Console.WriteLine("O valor da área é " + area + ".");

            //2.Faça um programa para verificar o maior de dois números inteiros(Utilize a estrutura ifelse).
            int numero1, numero2;

            Console.WriteLine("Digite o 1º número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O número " + numero1 + " é o maior.");
            }
            else
            {
                Console.WriteLine("O número " + numero2 + " é o maior.");
            }

            //3.Leia n valores representativos do pH e mostre, para cada valor, que tipo de solução
            //representa: ácida(pH < 7), neutra(pH = 7) ou alcalina(pH> 7) (Utilize a estrutura for).

            int quantidadePH;
            double ph;

            //Console.WriteLine("Quantidade de PHs a verificar: ");
            //quantidadePH = int.Parse(Console.ReadLine());

            //for (int i = 0; i < quantidadePH; i++)
            for (int i = 0; i < 3; i++)       
            {
                Console.WriteLine("Digite o " + (i + 1) + "º  ph: ");
                ph = int.Parse(Console.ReadLine());

                if( ph < 7 )
                {
                    Console.WriteLine("ácida");
                }
                else if( ph == 7 )
                {
                    Console.WriteLine("neutra");
                }
                else
                {
                    Console.WriteLine("alcalina");
                }
            }

            //4.Criar um método que calcule a média de 2 idades.

            //int idade1, idade2;
            //double media = 0;  

            //Console.WriteLine("Digite a 1º idade: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a 2º idade: ");
            //idade2 = int.Parse(Console.ReadLine());


            ////media = (idade1 + idade2) / 3;
            //media = Media2Idades( idade1, idade2);

            //Console.WriteLine("Media de duas idades: " + Math.Round(media, 2));

            //Media de golos de varias partidas

            int golos = 0, contadorPartidas = 0, somarGolos = 0;
            double media;

            while (golos != -1) // 0 != 1 -> verdade
            {
                Console.WriteLine("Digite o número do golos ou -1 para terminar: ");
                golos = int.Parse( Console.ReadLine() );
                // 5 -> golos 
                // 6 -> golos
                // -1

                //golos = -1
                // -1 != -1


                //if (golos == -1)
                //{
                //    break;
                //}

                if (golos != -1)
                {
                    somarGolos += golos;
                    //somarGolos = somarGolos + golos; // 5 + 6 -> 11 + (-1)
                    //5
                    //11

                    //contadorPartidas = contadorPartidas + 1; // 0 +1 ->1+1
                    //1
                    //2
                    contadorPartidas++;
                }
            }

            media = (double) somarGolos / contadorPartidas;

            Console.WriteLine("Media de golos: " + Math.Round(media, 2));

            #endregion


        }
    }
}
