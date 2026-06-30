from sklearn.datasets import load_iris
from sklearn.model_selection import train_test_split
from sklearn.tree import DecisionTreeClassifier
from sklearn.metrics import accuracy_score

# 1. Carregando as flores
iris = load_iris()
X = iris.data  # Características: comprimento/largura da pétala e sépala
y = iris.target # Classes: 0 (Setosa), 1 (Versicolor), 2 (Virginica)

# 2. Dividindo os dados (80% para treino e 20% para teste)
# O random_state garante que o resultado seja o mesmo toda vez que você rodar
X_treino, X_teste, y_treino, y_teste = train_test_split(X, y, test_size=0.2, random_state=42)

# 3. Criando o modelo da Árvore de Decisão
modelo = DecisionTreeClassifier(random_state=42)

# 4. Treinando a IA
modelo.fit(X_treino, y_treino)

# 5. Fazendo previsões com os dados de teste que ela não conhecia
previsoes = modelo.predict(X_teste)

# 6. Avaliando o quão boa ela é
precisao = accuracy_score(y_teste, previsoes)

print(f"Treinamento concluído!")
print(f"A precisão do modelo foi de: {precisao * 100:.2f}%")