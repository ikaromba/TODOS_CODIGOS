using System;
public class Funcionarios
{
     public string Nome;
     public double Salario;
     public double Imposto;
}
class Menu {
  static void Main()
    {
      Funcionarios nfun = new Funcionarios();
      Console.WriteLine("Digite seu nome: ");
      nfun.Nome = Console.ReadLine();
      Console.WriteLine("Digite seu salário: ");
      nfun.Salario = double.Parse(Console.ReadLine());
      




      //Console.WriteLine("Digite o valor do imposto: ");
      //nfun.Imposto = double.Parse(Console.ReadLine());
    }
}