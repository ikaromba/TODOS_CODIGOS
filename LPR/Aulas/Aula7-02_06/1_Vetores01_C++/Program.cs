using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leitor de 10 numeros, idetificara os numeros pares e imapres");
            int[] N = {10,9,8,7,6,5,4,3,2,1};
            Console.WriteLine("Todos os numeros:");
            //deixa visivel os nuemros dos vetores N
            foreach (int numero in N)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine("\n"); // Quebra de linha para organizar

            Console.WriteLine("Numeros pares:");
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 == 0)
                {
                    Console.WriteLine(N[i] + " ");
                }
            }Console.WriteLine("\n");

            Console.WriteLine("Numeros impares:");
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 != 0)
                {
                    Console.WriteLine(N[i] + " ");
                }
            }Console.WriteLine("\n");
            
            Console.WriteLine("Fim do Code");
        }
    }
}