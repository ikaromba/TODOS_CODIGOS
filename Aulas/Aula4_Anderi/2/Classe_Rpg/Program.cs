using System;

namespace Classe_RPG
{
    class Program
    {
        static void Classe_RPG(int escolha)
        {
            switch (escolha)
            {
            case 1:
            Console.WriteLine("Voce será um Guerreiro ");
            Console.WriteLine("Caracteristicas: \n Ataque Pesado \n Muita vida \n alta defesa");
            break;

            case 2:
            Console.WriteLine("Voce será um Mago ");
            Console.WriteLine("Caracteristicas: \n Bolas de fogo \n estaca de gelo \n Baixa vida");
            break;

            case 3:
            Console.WriteLine("Voce será um Arqueiro ");
            Console.WriteLine("Caracteristicas: \n Precisão \n Alta esquiva \n Baixa vida");
            break;
            default:
            Console.WriteLine("Classe Inexistente");
            break;
            }
        }
         static void Raca_RPG(int escolhaa)
        {
            switch (escolhaa)
            {
                case 1:
                Console.WriteLine("Sua raça será Humano");
                break;
                case 2:
                Console.WriteLine("Sua raça será orc");
                break;
                case 3:
                Console.WriteLine("Sua raça será Elfo");
                break;
                case 4:
                Console.WriteLine("Sua raça será Aarakocra");
                break;
                default:
                Console.WriteLine("raça Inexistente");
                break;
            }
        }


         static void Main(string[] args)
         {
            Console.WriteLine("--------RPG--------");
            Console.WriteLine("Digite O nome do seu personagem: ");
            string name = Console.ReadLine();

            Console.WriteLine("Digite a classe de seu personagem: ");
            Console.WriteLine("1- Guerriro \n 2- Mago \n 3- Arqueiro");
            int escolha = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite qual raça seu personagem será: ");
            Console.WriteLine("1- Humano \n 2- Orc \n 3- Elfo \n 4- Aarakocra");
            int escolhaa = int.Parse(Console.ReadLine());

            Console.WriteLine($"Nome: {name}");

            Classe_RPG(escolha);

            Console.WriteLine("-------------------");

            Raca_RPG(escolhaa);

            Console.WriteLine("-------------------");

            Console.WriteLine("Personagem Criado");
         }
    }
}