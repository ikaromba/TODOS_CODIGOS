#include <iostream>
#include <array>
//( using namespace std ) elimina a necessidade de colocar mais std::..
using namespace std;
//Crindo o struct
 struct Produto{
     string Nome;
     //double é usado para casa decimais 
     double Codigo;
     double Preco;
     int Quantidade;
 };
 
int main()
{
    //definindo um vetor para amazenar os dados dos produtos
    array<Produto,3>Loja;
    //incerindo os dados
    Loja[0]={"Comida de calopisita",1105,10.50,10};
    Loja[1]={"Puleiro",2205,35.99,4};
    Loja[2]={"calopisita",5050,4.01,150};
    
    //Soma do valor total de produto em estoque
    
    double PEstoque = 0.0;

    for(int i = 0; i<3;i++){
       PEstoque = Loja[i].Preco * Loja[i].Quantidade;
    }
    //Mostrar o valor da soma do estoque no console
    cout << " Valor da soma do estoque: " << PEstoque << endl;

    return 0;
}