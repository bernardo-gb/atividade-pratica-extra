using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        double altura;
        string curso;
        bool ativo;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Está ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.WriteLine("\n========================================");
        Console.WriteLine("           ALUNO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:   {nome}");
        Console.WriteLine($"Idade:  {idade}");
        Console.WriteLine($"Cidade: {cidade}");
        Console.WriteLine($"Altura: {altura:F2}");
        Console.WriteLine($"Curso:  {curso}");
        Console.WriteLine($"Ativo:  {ativo}");
        Console.WriteLine("========================================");
    }
}