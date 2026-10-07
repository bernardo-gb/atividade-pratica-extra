using System;

class Program
{
    static void Main()
    {
        string cliente;
        string produto;
        int quantidade;
        double valor;
        string tipoPedido;
        bool ativo;

        Console.WriteLine("========================================");
        Console.WriteLine("           NOVO PEDIDO");
        Console.WriteLine("========================================");

        Console.Write("Cliente: ");
        cliente = Console.ReadLine();

        Console.Write("Produto: ");
        produto = Console.ReadLine();

        Console.Write("Quantidade: ");
        quantidade = int.Parse(Console.ReadLine());

        Console.Write("Valor: ");
        valor = double.Parse(Console.ReadLine());

        Console.Write("Tipo do pedido: ");
        tipoPedido = Console.ReadLine();

        Console.Write("Pedido ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("          RESUMO DO PEDIDO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Cliente:    {cliente}");
        Console.WriteLine($"Produto:    {produto}");
        Console.WriteLine($"Quantidade: {quantidade}");
        Console.WriteLine($"Valor:      R$ {valor:F2}");
        Console.WriteLine($"Tipo:       {tipoPedido}");
        Console.WriteLine($"Ativo:      {ativo}");
        Console.WriteLine("========================================");
    }
}