using System;

class Program
{
    static void Main()
    {
        string marca;
        string modelo;
        int ano;
        double preco;
        string categoria;
        char inicialMarca;
        bool disponivel;

        Console.WriteLine("========================================");
        Console.WriteLine("         CADASTRO DE VEÍCULO");
        Console.WriteLine("========================================");

        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine());

        Console.Write("Categoria: ");
        categoria = Console.ReadLine();

        Console.Write("Primeira letra da marca: ");
        inicialMarca = char.Parse(Console.ReadLine());

        Console.Write("Disponível para venda? (true/false): ");
        disponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("           VEÍCULO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Marca:       {marca}");
        Console.WriteLine($"Modelo:      {modelo}");
        Console.WriteLine($"Ano:         {ano}");
        Console.WriteLine($"Preço:       R$ {preco:F2}");
        Console.WriteLine($"Categoria:   {categoria}");
        Console.WriteLine($"Inicial:     {inicialMarca}");
        Console.WriteLine($"Disponível:  {disponivel}");
        Console.WriteLine("========================================");
    }
}