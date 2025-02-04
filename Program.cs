﻿using System;

public class ItemMagico
{
    //TODO:  Crie a classe ItemMagico com os atributos nome, descrição e poder
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Poder { get; set; }
    
    public ItemMagico(string nome, string descricao, int poder)
    {
        Nome = nome;
        Descricao = descricao;
        Poder = poder;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Recebe a entrada do usuário

        Console.WriteLine("Digite o nome do item");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite a descrição do item");
        string descricao = Console.ReadLine();

        Console.WriteLine("Digite o poder do item");
        int poder = int.Parse(Console.ReadLine());

        // Cria o item mágico
        ItemMagico item = new ItemMagico(nome, descricao, poder);

        // Imprime o item criado
        Console.WriteLine($"Item: {item.Nome}\nDescrição: {item.Descricao}\nPoder: {item.Poder}");
    }
}
