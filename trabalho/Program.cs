using System;

class Program
{
    static int Bill()
    {
        Console.WriteLine("Nome: Bill \n Vida: 100 \n Força: 6 \n Agilidade: 4");
        int IBill = 8;
        return IBill;
    }

    static int General_Grievous()
    {
        Console.WriteLine("Nome: General Grievous \n Vida: 150 \n Força: 8 \n Agilidade: 6");
        int IGG = 6;
        return IGG;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Bem vindo ao rpg de Batalha");
        Console.WriteLine("Escolha seu personagem: \n 1 - Bill \n 2 - General Grievous");

        string escolha = Console.ReadLine();

        if (escolha == "1")
        {
            Console.WriteLine("Voce escolheu Bill");
            int IBill = Bill();
            int IGG = General_Grievous();
            int Contas = (IBill * 2) - (IGG * 2);

            Console.WriteLine("O resultado da batalha é: " + Contas);

            if (Contas > 0)
            {
                Console.WriteLine("Bill venceu!");
            }
            else if (Contas < 0)
            {
                Console.WriteLine("General Grievous venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
        else if (escolha == "2")
        {
            Console.WriteLine("Voce escolheu General Grievous");
            int IGG = General_Grievous();
            int IBill = Bill();
            int Contas = (IBill * 2) - (IGG * 2);

            Console.WriteLine("O resultado da batalha é: " + Contas);

            if (Contas > 0)
            {
                Console.WriteLine("Bill venceu!");
            }
            else if (Contas < 0)
            {
                Console.WriteLine("General Grievous venceu!");
            }
            else
            {
                Console.WriteLine("Empate!");
            }
        }
        else
        {
            Console.WriteLine("Escolha inválida!");
        }
    }
}