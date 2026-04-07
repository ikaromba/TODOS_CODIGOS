using System;
using System.Security.Cryptography.X509Certificates;

namespace Marvel
{
    class Progam
    {
        static void Main(string[] args)
        {//colocar variaveis "para sempre" aqui
            Menu();


        }


        static void Menu()
        {
           Console.WriteLine("---------MAEVER---------");
           //criar lista de opções
           Console.WriteLine("1-Cadrastro de Herois");
           Console.WriteLine("2-Seleção de equipes");
           Console.WriteLine("3-Exibição de equipe e pontuação");
           Console.WriteLine("0-Sair");
           Console.WriteLine("------------------------");
           Console.WriteLine("Digite a opção desejada: ");
           string opcao = Console.ReadLine();
           int contador = 0;

            switch (opcao)
            {
                case "1":
                //(feito)limitar a quantidade de vezes que chama a função ate 5 [limitar nao esta funcionando pq esta executando dentro da logica e tem que ser amarzenado fora mais da erro]
                
                while (contador < 5)
                    {
                    static List<CadastrarHeroi> listadeherois = new List<CadastrarHeroi>();   
                    }
                break;

                case "2":
                //funçao de montar equipe
                Equipe();
                break;

                case "3":
                //funçao de mostrar equipe e pontos
                break;

                case "0":
                //fim bird?
                break;

                default:
                Console.WriteLine("Opção invalida");
                break;
            }
        }
        
        static void CadastrarHeroi()
        {
            Console.WriteLine("Digite o nome do heroi: ");
            string Name = Console.ReadLine();
            Console.WriteLine("Digite o poder do heroi");
            string Poder = Console.ReadLine();
            Console.WriteLine("Digite a pontuação do heroi");
            string pontos = Console.ReadLine();
            int pontuação = int.Parse(pontos);
            Menu();
        }

        static void Equipe()
        {
            Console.WriteLine("Digite o nome de tres herois para sua equipe: ");
            

        }
    }
}