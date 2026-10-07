using System;

class Program
{
    static void Main()
    {
        // ========================================
        // CADASTRO DE DADOS PESSOAIS
        // ========================================

        string nomeCompleto;
        int idade;
        string cidade;
        double altura;

        // Entrada dos dados
        Console.Write("Digite seu nome: ");
        nomeCompleto = Console.ReadLine();

        Console.Write("Digite sua idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Digite sua cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Digite sua altura: ");
        altura = double.Parse(Console.ReadLine());

        Console.Clear();

        // Exibição dos dados
        Console.WriteLine("========================================");
        Console.WriteLine("         DADOS CADASTRADOS");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:    {nomeCompleto}");
        Console.WriteLine($"Idade:   {idade}");
        Console.WriteLine($"Cidade:  {cidade}");
        Console.WriteLine($"Altura:  {altura:F2} m");
        Console.WriteLine("========================================");
    }
}