#include <iostream>
#include <array>
#include <string>
//( using namespace std ) elimina a necessidade de colocar mais std::..
using namespace std;

//lista dos herois
struct Heroi{
    string nome;
    string poder;
    int pontuacao;
};

int main(){
//delimita o tamanho do grupo A 5
    array<Heroi, 5> herois;

    //MENU N TERMINADO int SMenu = 0;
    

    //delimita o tamanho do grupo A 5
    for( int i = 0 ; i<5; i++){

        cout << "Digite o Nome do heroi que entrara na equipe: " << endl;
        //requisita a entrada herois para amazenar o novo dado
        getline(cin, herois[i].nome);

        cout << "digite o poder do seu heroi : " << endl;
        getline(cin, herois[i].poder);

        cout << "Digite a potuação do seu heroi: " << endl;
        cin >> herois[i].pontuacao;
        //para nao ter problemas com getline
        cin.ignore();
    }

    //lista dos herois criados nomes
    cout << "-----------------------------------------------" << endl;
    //mostra os herois conforme o que forem digitados
    for( int i = 0 ; i<5; i++){
        //i+1 ira mosstrar a posição dp heroi na lista
        cout << "Heroi " << i+1 << ": " << herois[i].nome << endl;
    }
    cout << "-----------------------------------------------" << endl;

    //criando um array para amazenar os herois que serao selecionados
    array<Heroi, 3 > equipe;
    //Seleção de uma equipe de 3 herois
    for ( int o = 0; o<3; o++){
    int posicao;
    cout << "Selecione a posição do heroi desejado: " << endl;
    cin >> posicao;
    //limpar o bufffer
    cin.ignore();

    //verificação para o progamar nao bugar aaso degite um numero invalido
   if(posicao >= 1 && posicao <= 5){
    //para deixar da forma "nomrl" para o ususario
    int indice = posicao - 1;
    cout << " ----Heroi Selecionados----" << endl;
//dados que estavam selecionados no novo array do time
    equipe[o] = herois[indice];
 } else{
    cout << " Digite um numero de um a cinco" << endl;
 }
}
//Lista dos membros do time
cout << "-------------------------------" << endl;
cout << "Equipe selecionada"<< endl;
for(int t = 0; t < 3; t++){
    cout << "Nome: " << equipe[t].nome << endl;
    cout << "Poder: " << equipe[t].poder << endl;
    cout << "pontuação:" << equipe[t].pontuacao << endl;
    cout << "-------------------------------" << endl;
}
int power = equipe[0].pontuacao + equipe[1].pontuacao + equipe[2].pontuacao;
cout << "Poder total da equipe "<< power << endl;

}