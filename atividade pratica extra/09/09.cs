using System;

class Program
{
    static void Main()
    {
        string identificacao;
        int idade;
        string cidade;
        int codigo;
        bool ativo;

        Console.WriteLine("========================================");
        Console.WriteLine("          CADASTRO DE CLIENTE");
        Console.WriteLine("========================================");

        Console.Write("Nome ou identificação: ");
        identificacao = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Código do cliente: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Cliente ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          FICHA DO CLIENTE");
        Console.WriteLine("========================================");
        Console.WriteLine($"Identificação: {identificacao}");
        Console.WriteLine($"Idade:         {idade}");
        Console.WriteLine($"Cidade:        {cidade}");
        Console.WriteLine($"Código:        {codigo}");
        Console.WriteLine($"Situação:      {ativo}");
        Console.WriteLine("========================================");
    }
}