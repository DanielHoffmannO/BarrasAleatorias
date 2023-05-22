# README

Bem-vindo ao programa de geração e organização de barras aleatórias em C#! Este programa foi desenvolvido para criar uma experiência visual interessante ao exibir barras geradas aleatoriamente, organizá-las em ordem crescente e, em seguida, embaralhá-las novamente. Vamos dar uma olhada em como executar e entender o funcionamento do programa.

## Descrição do Programa

Este programa é composto por várias partes que trabalham juntas para criar uma experiência envolvente de geração e organização de barras. Vamos analisar cada uma delas:

1. A constante `QuantidadeBarras` é usada para definir o número total de barras que serão geradas pelo programa. Por padrão, está definida como 26, mas você pode ajustá-la conforme desejar.

2. O método `Main` é o ponto de entrada do programa. É aqui que toda a ação acontece! Ele inicia chamando o método `GerarBarrasUnicas` para obter uma matriz de barras únicas e, em seguida, exibe essas barras geradas aleatoriamente no console. Depois disso, o programa entra em um loop contínuo até que uma tecla seja pressionada. Dentro desse loop, as barras são organizadas em ordem crescente usando o método `OrganizarBarras`. Depois de organizar as barras, há uma breve pausa para que você possa admirar o trabalho feito. Em seguida, as barras são embaralhadas usando o método `EmbaralharBarras` e o resultado é exibido no console.

3. O método `GerarBarrasUnicas` é responsável por gerar uma matriz de barras únicas aleatórias. Ele usa a classe `Random` para gerar números aleatórios e um `HashSet` para garantir que os tamanhos das barras sejam únicos. O método itera pela quantidade especificada de barras e, a cada iteração, gera um tamanho aleatório que não esteja presente no conjunto de tamanhos gerados anteriormente.

4. O método `MostrarBarras` é usado para exibir as barras no console. Ele determina o maior tamanho de barra na matriz de tamanhos e, em seguida, itera de cima para baixo por esse tamanho. Para cada nível, o método itera pelas barras e imprime uma barra vertical (`|`) se o

 tamanho da barra for maior ou igual ao nível atual. Isso cria a representação visual das barras no console.

5. O método `OrganizarBarras` implementa o algoritmo Bubble Sort para organizar os tamanhos das barras em ordem crescente. Ele começa definindo uma variável `ordenado` como falsa e entra em um loop enquanto essa variável for falsa. Dentro do loop, o método percorre a matriz de tamanhos e compara cada elemento com o próximo. Se um elemento for maior que o próximo, eles são trocados de posição. Durante cada troca, o console é limpo e as barras atualizadas são exibidas. Isso cria uma animação visual de como as barras estão sendo organizadas. Após cada iteração completa, a variável `ordenado` é verificada novamente para determinar se as barras estão completamente organizadas.

6. O método `EmbaralharBarras` usa o algoritmo Fisher-Yates para embaralhar aleatoriamente os tamanhos das barras. Ele percorre a matriz de tamanhos e, para cada elemento, seleciona um índice aleatório a partir do elemento atual até o final da matriz. Em seguida, troca o elemento atual com o elemento do índice aleatório. Isso garante um embaralhamento justo e aleatório das barras.

## Personalização

Você pode personalizar o programa para torná-lo ainda mais interessante e divertido. Aqui estão algumas sugestões:

- Experimente alterar o valor da constante `QuantidadeBarras` para gerar um número diferente de barras.
- Ajuste o tempo de pausa no método `OrganizarBarras` para controlar a velocidade da animação. Você pode aumentar ou diminuir o valor dentro do método `Thread.Sleep` para definir o tempo desejado em milissegundos.
- Explore outros algoritmos de ordenação e substitua o Bubble Sort no método `OrganizarBarras`. Você pode tentar usar o Insertion Sort, Merge Sort ou Quick Sort para ver como o programa se comporta.
- Adicione recursos adicionais, como permitir que o usuário especifique a quantidade de barras a serem geradas ou adicionar a opção de organizar as barras em ordem decrescente.

Divirta-se explorando e personalizando o programa! Sinta-se à vontade para fazer qualquer alteração que desejar e compartilhe suas versões modificadas com outras pessoas. Aproveite a experiência visual envolvente das barras aleatórias!
