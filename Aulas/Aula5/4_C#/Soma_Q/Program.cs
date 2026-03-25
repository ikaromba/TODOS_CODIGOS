using System;

namespace Soma_Q
{
    class Progam
    {
        static void Main(string[] args)
        {
            bool inicio = true;
            while (inicio)
            {
                //CODIGO INCOMPLETO 

            Console.WriteLine("---------Soma-Quadrdo-----------");
            Console.WriteLine("Digite um numero: ");
            string N = Console.ReadLine();
            //converte o texto em numero
            int P = int.Parse(N);
            int Num = P*P;
            Console.WriteLine($"Seu valor {Num}");

            int CopiaP = P;
            int Test = 0;

            while (CopiaP > 0)
                {
                    int Corte = CopiaP % 10;
                    Test += Corte;
                    CopiaP = CopiaP / 10;
                }
                Console.WriteLine($"Seu numero somado por cada unidade separadamente: {Test}");
                //CODIGO INCOMPLETO intepretei errado e já sao 9:30 da noite

            }

        }
    }
}