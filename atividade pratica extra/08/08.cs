using System;

class Program
{
    static void Main()
    {
        string titulo;
        string autor;
        int ano;
        int codigo;
        double preco;
        string categoria;
        bool disponivel;

        Console.WriteLine("========================================");
        Console.WriteLine("         BIBLIOTECA DIGITAL");
        Console.WriteLine("========================================");

        Console.Write("Título: ");
        titulo = Console.ReadLine();

        Console.Write("Autor: ");
        autor = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Código: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Disponível para empréstimo? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("             LIVRO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Título:       {titulo}");
        Console.WriteLine($"Autor:        {autor}");
        Console.WriteLine($"Ano:          {ano}");
        Console.WriteLine($"Código:       {codigo}");
        Console.WriteLine($"Preço:        R$ {preco:F2}");
        Console.WriteLine($"Categoria:    {categoria}");
        Console.WriteLine($"Disponível:   {disponivel}");
        Console.WriteLine("========================================");
    }
}