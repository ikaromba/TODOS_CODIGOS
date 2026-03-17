using System;

class Program
{
       static void Passaro_Domestico()
{
if (Reposta("É verde e fala? (s/n): "))
 {
  Console.WriteLine("Resultado: Papagaio");
  } else if (Reposta("Tem uma mancha laranja na bochecha? (s/n): "))
    {
     Console.WriteLine("Resultado: Calopsita");
    }else if (Reposta("É pequeno e colorido? (s/n): "))
    {
        Console.WriteLine("Resultado: Periquito Australiano");
    }else
    {
        Console.WriteLine("Resultado: Pássaro desconhecido");
    }
}

     static void Passaro_Selvagem()
{
    Console.WriteLine("Ele é um passaro selvagem");
    if (Reposta("É um predador noturno que imata um tronco? (s/n): "))
 {
  Console.WriteLine("Resultado: Urutau");
  }else 
    {
      if (Reposta("Ele tem olhos grandes? (s/n): "))
        {
            Console.WriteLine("Resultad: Coruja");
        }else if (Reposta("Ele é conhecido por dar rasante no ar? (s/n): "))
        {
            Console.WriteLine("Resultado: Falcao");
        }else
        {
            Console.WriteLine("Resultado: Passaro indefinido");
        }
    }
}
      static bool Reposta(string Pergunta)
{    
    Console.WriteLine( Pergunta);
    string resposta = Console.ReadLine().ToLower();//O programa pausa, lê o que o usuário digitou e já converte para minúsculas (para evitar erros com "SIM" ou "Sim").
    return (resposta == "s"); //Se for S a resposta enviara true para a função boll 
}
    static void Main()
    {
    The_Big_Bird();
    Console.WriteLine("-------- Identificador de Pássaros --------");
//sei que a palavra "reposta" ta errada
    if (Reposta("O pássaro é de estimação? (s/n): "))
        {
            Passaro_Domestico();
        }else
        {
            Passaro_Selvagem();
        }
    }

    static void The_Big_Bird()
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
    }
}