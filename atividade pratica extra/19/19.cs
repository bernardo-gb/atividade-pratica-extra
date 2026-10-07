using System;

class Program
{
    static void Main()
    {
        // ========================================
        // SISTEMA PROFISSIONAL
        // CADASTRO DE FUNCIONÁRIOS
        // ========================================

        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        int matricula;
        string setor;
        bool ativo;

        // Entrada dos dados
        Console.WriteLine("========================================");
        Console.WriteLine("     CADASTRO DE FUNCIONÁRIO");
        Console.WriteLine("========================================");

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Cargo: ");
        cargo = Console.ReadLine();

        Console.Write("Salário: ");
        salario = double.Parse(Console.ReadLine());

        Console.Write("Matrícula: ");
        matricula = int.Parse(Console.ReadLine());

        Console.Write("Setor: ");
        setor = Console.ReadLine();

        Console.Write("Funcionário ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        // Saída dos dados
        Console.WriteLine("========================================");
        Console.WriteLine("       FUNCIONÁRIO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:       {nome}");
        Console.WriteLine($"Idade:      {idade}");
        Console.WriteLine($"Cidade:     {cidade}");
        Console.WriteLine($"Cargo:      {cargo}");
        Console.WriteLine($"Salário:    R$ {salario:F2}");
        Console.WriteLine($"Matrícula:  {matricula}");
        Console.WriteLine($"Setor:      {setor}");
        Console.WriteLine($"Ativo:      {ativo}");
        Console.WriteLine("========================================");
    }
}