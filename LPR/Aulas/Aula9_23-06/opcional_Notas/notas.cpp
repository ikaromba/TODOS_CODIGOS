#include <iostream>
//para adicionar a função de lista de que colocar "#include <list>"
#include <list>
//adicionamos a bliblioteca #include <climits> para termos acesso aos numeros maximos e minimos
#include <climits>

using namespace std;

int main(){
// (nome).push_back(numero) ele so joga o numero para o final da lista 
int n1;
int maior = INT_MIN;
int menor = INT_MAX;
double soma = 0; //usamos doyuble para nao dar erro com numero quebrado/flutuante
//Criacao de uma lista de numero(int)
list<int>Nu;
//lop pra roda o code 5 vezes
for(int i  = 0; i<5; i++){
cout <<"Digite a nota" << endl;
cin >> n1;
Nu.push_back(n1);
}

//selecionar cada numero e separar para  ver qual e maior menor  e sua media
for (int numero : Nu ) {
//esse numero que se estabelece como novo padrao dps da primeira comparação
    if(numero > maior) {
        maior = numero;
    }
     if(numero < menor) {
        menor = numero;
    }

    soma += numero; // É o mesmo que: soma = soma + numero;
}
    double media = soma / Nu.size();
    cout << "MAior nota =  " << maior << endl;
    cout << "Menor nota =  " << menor << endl;
    cout << "Media so total das notas =  " << media << endl;

//Mostra todos os numero da lista
for (int num : Nu) {
    cout<<num<<" ";
   }
}