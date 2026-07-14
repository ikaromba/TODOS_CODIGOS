#include <iostream>
//para adicionar a função de lista de que colocar "#include <list>"
#include <list>
//adicionamos a bliblioteca #include <climits> para termos acesso aos numeros maximos e minimos
#include <climits>

using namespace std;

int main(){
    //criando uma lista de nomes<string>
    list<string> NOmes = {"Ikaro","Jao","Fred","Juan","Robertinho","Marlet"};
    
    cout << "Digite 0 para sair do modo adicvionar nomes" << endl;
    while (true) {
    //adicionar nomes a NOmes
    cout << " Digite o nome que deseja adicionar a lista : " << endl;
    cin >> NOmes.emplace_back();
    if (NOmes.back() == "0") {
        // Remove o último elemento (0) da lista
        NOmes.pop_back(); 
        break; 
    }
    }
    
    // Se o tamanho de 'a' for menor que o de 'b', 'a' vem antes.
    NOmes.sort([](const string& a, const string& b) {
        return a.size() < b.size();
    });

    // 'Criamos uma estrutura para guardar as nossas "linhas de exibição"
    // 'Cada linha será uma lista de nomes
    vector<list<string>> linhasDeSaida;

    // 'Distribuímos os nomes seguindo a ordem de digitação
    for (const string& nome : NOmes) {
        if (nome.empty()) continue;
    //esssas duas variaves tamanhoanterior e primeiro nome serve para nao começar com um vazio na primira linha
    //entao se cria um bool para funcionar como uma trava quer vai se romper quando mudada de estado
    size_t tamanhoNome = nome.size();
    bool adicionar = true;

    //o for percorrera o cada nome da lista
    for (const string& nome : NOmes){
        //if(nome.size() <= 1) continue;

        if(adicionar){
            cout << "Nomes " << nome << endl;
            adicionar = false;
        } 
        else if(nome.size() == tamanhonome){
        //pula para linha dbaixo
        cout<<nome<<endl;
        }else {
            //linha vazia
            cout<<endl;
            cout << "Nomes " << nome << endl;
            tamanhoAnterior = nome.size();
        }
        
    }
    return 0;
}