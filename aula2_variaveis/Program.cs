using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace aula2_variaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            //int idade;

            //idade = 20; // ou pediam ao utilizador

            ////idade; = 20

            //idade = 30;

            //idade = 30 + 1;


            //Console.WriteLine("A pessoa tem " + idade + " anos de idade.");

            //bool completo = false, estaDeNoite = true;

            //int x;

            //x = 10;

            ///*
            //  Comentário 
            //  em multiplas 
            //  linhas
            // */

            //// x é a mesma coisa que escrever 10
            //x = x + 5;

            ////x = y;
            ////x = A;
            //Console.WriteLine(x);

            //// 1. Declarar variáveis
            //string nome1;
            //int dia, mes, ano;
            //// 2. Atribuir valores
            //nome1 = "Tiago Castro";
            //dia = 28;
            //mes = 3;
            //ano = 2002;
            //// 3. Mostrar na consola
            //Console.WriteLine("NOME: " + nome1);
            //Console.WriteLine("DIA: " + dia + "\nMÊS: " + mes + "\nANO: " + ano);

            //string nome2;
            //int idade1;
            //double altura1;

            //// Ler texto
            //Console.WriteLine("Digite o 1º nome: ");
            //nome2 = Console.ReadLine();

            //// int.Parse converte a string lida para int
            //Console.WriteLine("Digite a 1ª idade: ");
            //idade1 = int.Parse(Console.ReadLine());

            //// double.Parse converte a string lida para double
            //Console.WriteLine("Digite a 1ª altura: ");
            //altura1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Nome: " + nome2);
            //Console.WriteLine("Idade: " + idade1);
            //Console.WriteLine("Altura: " + altura1);




            //5. Leia o código de uma peça, a quantidade e o preço da peça.

            //string codigo;
            //int qtd;
            //double preco;

            //Console.WriteLine("Digite o código: ");
            //codigo = Console.ReadLine();

            ////int.Parse - Converte o que o utilizador colocou para inteiros
            //Console.WriteLine("Digite a quantidade: ");
            //qtd = int.Parse(Console.ReadLine());

            ////double.Parse - Converte o que o utilizador colocou para números reais
            //Console.WriteLine("Digite o valor do preço: ");
            //preco = double.Parse(Console.ReadLine());

            //Console.WriteLine("Valor do código: " + codigo);
            //Console.WriteLine("Valor do quantidade: " + qtd);
            //Console.WriteLine("Valor do preço: " + preco);

            //////////////
            ///

            //int a = 5;
            //int b = 2;

            //double resultado = (double) a / b;


            //Console.Write(resultado);


            //Console.ReadKey();





            #region Exercícios com Variáveis

            // ***** 1.Declare variáveis para armazenar: nome(string), idade(int) e altura(double) e
            // se é estudante(bool). Atribua valores e mostre-os na consola.
            //string nome = "João";
            //int idade = 25;
            //double altura = 1.75;
            //bool estudante = true;

            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Idade: " + idade);
            //Console.WriteLine("Altura: " + altura);
            //Console.WriteLine("Estudante: " + estudante);

            // ***** 2.Leia nome, dia, mês e ano de nascimento e escreva na consola.
            //string nome = "Maria";
            //int dia = 15;
            //int mes = 6;
            //int ano = 1990;

            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Data de Nascimento: " + dia + "/" + mes + "/" + ano);

            // ***** 3.Fazer um programa para ler o nome e a idade de duas pessoas;
            //string nome1, nome2;
            //int idade1, idade2;

            //Console.WriteLine("Digite o nome da primeira pessoa:");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite a idade da primeira pessoa:");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome da segunda pessoa:");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite a idade da segunda pessoa:");
            //idade2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Primeira pessoa: " + nome1 + ", Idade: " + idade1);
            //Console.WriteLine("Segunda pessoa: " + nome2 + ", Idade: " + idade2);

            // ***** 4.Fazer um programa para ler nome e salário de dois funcionários;
            //string nome1, nome2;
            //double salario1, salario2;

            //Console.WriteLine("Digite o nome do primeiro funcionário:");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite o salário do primeiro funcionário:");
            //salario1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome do segundo funcionário:");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite o salário do segundo funcionário:");
            //salario2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Primeiro funcionário: " + nome1 + ", Salário: " + salario1);
            //Console.WriteLine("Segundo funcionário: " + nome2 + ", Salário: " + salario2);

            // ***** 5.Fazer um programa para ler o código de uma peça,
            // a sua quantidade e o preço da peça. // (Escrito em formato papel)
            //string codigoPeca;
            //int quantidadePeca;
            //double precoPeca;

            //Console.WriteLine("Digite o código da peça:");
            //codigoPeca = Console.ReadLine();

            //Console.WriteLine("Digite a quantidade da peça:");
            //quantidadePeca = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o preço da peça:");
            //precoPeca = double.Parse(Console.ReadLine());

            //Console.WriteLine("Código da peça: " + codigoPeca);
            //Console.WriteLine("Quantidade da peça: " + quantidadePeca);
            //Console.WriteLine("Preço da peça: " + precoPeca);

            // ***** 6.Qual a diferença entre os tipos de dados int ou uint?
            // int é um tipo de dado inteiro com sinal, que pode armazenar valores negativos e positivos,
            // enquanto uint é um tipo de dado inteiro sem sinal, que só pode armazenar valores positivos.
            // O intervalo de valores para int é de -2.147.483.648 a 2.147.483.647,
            // enquanto para uint é de 0 a 4.294.967.295.
            // ***** 7.Crie um exemplo de comentários com uma linha e outro com várias linhas.

            // Comentário de uma linha

            /* Comentário de várias linhas
             * Este é um exemplo de comentário
             * que se estende por várias linhas.
             */

            // ***** 8.Escreva um programa que peça e escreva o nome, email e idade do utilizador no ecrã.
            //string nome, email;
            //int idade;

            //Console.WriteLine("Digite o seu nome:");
            //nome = Console.ReadLine();

            //Console.WriteLine("Digite o seu email:");
            //email = Console.ReadLine();

            //Console.WriteLine("Digite a sua idade:");
            //idade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Email: " + email);
            //Console.WriteLine("Idade: " + idade);

            // ***** 9.Crie o exemplo de uma fatura de um supermercado na consola.
            //Console.WriteLine("********** Fatura Supermercado **********");
            //Console.WriteLine("Produto: Arroz");
            //Console.WriteLine("Quantidade: 2 kg");
            //Console.WriteLine("Preço unitário: € 5,00");
            //Console.WriteLine("Produto: Feijão");
            //Console.WriteLine("Quantidade: 1 kg");
            //Console.WriteLine("Preço unitário: € 4,00");
            //Console.WriteLine("Produto: Macarrão");
            //Console.WriteLine("Quantidade: 3 pacotes");
            //Console.WriteLine("Preço unitário: € 2,50");
            //Console.WriteLine("******************************************");

            #endregion

            #region Exercícios com Conversões
            //***** 1.Converta a variável “string valor = “0123” para número do tipo de dados inteiro.
            //string valor = "0123";

            //int numero = int.Parse(valor);

            //Console.WriteLine(numero);

            //***** 2.Converta a variável “int idade = 20” para o tipo de dados string(texto)
            //e concatene/junte com uma letra.

            //int idade = 20;

            //string idadeString = idade.ToString() + " anos";

            //Console.WriteLine(idadeString);

            //***** 3.Converta a variável “double comprimento = 1.70” para o tipo de dados inteiro.
            //double comprimento = 1.70;

            //int comprimentoInteiro = (int)comprimento;

            //Console.WriteLine(comprimentoInteiro);

            //***** 4.Converta a variável “double preco = 55.5” para o tipo de dados string(texto)
            //e concatene/junte com uma letra.
            //double preco = 55.5;

            //string precoString = preco.ToString() + " €";

            //Console.WriteLine(precoString);

            #endregion

            #region Exercícios com Operadores

            //***** 1.Fazer um programa para ler nome e salário de dois funcionários.
            //Depois, mostrar a média do salário dos funcionários.
            //string nome1, nome2;
            //double salario1, salario2;

            //Console.WriteLine("Digite o nome do primeiro funcionário:");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite o salário do primeiro funcionário:");
            //salario1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o nome do segundo funcionário:");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite o salário do segundo funcionário:");
            //salario2 = double.Parse(Console.ReadLine());

            //double mediaSalario = (salario1 + salario2) / 2;

            //Console.WriteLine("Média do salário dos funcionários: " + mediaSalario);

            //***** 2.Faça um programa que calcule a área do triangulo? Formula: área = (base x altura) / 2
            //double baseTriangulo, alturaTriangulo, areaTriangulo;

            //Console.WriteLine("Digite a base do triângulo:");
            //baseTriangulo = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a altura do triângulo:");
            //alturaTriangulo = double.Parse(Console.ReadLine());

            //areaTriangulo = (baseTriangulo * alturaTriangulo) / 2;

            //Console.WriteLine("Área do triângulo: " + areaTriangulo);

            //***** 3.Declare uma constante para PI(3.14159) e calcule a área de um círculo de raio 5.0.Mostre o resultado.
            //double are


            //***** 4.Crie uma calculadora que receba dois números e realize as 4 operações básicas.
            //***** 5.Crie um programa que leia 3 notas de um aluno e calcule a média aritmética.
            //***** 6.Faça um programa que leia um número inteiro e o imprima na consola.
            //***** 7.Peça ao utilizador para digitar 3 valores inteiros e imprima a soma deles na consola. (Escrito em formato papel)
            //***** 8.Leia um número inteiro e imprima o resultado do quadrado deste número.
            //***** 9.Faça um algoritmo que converta uma temperatura fornecida em graus Fahrenheit para Centígrados.
            //Sugestão: utilize a fórmula C = 5 / 9(F - 32).

            #endregion

            #region Exercícios com variáveis

            //1. Declare variáveis para guardar nome (string), idade
            //(int), altura(double) e se é estudante(bool). Atribua
            //valores e mostre-os na consola.
            //string nome = "Tiago Machado";
            //int idade = 3;
            //double altura = 1.05;
            //bool estudante = false;

            //Console.WriteLine(nome);
            //Console.WriteLine(idade);
            //Console.WriteLine(altura);
            //Console.WriteLine(estudante);

            //2. Leia o nome e a data de nascimento(dia, mês e ano) e
            // escreva - os na consola.
            //string nome = "Tiago Machado";
            //string dataNascimento;

            //Console.WriteLine("Digite o nome: ");
            //nome = Console.ReadLine();

            //Console.WriteLine("Digite a data de nascimento: ");
            //dataNascimento = Console.ReadLine();

            ////string dataNascimento = "28/03/2023";

            ////int ano = 2023;
            ////int mes = 03;
            ////int dia = 28;

            //Console.WriteLine("Nome: " + nome);
            //Console.WriteLine("Data de nascimento: " + dataNascimento);
            ////Console.WriteLine("Data de nascimento: " + dia + "/0" + mes + "/" +ano);



            // 3. "Leia o nome e a idade de duas pessoas e mostre-os.

            //Escrever -> Console.WriteLine(
            //Ler -> Console.ReadLine()

            //int idade1, idade2;
            //string nome1, nome2;

            ////Escrever e ler
            //Console.WriteLine("Digite o nome da 1º pessoa: ");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite o nome da 2º pessoa: ");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite a idade da 1º pessoa: ");
            //idade1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite a idade da 2º pessoa: ");
            //idade2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Nome da 1º pessoa: " + nome1);
            //Console.WriteLine("Idade da 1º pessoa: " + idade1);
            //Console.WriteLine("Nome da 2º pessoa: " + nome2);
            //Console.WriteLine("Idade da 2º pessoa: " + idade2);

            //4. Leia o nome e o salário de dois funcionários e mostre-os.
            //double salario1, salario2;
            //string nome1, nome2;

            ////Escrever e ler
            //Console.WriteLine("Digite o nome da 1º pessoa: ");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite o nome da 2º pessoa: ");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite o salário da 1º pessoa: ");
            //salario1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o salário da 2º pessoa: ");
            //salario2 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Nome da 1º pessoa: " + nome1);
            //Console.WriteLine("salário da 1º pessoa: " + salario1);
            //Console.WriteLine("Nome da 2º pessoa: " + nome2);
            //Console.WriteLine("salário da 2º pessoa: " + salario2);

            //5. Leia o código de uma peça, a quantidade e o preço da
            //peça.
            //string codigo;
            //int quantidade;
            //double preco;

            //////Escrever e ler
            //Console.WriteLine("Digite o código: ");
            //codigo = Console.ReadLine();

            //Console.WriteLine("Digite a quantidade: ");
            //quantidade = int.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o preço: ");
            //preco = double.Parse(Console.ReadLine());

            ///*
            //Console.WriteLine("Código: " + codigo);
            //Console.WriteLine("Quantidade: " + quantidade);
            //Console.WriteLine("Preço: " + preco);
            //*/

            //int i = 10;

            //string texto = i.ToString(); // str = "10"

            //// 10 + abc -> 10abc
            //texto = texto + "abc";
            //Console.WriteLine(texto);

            //2589 -> 8925
            //int numero = 2589;

            //string texto = numero.ToString();

            //string numeroTrocado;

            //Console.WriteLine(texto);
            //Console.WriteLine(texto[0]);
            //Console.WriteLine(texto[1]);
            //Console.WriteLine(texto[2]);
            //Console.WriteLine(texto[3]);

            //numeroTrocado = "" + texto[2] + texto[3] + texto[0] + texto[1];

            //Console.WriteLine(numeroTrocado);

            //int valor = 0;
            //string str = "";
            //double valorConvertido = 0.0;
            //Console.Write("Insira um valor inteiro: ");
            //valor = int.Parse(Console.ReadLine());
            //Console.WriteLine(valor);
            //str = "24,45";
            //valorConvertido = (int) double.Parse(str);
            //Console.Write("\n" + valorConvertido);



            #endregion

            #region Exercícios com conversões

            // 1. Converta a variável string valor = "0123" para um
            // número do tipo int.
            //string valor = "0123";
            //int numero;

            //numero = int.Parse(valor);

            //Console.WriteLine(numero); //123

            //2.Converta a variável int idade = 20 para string e junte - lhe
            //uma letra.
            //int idade = 20;
            //string texto;

            //texto = idade.ToString() + "T";

            //Console.WriteLine(texto);

            //3. Converta a variável double comprimento = 1.70 para o
            // tipo int.
            //double comprimento = 1.70;
            //int valor;

            //valor = (int) comprimento;// valor = 1

            //Console.WriteLine(valor);
            //Console.WriteLine(comprimento);

            //4. Converta a variável double preco = 55.5 para string e
            // junte - lhe uma letra.

            //double preco = 55.5;
            //string texto;

            //texto = preco.ToString() + "L";

            //Console.WriteLine(texto);

            #endregion

            //int resto = 10 % 3;

            //Console.WriteLine("Resultado: " + resto);


            #region Exercícios com operadores 

            //1. Leia o nome e o salário de dois funcionários e mostre a
            //média dos salários.
            //double salario1, salario2, media;
            //string nome1, nome2;

            ////Escrever e ler
            //Console.WriteLine("Digite o nome da 1º pessoa: ");
            //nome1 = Console.ReadLine();

            //Console.WriteLine("Digite o nome da 2º pessoa: ");
            //nome2 = Console.ReadLine();

            //Console.WriteLine("Digite o salário da 1º pessoa: ");
            //salario1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o salário da 2º pessoa: ");
            //salario2 = double.Parse(Console.ReadLine());

            //media  = (salario1 +  salario2) / 2;

            //Console.WriteLine("Nome da 1º pessoa: " + nome1);
            //Console.WriteLine("salário da 1º pessoa: " + salario1);
            //Console.WriteLine("Nome da 2º pessoa: " + nome2);
            //Console.WriteLine("salário da 2º pessoa: " + salario2);
            //Console.WriteLine("Media dos salários: " + media);

            //4. Crie uma calculadora que leia dois números e faça as 4
            //operações básicas.
            //double numero1, numero2, soma, subtracao, multiplicacao, divisao;

            //////Escrever e ler
            //Console.WriteLine("Digite o 1º número: ");
            //numero1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Digite o 2º número: ");
            //numero2 = double.Parse(Console.ReadLine());

            //soma = numero1 + numero2;

            //subtracao = numero1 - numero2;

            //multiplicacao = numero1 * numero2;

            //divisao = numero1 / numero2;

            //Console.WriteLine("soma: " + soma); 
            //Console.WriteLine("subtracao: " + subtracao); 
            //Console.WriteLine("multiplicacao: " + multiplicacao); 
            //Console.WriteLine("divisao: " + divisao);

            Console.WriteLine(Math.Pow(5, 2));

            #endregion


            Console.ReadKey();
        }
    }
}
