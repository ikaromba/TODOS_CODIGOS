import math # Trazendo a matemática para o Python

# 1. A NOSSA BASE DE DADOS (Dataset)
# Formato: [Peso (gramas), Tamanho (cm), "Nome do passaro"]
dados_Passaros = [
    [5, 1.6, "beija-flor-Abelha"],
    [5.5, 1.7, "beija-flor-Abelha"],
    [6, 2, "beija-flor-Abelha"],

    [14, 24, "Pardal-domestico"],
    [16, 28, "Pardal-domestico"],
    [18, 40, "Pardal-domestico"],

    [22, 60, "Bem-te-vi"],
    [24, 65, "Bem-te-vi"],
    [25, 68, "Bem-te-vi"],

    [29, 240, "Pombo-comum"],
    [30, 260, "Pombo-comum"],
    [37, 380, "Pombo-comum"],

    [210, 1000, "Avestruz"],
    [250, 1200, "Avestruz"],
    [280, 1500, "Avestruz"]


]

# 2. A FÓRMULA DE DISTÂNCIA (Teorema de Pitágoras)
def calcular_distancia(x1, y1, x2, y2):
    # Distância = Raiz Quadrada de ((x2 - x1)² + (y2 - y1)²)
    conta = ((x2 - x1) ** 2) + ((y2 - y1) ** 2)
    #print(f"Calcular distancia entre ({x1}, {y1}) e ({x2}, {y2}): {conta}")
    return math.sqrt(conta)

# 3. O CÉREBRO DA NOSSA IA
def classificar_Bird(novo_peso, novo_tamanho, base_de_dados):
    menor_distancia = 999999.0 # Começamos com um número gigante
    melhor_resposta = ""

    # A IA vai "olhar" para cada fruta que ela já conhece na lista
    for  passaro in base_de_dados:
        peso_conhecido = passaro[1]
        tamanho_conhecido = passaro[0]
        nome_conhecido = passaro[2]

        # Calcula a distância geométrica entre a fruta nova e a conhecida
        dist = calcular_distancia(novo_peso, novo_tamanho, peso_conhecido, tamanho_conhecido)

        # Se essa distância for a menor que já vimos, atualizamos a resposta!
        if dist < menor_distancia:
            menor_distancia = dist
            melhor_resposta = nome_conhecido
            
    return melhor_resposta

# --- TESTANDO A IA ---
print("--- IA DE CLASSIFICAÇÃO GEOMÉTRICA ---")
tamanho_misterioso = float(input("Digite o tamanho da fruta misteriosa (cm): "))
peso_misterioso = float(input("Digite o peso da fruta misteriosa (g): "))
resultado = classificar_Bird(peso_misterioso, tamanho_misterioso, dados_Passaros)
print(f"\n=> Pela distância matemática, a IA deduziu que é um(a): {resultado}!")
