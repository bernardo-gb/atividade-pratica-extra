using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        double altura;
        char inicial;
        bool matriculado;

        Console.WriteLine("========================================");
        Console.WriteLine("        CADASTRO DE ALUNO");
        Console.WriteLine("========================================");

        Console.Write("Nome completo: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Primeira letra do nome: ");
        inicial = char.Parse(Console.ReadLine());

        Console.Write("Está matriculado? (true/false): ");
        matriculado = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("           FICHA DO ALUNO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:        {nome}");
        Console.WriteLine($"Idade:       {idade}");
        Console.WriteLine($"Cidade:      {cidade}");
        Console.WriteLine($"Altura:      {altura:F2} m");
        Console.WriteLine($"Inicial:     {inicial}");
        Console.WriteLine($"Matriculado: {matriculado}");
        Console.WriteLine("========================================");
    }
}