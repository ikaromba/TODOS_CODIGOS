using System;

namespace Exer2
{
    class Progam
    {
        static void Main(string[] args)
        {
            int[] N = {10,9,8,7,6,5,4,3,2,1};
            Console.WriteLine("Qual numero do vetor voce quer pesquisar?");
            //pesquisar se o numero digitado ira puxar o numero da lista
            int numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] == numero)
                {
                    Console.WriteLine("Numero encontrado na posicao {0}", i);
                    console.WriteLine("O numero {0} esta na posicao {1}", numero, i);
                }
            }
            
        }
    }
}