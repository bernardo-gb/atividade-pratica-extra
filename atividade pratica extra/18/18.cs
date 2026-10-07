using System;

class Program
{
    static void Main()
    {
        string placa;
        string modelo;
        string cor;
        int ano;
        int numeroVaga;
        double valor;
        bool estacionamentoAtivo;

        Console.WriteLine("========================================");
        Console.WriteLine("       SISTEMA DE ESTACIONAMENTO");
        Console.WriteLine("========================================");

        Console.Write("Placa: ");
        placa = Console.ReadLine();

        Console.Write("Modelo do veículo: ");
        modelo = Console.ReadLine();

        Console.Write("Cor: ");
        cor = Console.ReadLine();

        Console.Write("Ano: ");
        ano = int.Parse(Console.ReadLine());

        Console.Write("Número da vaga: ");
        numeroVaga = int.Parse(Console.ReadLine());

        Console.Write("Valor da permanência: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Estacionamento ativo? (true/false): ");
        estacionamentoAtivo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       REGISTRO DO ESTACIONAMENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Placa:        {placa}");
        Console.WriteLine($"Modelo:       {modelo}");
        Console.WriteLine($"Cor:          {cor}");
        Console.WriteLine($"Ano:          {ano}");
        Console.WriteLine($"Vaga:         {numeroVaga}");
        Console.WriteLine($"Valor:        R$ {valor:F2}");
        Console.WriteLine($"Situação:     {estacionamentoAtivo}");
        Console.WriteLine("========================================");
    }
}