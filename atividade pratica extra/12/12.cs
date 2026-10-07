using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;
        string cidade;
        string evento;
        string tipoParticipacao;
        int numeroInscricao;
        bool confirmado;

        Console.WriteLine("========================================");
        Console.WriteLine("       EVENTO TECNOLÓGICO");
        Console.WriteLine("========================================");

        Console.Write("Nome do participante: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Nome do evento: ");
        evento = Console.ReadLine();

        Console.Write("Tipo de participação: ");
        tipoParticipacao = Console.ReadLine();

        Console.Write("Número da inscrição: ");
        numeroInscricao = int.Parse(Console.ReadLine());

        Console.Write("Participação confirmada? (true/false): ");
        confirmado = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("       PARTICIPANTE DO EVENTO");
        Console.WriteLine("========================================");
        Console.WriteLine($"Nome:           {nome}");
        Console.WriteLine($"Idade:          {idade}");
        Console.WriteLine($"Cidade:         {cidade}");
        Console.WriteLine($"Evento:         {evento}");
        Console.WriteLine($"Participação:   {tipoParticipacao}");
        Console.WriteLine($"Inscrição:      {numeroInscricao}");
        Console.WriteLine($"Confirmado:     {confirmado}");
        Console.WriteLine("========================================");
    }
}