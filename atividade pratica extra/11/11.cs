using System;

class Program
{
    static void Main()
    {
        int identificacaoCliente;
        string nome;
        int idade;
        string cidade;
        string motivo;
        int codigoAtendimento;
        bool concluido;

        Console.WriteLine("========================================");
        Console.WriteLine("        SISTEMA DE ATENDIMENTO");
        Console.WriteLine("========================================");

        Console.Write("Identificação do cliente: ");
        identificacaoCliente = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Motivo do atendimento: ");
        motivo = Console.ReadLine();

        Console.Write("Código do atendimento: ");
        codigoAtendimento = int.Parse(Console.ReadLine());

        Console.Write("Atendimento concluído? (true/false): ");
        concluido = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        FICHA DE ATENDIMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cliente:       {identificacaoCliente}");
        Console.WriteLine($"Nome:          {nome}");
        Console.WriteLine($"Idade:         {idade}");
        Console.WriteLine($"Cidade:        {cidade}");
        Console.WriteLine($"Motivo:        {motivo}");
        Console.WriteLine($"Atendimento:   {codigoAtendimento}");
        Console.WriteLine($"Concluído:     {concluido}");
        Console.WriteLine("========================================");
    }
}