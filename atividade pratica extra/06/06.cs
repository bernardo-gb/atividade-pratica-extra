using System;

class Program
{
    static void Main()
    {
        string nomeAluno;
        int idade;
        string curso;
        string cidade;
        int numeroMatricula;
        string turno;
        bool ativo;

        Console.WriteLine("========================================");
        Console.WriteLine("          SISTEMA DE MATRÍCULA");
        Console.WriteLine("========================================");

        Console.Write("Nome do aluno: ");
        nomeAluno = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.Write("Curso: ");
        curso = Console.ReadLine();

        Console.Write("Cidade: ");
        cidade = Console.ReadLine();

        Console.Write("Número da matrícula: ");
        numeroMatricula = int.Parse(Console.ReadLine());

        Console.Write("Turno: ");
        turno = Console.ReadLine();

        Console.Write("Estudante ativo? (true/false): ");
        ativo = bool.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("========================================");
        Console.WriteLine("             MATRÍCULA");
        Console.WriteLine("========================================");
        Console.WriteLine($"Aluno:      {nomeAluno}");
        Console.WriteLine($"Matrícula:  {numeroMatricula}");
        Console.WriteLine($"Curso:      {curso}");
        Console.WriteLine($"Idade:      {idade}");
        Console.WriteLine($"Cidade:     {cidade}");
        Console.WriteLine($"Turno:      {turno}");
        Console.WriteLine($"Ativo:      {ativo}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("MATRÍCULA REGISTRADA COM SUCESSO!");
        Console.WriteLine("========================================");
    }
}