using System;
//criando a classe
public class Matricula
{
 public string matricula;
 public string Nome;
 public double Nota1;
 public double Nota2;
 public double atividade;
}
class Menu
{
    static void Main()
    {
     Matricula nAluno = new Matricula();
     Console.Clear(); 
     Console.WriteLine("O aluno está matriculado?[s/n]");
     nAluno.matricula = Console.ReadLine();
     if (nAluno.matricula == "s")
        {
     //pegado dados do cliente
     Console.WriteLine("____________________________________________________");
     Console.WriteLine("Digite seu nome");
     nAluno.Nome = Console.ReadLine();
     Console.WriteLine("____________________________________________________");
     Console.WriteLine("Digite sua primeira nota");
     nAluno.Nota1 = double.Parse(Console.ReadLine());
     Console.WriteLine("____________________________________________________");
     Console.WriteLine("Digite sua segunda nota");
     nAluno.Nota2 = double.Parse(Console.ReadLine());
     Console.WriteLine("____________________________________________________");
     Console.WriteLine("Digite sua nota do trabalho");
     nAluno.atividade = double.Parse(Console.ReadLine());
     Console.WriteLine("____________________________________________________");
     Console.Clear(); 
     //fazendo a media  com peso
     double media= ((nAluno.Nota1*2.5)+(nAluno.Nota2*2.5)+(nAluno.atividade*2))/(2.5+2.5+2);
     double sfinal= 100-media;
     if(sfinal < 60)
            {
              Console.WriteLine("____________________________________________________");
              Console.WriteLine("Sua media das notas com pesos aplicados: \n" +media);
              Console.WriteLine("Não precisa fazer prova final");
              Console.WriteLine("____________________________________________________");
            }
            else
            {
               Console.WriteLine("____________________________________________________");
               Console.WriteLine("Sua media das notas com pesos aplicados: \n" +media);
               Console.WriteLine("____________________________________________________");
               Console.WriteLine("Para sua prova final vc precisa de "+sfinal,"pts para passar."); 
               Console.WriteLine("____________________________________________________");
            }
        }else{
        Console.Clear(); 
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("porque voce esta tentando ver a nota que ele precisa então? :/");
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        }
    }
}