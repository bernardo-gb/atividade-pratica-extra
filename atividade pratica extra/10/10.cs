using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string email;
        string telefone;
        string escolaridade;
        bool trabalha;

        Console.WriteLine("========================================");
        Console.WriteLine("     INSCRIÇÃO - DESENVOLVIMENTO");
        Console.WriteLine("========================================");

        Console.Write("Nome completo: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("E-mail: ");
        email = Console.ReadLine();

        Console.Write("Telefone: ");
        telefone = Console.ReadLine();

        Console.Write("Escolaridade: ");
        escolaridade = Console.ReadLine();

        Console.Write("Trabalha? (true/false): ");
        trabalha = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        INSCRIÇÃO REALIZADA");
        Console.WriteLine("========================================");
        Console.WriteLine("DADOS DO CANDIDATO");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine($"Nome:         {nome}");
        Console.WriteLine($"Idade:        {idade}");
        Console.WriteLine($"Cidade:       {cidade}");
        Console.WriteLine($"E-mail:       {email}");
        Console.WriteLine($"Telefone:     {telefone}");
        Console.WriteLine($"Escolaridade: {escolaridade}");
        Console.WriteLine($"Trabalha:     {trabalha}");
        Console.WriteLine("========================================");
    }
}