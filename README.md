README
Este é um programa simples escrito em C# que gera e organiza barras aleatórias. Ele exibe as barras geradas aleatoriamente, organiza as barras em ordem crescente e, em seguida, embaralha as barras novamente.

Executando o Programa
Certifique-se de ter o ambiente de desenvolvimento adequado configurado para compilar e executar programas C#.

Copie o código-fonte fornecido e cole-o em um novo arquivo chamado Program.cs.
Compile o programa usando o compilador C# ou um ambiente de desenvolvimento integrado (IDE) compatível.
Execute o programa compilado. Você deve ver a saída no console.
Descrição do Programa
O programa consiste nas seguintes partes:

A constante QuantidadeBarras define o número total de barras a serem geradas.
O método Main é o ponto de entrada do programa. Ele gera as barras, exibe as barras geradas aleatoriamente, organiza as barras em ordem crescente e, em seguida, embaralha as barras novamente. O loop continua até que uma tecla seja pressionada.
O método GerarBarrasUnicas gera uma matriz de barras únicas aleatórias. Ele evita a repetição de tamanhos de barras usando um objeto HashSet.
O método MostrarBarras exibe as barras no console. Ele itera sobre os tamanhos das barras e imprime uma barra vertical (|) se o tamanho for maior ou igual ao nível atual.
O método OrganizarBarras organiza os tamanhos das barras em ordem crescente usando o algoritmo Bubble Sort. Ele exibe as barras após cada troca e aguarda um curto período de tempo para criar uma animação visual.
O método EmbaralharBarras embaralha os tamanhos das barras aleatoriamente usando o algoritmo Fisher-Yates. Ele percorre a matriz de tamanhos e troca cada elemento com outro elemento aleatório.
Personalização
Você pode personalizar o programa de várias maneiras:

Altere a constante QuantidadeBarras para ajustar o número total de barras geradas.
Modifique o tempo de espera no método OrganizarBarras para ajustar a velocidade da animação.
Experimente outros algoritmos de ordenação para substituir o Bubble Sort no método OrganizarBarras.
Adicione recursos adicionais, como permitir que o usuário especifique a quantidade de barras ou a capacidade de organizar as barras em ordem decrescente.
Divirta-se explorando e personalizando o programa!




