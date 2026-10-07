using System;

class Program
{
    static void Main()
    {
        string nome;
        int idade;

        Console.Write("Nome: ");
        nome = Console.ReadLine();

        Console.Write("Idade: ");
        idade = int.Parse(Console.ReadLine());

        Console.WriteLine("================================");
        Console.WriteLine("CADASTRO");
        Console.WriteLine("================================");
        Console.WriteLine("Nome: " + nome);
        Console.WriteLine("Idade: " + idade);
    }
}