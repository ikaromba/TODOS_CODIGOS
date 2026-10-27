using System;
public class Triangulo
{
    public double altura;
     public double largura;
}
class Menu {
  static void Main() {
    //criando um triangulo para aa categoria
    Triangulo ntri = new Triangulo();
    //atribuindo os valores a altura e largura
    Console.WriteLine("Digite a altura do trianfgulo: ");
     ntri.altura = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite a largura do trianfgulo: ");
    ntri.largura = double.Parse(Console.ReadLine());
    
    //calculo para descobrir a area do triangulo
    double Area = (ntri.altura * ntri.largura) / 2;
    
    //calculando o perimetro do triangulo
    double Perimetro = ntri.altura + ntri.largura + Math.Sqrt(Math.Pow(ntri.altura, 2) + Math.Pow(ntri.largura, 2));
   
    //menu/resposta
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("A area do trinagulo é: " + Area);
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("O Perimetro do triangulo é: "+ Perimetro);
    Console.WriteLine("_____________________________________________________");
    Console.WriteLine("Altura do triangulo: " +ntri.altura);
    Console.WriteLine("Largura do triangulo: " + ntri.largura);
    Console.WriteLine("_____________________________________________________");
  }
}