using System;

class Produto
{
    public string Nome {get;set;}
    public double preco {get;set;}
}
class Pedido
{
    //interligando a classe Pesido a classe Produto
 public Produto p = new Produto();
 public int quantidade;
}
class Menu
{
    static void Main()
    {
        Console.Clear();
        Pedido nid = new Pedido();
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.WriteLine("Digite o nome do produto do seu pedido: ");
        nid.p.Nome = Console.ReadLine();
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine("Digite o preço do produto do seu pedido: ");
        nid.p.preco = double.Parse(Console.ReadLine());
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine("Digite a quantidade do produto para seu pedido: ");
        double sim = double.Parse(Console.ReadLine());
        // não precisa de double
        Console.WriteLine("XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX");
        Console.Clear();
        double conta = sim*nid.p.preco ; 
        //quantidade pre-definida
        nid.quantidade = 12;
        Console.WriteLine("___________________________________________________________________");
        Console.WriteLine("Produto: "+ nid.p.Nome+"\nQuantidade no estoque: "+ nid.quantidade+ "           Quantidade Solicitada: "+ sim);
        Console.WriteLine("__________________________________________________________________");
        Console.WriteLine("O preço Total: "+ conta);
        Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVV");
    }
}
