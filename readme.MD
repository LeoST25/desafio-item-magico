# Desafio

Em jogos de RPG, os jogadores frequentemente adquirem itens mágicos que possuem poderes e habilidades especiais. Neste desafio, você deve criar uma classe `ItemMagico` que represente um item mágico e seja capaz de armazenar o nome, descrição e poder do item.

## Requisitos

Crie a classe `ItemMagico` que possua os seguintes atributos: `nome`, `descricao` e `poder`. Além disso, a classe deve ter um método chamado `criar`, que recebe como argumento os valores do nome, descrição e poder do item, respectivamente.

## Entrada

A entrada será dada pela chamada do método `criar` da classe `ItemMagico`, utilizando o `io.read()` para obter os valores dos atributos de cada item:

- **nome**: nome do item
- **descricao**: descrição do item
- **poder**: poder do item

Importante: a entrada deverá ocorrer de acordo com a ordem das informações fornecidas acima.

## Saída

A saída deverá ser a impressão das informações do item criado, no formato:

- Nome: [nome do item]
- Descrição: [descrição do item]
- Poder: [poder]


## Exemplos

A tabela abaixo apresenta exemplos com alguns dados de entrada e suas respectivas saídas esperadas. Certifique-se de testar seu programa com esses exemplos e com outros casos possíveis.

### Entrada
- Espada Flamejante
- Uma espada de fogo!
- 50


### Saída
- Nome: Espada Flamejante
- Descrição: Uma espada de fogo!
- Poder: 50


### Entrada
- Anel Mágico
- Deixa o usuário invisível
- 5

### Saída
- Nome: Anel Mágico
- Descrição: Deixa o usuário invisível!
- Poder: 5

### Entrada
- Varinha Gelada
- Congela até pensamentos
- 8

### Saída
- Nome: Varinha Gelada
- Descrição: Congela até pensamentos
- Poder: 8