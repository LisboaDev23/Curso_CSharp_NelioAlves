using AtvPoo.Entities;

public class Program
{
    public static void Main (string[] args)
    {
        Pessoa p1, p2;

        p1 = new Pessoa();
        p2 = new Pessoa();

        Console.WriteLine("Digite o nome da pessoa 1");
        p1.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa 1");
        p1.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o sexo da pessoa 1 em M ou F");
        p1.Sexo = char.Parse(Console.ReadLine());

        Console.WriteLine("Digite o nome da pessoa 2");
        p2.Nome = Console.ReadLine();
        Console.WriteLine("Digite a idade da pessoa 2");
        p2.Idade = int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o sexo da pessoa 2 em M ou F");
        p2.Sexo = char.Parse(Console.ReadLine());

        Console.WriteLine(p1.Nome + " " + p1.Idade + " " + p1.Sexo);
        Console.WriteLine(p2.Nome + " " + p2.Idade + " " + p2.Sexo);
    }
}
