#include <iostream>
#include <array>
#include <string>
//( using namespace std ) elimina a necessidade de colocar mais std::..
using namespace std;

struct Livro{
    string Titulo;
    string Autor;
    double Preco;
    int ano;
    int Npag;
    
};

int main(){

    // Cria uma lista (array) para guardar 3 livros
    array<Livro, 3> listaDeLivros;

    for( int i = 0; i<3;i++){

        cout << "digite o titulo do livro: " << endl;
        //(getline(cin, listaDeLivros[i].Titulo);) vai nomear o livro ate 3 e vai contar os espaços
        getline(cin, listaDeLivros[i].Titulo);

        cout << "digite o autor do livro: " << endl;
        getline(cin, listaDeLivros[i].Autor);
        cout << "digite o preco do livro: " << endl;
        cin >> listaDeLivros[i].Preco;
        cout << "digite o ano do livro: " << endl;
        cin >> listaDeLivros[i].ano;
        cout << "digite o numero de paginas do livro: " << endl;
        cin >> listaDeLivros[i].Npag;
    }

    double SOMa = 0.0;
    int Npagi = 0;

    //mostra os dados dos livros, alem do preço total deles e a media de pag
    for(int z = 0; z<3; z++){
        SOMa += listaDeLivros[z].Preco;
        Npagi += listaDeLivros[z].Npag;
    }

    cout << "\n---- Preco Total dos Livros ----" << endl;
    cout << SOMa << endl;
    cout << "\n---- Media de Paginas dos Livros ----" << endl;
    cout << (double)Npagi / 3 << endl;

}