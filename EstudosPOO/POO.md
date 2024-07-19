# Guia de POO com CSharp.

## Paradigma de Orientação a Objetos - 4 Pilares
Abstração

Encapsulamento - Modificadores de acesso / Esconder detalhes de implementação

Herança

Polimorfismo

## Modificadores de acesso 
public - O tipo ou membro pode ser acessado por qualquer outro código no mesmo assembly(projeto) ou em outro assembly(projeto) que faz referência a ele.

protected - O tipo ou membro pode ser acessado somente pelo código na mesma classe, classe filhas.

private - O tipo ou membro pode ser acessado somente pelo código na mesma classe.

internal - O tipo ou membro pode ser acessado por qualquer código no mesmo assembly(projeto), mas não de outro assembly(projeto).

## Classes e Objetos
Classe - Tipo de dado composto por membros (Propriedades = Variáveis, Métodos = Funções) é a base do objeto, onde se define as regras e a partir dela eu instâncio os objetos.

Objeto = Instância de uma classe / A criação de um objeto se dá através do operador new.

Métodos = Funções / Comportamentos de um objeto são traduzidos como métodos que podem ou não ter argumentos e podem ou não ter retorno. Argumentos = dado recebido e acessível dentro do corpo do método.

Propriedades = Variáveis

## Método construtor
Toda classe possui uma implementação padrão implícita do método construtor, mas nada nos impede de implementá-lo à nossa maneira, utilizamos o método construtor para especificar a maneira com que o objeto deve ser criado.

## Acessando Métodos e Atributos
O acesso aos atributos e métodos de um objeto se dá através do operador "."

