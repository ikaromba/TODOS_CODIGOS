#include <iostream>
#include <vector>

int main() {
    // Em C++, o std::cout é o equivalente ao Console.WriteLine
    std::cout << "Leitor de 10 numeros, idetificara os numeros pares e imapres\n";

    // Criando o vetor em C++ (equivalente ao int[] do C#)
    std::vector<int> N = {10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

    std::cout << "Todos os numeros:\n";
    
    // deixa visivel os nuemros dos vetores N (Equivalente ao foreach do C#)
    for (int numero : N) {
        std::cout << numero << " ";
    }
    std::cout << "\n\n"; // Quebra de linha para organizar

    std::cout << "Numeros pares:\n";
    for (size_t i = 0; i < N.size(); i++) {
        if (N[i] % 2 == 0) {
            std::cout << N[i] << "\n";
        }
    }

    std::cout << "Numeros impares:\n";
    for (size_t i = 0; i < N.size(); i++) {
        if (N[i] % 2 != 0) {
            std::cout << N[i] << "\n";
        }
    }

    std::cout << "Fim do Code\n";

    return 0; // Indica que o programa terminou com sucesso
}