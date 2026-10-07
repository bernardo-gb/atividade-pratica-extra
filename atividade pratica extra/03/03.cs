using System;

class Program
{
    static void Main()
    {
        string nome;
        int codigo;
        string categoria;
        double preco;
        int quantidade;
        char inicialCategoria;
        bool disponivel;

        Console.WriteLine("========================================");
        Console.WriteLine("          CADASTRO DE PRODUTO");
        Console.WriteLine("========================================");

        Console.Write("Nome do produto: ");
        nome = Console.ReadLine();

        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Quantidade em estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.Write("Inicial da categoria: ");
        inicialCategoria = char.Parse(Console.ReadLine());

        Console.Write("Disponível para venda? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("             PRODUTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:                 {nome}");
        Console.WriteLine($"Código:               {codigo}");
        Console.WriteLine($"Categoria:            {categoria}");
        Console.WriteLine($"Preço:                R$ {preco:F2}");
        Console.WriteLine($"Quantidade:           {quantidade}");
        Console.WriteLine($"Inicial da categoria: {inicialCategoria}");
        Console.WriteLine($"Disponível:           {disponivel}");
        Console.WriteLine("========================================");
    }
}