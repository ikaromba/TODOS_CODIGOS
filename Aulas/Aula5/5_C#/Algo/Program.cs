using System;

namespace jedi
{
    class Progam
    {
        static void Main(string[] args)
        {
            bool oi = true;
            while (oi)
            {
                Console.WriteLine("-----------------JEdi_Treinamento----------------");
                Console.WriteLine("Digite o numero de horas de treinamento diario");
                string H = Console.ReadLine();
                int d = int.Parse(H);
                int Semanal = d*5;
                Console.WriteLine($"Seu valor {Semanal}");
                double mes = Semanal*4.5;
                Console.WriteLine($"Seu valor {mes}");
                double Falta = (1000-mes)/24;
                Console.WriteLine($"Para Voce completar o treinamento jedi precisara de {Falta}");
                // 1 mes=4,5
            }
        }
    }
}