using System;

class Program
{
    static void Main()
    {
               String bird = (@"
 -BIRD
    ____       _____   ____
   | _  \  () | _  || |  _ \
   ||_| /  || ||_| // | | | |
   | _ |   || |   //  | | | |
   ||_| \  || | |\ \  | | | |
   |____/  || | | \ \ |____/
                       
                    /_/ \            
                  o/ o   \____      ///
                  <     ______\___ ////
   _               \  /        \____  /
  \ \______         \  \           _ \
   \ _  __ \          \ _ \________\
Ika  /_/  \ \___________ // //_________
           \_________________________  \
                                     |  |");

        Console.WriteLine("{0}", bird);
        Console.WriteLine("--- Identificador de Pássaros ---");

        Console.Write("O pássaro é de estimação? (sim/nao): ");
        string pet = Console.ReadLine().ToLower();
//Passaralho();

        if (pet == "sim")
        {
            Console.Write("É verde e fala? (sim/nao): ");
            if (Console.ReadLine().ToLower() == "sim")
            {
                Console.WriteLine("Resultado: Papagaio");
            }
            else
            {
                Console.Write("Tem uma mancha laranja na bochecha? (sim/nao): ");
                if (Console.ReadLine().ToLower() == "sim")
                {
                    Console.WriteLine("Resultado: Calopsita");
                }
                else
                {
                    Console.Write("É pequeno e colorido? (sim/nao): ");
                    if (Console.ReadLine().ToLower() == "sim")
                    {
                        Console.WriteLine("Resultado: Periquito Australiano");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: Pássaro desconhecido");
                    }
                }
            }
        }
        else
        {
            Console.Write("É um predador noturno? (sim/nao): ");
            if (Console.ReadLine().ToLower() == "sim")
            {
                Console.Write("Imita um galho/tronco? (sim/nao): ");
                if (Console.ReadLine().ToLower() == "sim")
                {
                    Console.WriteLine("Resultado: Urutau");
                }
                else
                {
                    Console.WriteLine("Resultado: Coruja ou Bacurau (verifique o tamanho)");
                }
            }
            else
            {
                Console.Write("Ele é conhecido por dar rasante no ar? (sim/nao): ");
                if (Console.ReadLine().ToLower() == "sim")
                {
                    Console.WriteLine("Resultado: Gavião");
                }
                else
                {
                    Console.WriteLine("Resultado: Pássaro");
                }
            }
        }
        //static void Passaralho()
        {
            
        }
    }
}

