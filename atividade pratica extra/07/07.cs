using System;

class Program
{
    static void Main()
    {
        string equipamento;
        string marca;
        string modelo;
        int anoAquisicao;
        double valor;
        int patrimonio;
        bool funcionando;

        Console.WriteLine("========================================");
        Console.WriteLine("       ETIQUETA DE PATRIMÔNIO");
        Console.WriteLine("========================================");

        Console.Write("Equipamento: ");
        equipamento = Console.ReadLine();

        Console.Write("Marca: ");
        marca = Console.ReadLine();

        Console.Write("Modelo: ");
        modelo = Console.ReadLine();

        Console.Write("Ano de aquisição: ");
        anoAquisicao = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Número de patrimônio: ");
        patrimonio = int.Parse(Console.ReadLine());

        Console.Write("Está funcionando? (true/false): ");
        funcionando = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("        PATRIMÔNIO DIGITAL");
        Console.WriteLine("========================================");
        Console.WriteLine($"Patrimônio:  {patrimonio}");
        Console.WriteLine($"Equipamento: {equipamento}");
        Console.WriteLine($"Marca:       {marca}");
        Console.WriteLine($"Modelo:      {modelo}");
        Console.WriteLine($"Aquisição:   {anoAquisicao}");
        Console.WriteLine($"Valor:       R$ {valor:F2}");
        Console.WriteLine($"Funcionando: {funcionando}");
        Console.WriteLine("========================================");
    }
}