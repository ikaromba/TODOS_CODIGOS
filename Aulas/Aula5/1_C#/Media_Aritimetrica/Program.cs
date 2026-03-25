using System;
using System.Linq;

namespace M_Aritimetrica
{
    class Progam
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-----------MEDIA-----------");
            //Console.WriteLine("Quantidade de numeros que serão digitados");
            //int Q = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite números considerados na média");
            Console.WriteLine("Exemplo: 11 22 33 44");
            string Numeros = Console.ReadLine();

            //Separa os numeros
            int[] Qn = Numeros.Split(' ').Select(int.Parse).ToArray();
            //Seleciona somente numeros pare por meio de uma conta que analise se o resultado da 0 
             int[] numerosPares = Qn.Where(n => n % 2 == 0).ToArray();
             if (numerosPares.Length > 0)
            {
                int quantidadePares = numerosPares.Length;
                int somaPares = numerosPares.Sum();

             double media = (double)somaPares / quantidadePares;

             Console.WriteLine($"\nNúmeros digitados: {Qn.Length}");
                Console.WriteLine($"Números pares encontrados: {quantidadePares}");
                Console.WriteLine($"Soma dos pares: {somaPares}");
                Console.WriteLine($"Média aritmética dos pares: {media:F2}");
            }
            else
            {
                Console.WriteLine("Nenhum número par foi digitado.");
            }
            //Console.WriteLine(Qn[0]);
            //int Quantidade_N = Qn.Length;
            //mostra a quantidade de numeros digitada
            //Console.WriteLine($"Existem {Quantidade_N} números na variável.");

            //float dvi = Qn / Quantidade_N;
            //Console.WriteLine($"{dvi}");
            //int Par =  (Qn % 2 == 0);
            //Console.WriteLine($"{PAr} ");
            //Contas(C);
        }
                //static void Contas(int C)
           // Console.WriteLine("Hi");
        }
    }
