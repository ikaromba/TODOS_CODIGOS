#include <iostream>
// Para adicionar a função de lista temos que colocar "#include <list>"
#include <list>
// Adicionamos a biblioteca <vector> para podermos usar o vector
#include <vector>
// Adicionamos a biblioteca <string> para podermos usar string de forma segura
#include <string>
// Adicionamos a biblioteca <climits> para termos acesso aos números máximos e mínimos
#include <climits>

using namespace std;

int main() {
    // Criando uma lista de nomes inicial
    list<string> NOmes = {"Ikaro", "Jao", "Fred", "Juan", "Robertinho", "Marlet"};
    
    cout << "Digite 0 para sair do modo adicionar nomes" << endl;
    while (true) {
        // Adicionar nomes a NOmes
        cout << " Digite o nome que deseja adicionar a lista : " << endl;
        NOmes.emplace_back();
        cin >> NOmes.back();
        if (NOmes.back() == "0") {
            // Remove o último elemento (0) da lista
            NOmes.pop_back(); 
            break; 
        }
    }
    
    vector<list<string>> linhasDeSaida;

    
    for (const string& nome : NOmes) {
        if (nome.empty()) continue;

        size_t tamanhoNome = nome.size();
        bool adicionado = false; 

        // ,
        for (auto& linha : linhasDeSaida) {
            bool jaTemEsseTamanho = false;
            for (const string& n : linha) {
                if (n.size() == tamanhoNome) {
                    jaTemEsseTamanho = true;
                    break;
                }
            }

            //,
            if (!jaTemEsseTamanho) {
                linha.push_back(nome);
                adicionado = true;
                break;
            }
        }

        
        if (!adicionado) {
            list<string> novaLinha;
            novaLinha.push_back(nome);
            linhasDeSaida.push_back(novaLinha);
        }
    }

    // Ordenar cada linha individualmente por tamanho
    for (auto& linha : linhasDeSaida) {
        linha.sort([](const string& a, const string& b) {
            return a.size() < b.size();
        });
    }

    // Exibição dos resultados no terminal seguindo a formatação correta
   
for (const auto& linha : linhasDeSaida) {
        bool primeiroDaLinha = true;
        for (const string& nome : linha) {
            if (!primeiroDaLinha) {
                cout << ", "; // Separa os nomes da mesma linha por vírgula
            }
            cout << nome;
            primeiroDaLinha = false;
        }
        cout << endl; // Final da linha, pula para a próxima
    }

    return 0;
}