using System;

class Program
{
    static void Main()
    {
        string cliente;
        string equipamento;
        int codigo;
        int quantidadeDias;
        double valorLocacao;
        bool equipamentoDisponivel;

        Console.WriteLine("========================================");
        Console.WriteLine("          SISTEMA DE LOCAÇÃO");
        Console.WriteLine("========================================");

        Console.Write("Cliente: ");
        cliente = Console.ReadLine();

        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Código do equipamento: ");
        codigo = int.Parse(Console.ReadLine());

        Console.Write("Quantidade de dias: ");
        quantidadeDias = int.Parse(Console.ReadLine());

        Console.Write("Valor da locação: ");
        valorLocacao = double.Parse(Console.ReadLine());

        Console.Write("Equipamento disponível? (true/false): ");
        equipamentoDisponivel = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          DADOS DA LOCAÇÃO");
        Console.WriteLine("========================================");
        Console.WriteLine("CLIENTE");
        Console.WriteLine($"Nome: {cliente}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("EQUIPAMENTO");
        Console.WriteLine($"Equipamento:  {equipamento}");
        Console.WriteLine($"Código:       {codigo}");
        Console.WriteLine($"Dias:         {quantidadeDias}");
        Console.WriteLine($"Valor:        R$ {valorLocacao:F2}");
        Console.WriteLine($"Disponível:   {equipamentoDisponivel}");
        Console.WriteLine("========================================");
    }
}