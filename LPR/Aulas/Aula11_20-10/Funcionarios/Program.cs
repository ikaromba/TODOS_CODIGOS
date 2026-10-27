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
      Console.Clear(); 

      if(nfun.Salario <= 2000)
    {
      double Tax = (nfun.Salario * 0.10);
      double SalFinal = nfun.Salario + Tax;
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine(nfun.Nome+ " voce teve uma aumento no seu salrio de 10%");
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Salario sem o bônus de 10%: \n" +nfun.Salario );
       Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Com o bõnus de 10%: \n"+ SalFinal);
      Console.WriteLine("_____________________________________________________________________");
    }
    if(nfun.Salario >= 2001 && nfun.Salario <=3000)
    {
      double Tax = (nfun.Salario * 0.15);
      double SalFinal = nfun.Salario + Tax;
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine(nfun.Nome+ " voce teve uma aumento no seu salrio de 15%");
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Salario sem o bônus de 15%: \n" +nfun.Salario );
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Com o bõnus de 15%: \n"+ SalFinal);
      Console.WriteLine("_____________________________________________________________________");
    }if(nfun.Salario > 3000)
    {
      double Tax = (nfun.Salario * 0.20);
      double SalFinal = nfun.Salario + Tax;
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine(nfun.Nome+ " voce teve uma aumento no seu salrio de 20%");
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Salario sem o bônus de 20%: \n" +nfun.Salario );
      Console.WriteLine("_____________________________________________________________________");
      Console.WriteLine("Com o bõnus de 20%: \n"+ SalFinal);
      Console.WriteLine("_____________________________________________________________________");
    }
      
    }
}