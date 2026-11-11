using System;
using System.Collections.Generic;
using System.Linq;
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

            media = (valor1 + valor2 + valor3) / 3;

            return media;
        }

        static void Main(string[] args)
        {
            //media de 3 valores inteiros
            int valor1, valor2, valor3;
            double media = 0;

            Console.WriteLine("1º Valor: ");
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2º Valor: ");
            valor2 = int.Parse(Console.ReadLine());

            Console.WriteLine("3º Valor: ");
            valor3 = int.Parse(Console.ReadLine());

            media = Media3ValoresInteiros(valor1, valor2, valor3);  //media = (double) soma / contador;

            Console.WriteLine("Media: " + Math.Round(media, 2));

        }
    }
}
