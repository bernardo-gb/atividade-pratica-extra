using System;

class Program
{
    static void Main()
    {
        // INFORMAÇÕES IDENTIFICADAS:
        // 1. Nome
        // 2. Idade
        // 3. Cidade
        // 4. Cargo
        // 5. Salário
        // 6. Matrícula
        // 7. Funcionário ativo

        string nome;
        int idade;
        string cidade;
        string cargo;
        double salario;
        int matricula;
        bool ativo;

        Console.WriteLine("========================================");
        Console.WriteLine("       CADASTRO DE FUNCIONÁRIO");
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

        Console.Write("Funcionário ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        FUNCIONÁRIO CADASTRADO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:       {nome}");
        Console.WriteLine($"Idade:      {idade}");
        Console.WriteLine($"Cidade:     {cidade}");
        Console.WriteLine($"Cargo:      {cargo}");
        Console.WriteLine($"Salário:    R$ {salario:F2}");
        Console.WriteLine($"Matrícula:  {matricula}");
        Console.WriteLine($"Ativo:      {ativo}");
        Console.WriteLine("========================================");
    }
}