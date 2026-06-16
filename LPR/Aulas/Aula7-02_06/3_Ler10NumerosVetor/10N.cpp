#include <iostream>
#include <vector>

using namespace std;

int main()
{
    //deixei tudo comentado pq to reaprendendo C++
//matriz que lera 10 numeros inteiros por meio de um vetor
//delimitação do tamanho do vetor
//int numeros[10];
int numeros[] = {1,2,3,4,5,6,7,8,9,10};
// é usado no lugar de um array comum porque ele é um vetor dinâmico(da para mudar o tamanho dps).
vector<int> impar;
vector<int> par;
//laço de repetição. ":"" significa dentro de. "SIm" recebera os valores
for(int SIm : numeros){
    if (SIm % 2 == 0) {
        //"."acessa as funcionalidades do vetor \\"push_back" insere um valor para lista
        par.push_back(SIm);
    }else{
        impar.push_back(SIm);
    }
}
    //todos do vetor
    cout << "Todos os numeros do vetor : ";
    for (int i : numeros){
        cout << i << " ";
    }



    //digita na tela
    cout << "n\\n Numeros impares: ";
    //cria novamente outro laço para colocar o resultado impares na tela.  ""as aspas server para dar espaço para os numeros
    for (int i : impar){
        cout << i << " ";
    }


    //digita na tela
    cout << "n\\n Numeros pares: ";
    //cria novamente outro laço para colocar o resultado pares na tela.
    for (int i : par){
        cout << i << " ";
    }

    //pula uma linha pra deixar o fim mais limpo
cout << "\\n";
return 0;
}