using System;

namespace Leritor_par_Impar
{
    class Progam
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Indentificador de N inteiro se é imapar ou par");
            Console.WriteLine("Digite o numero: ");
            int N = int.Parse(Console.ReadLine());
            Caculo_Par_Impar(N);

        }

                static void Caculo_Par_Impar(int N)
        {
            if (N % 2 == 0)
            {
                Console.WriteLine("O NUMERO É PAR");
            }else
            {
                Console.WriteLine("O NUMERO É IMPAR");
            }
        }
    }
}