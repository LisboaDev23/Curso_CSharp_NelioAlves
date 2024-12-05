using System.Globalization;

public class Program
{
    public static void Main (string[] args)
    {
        string produto = Console.ReadLine();
        string produto2 = Console.ReadLine();

        byte idade = byte.Parse(Console.ReadLine());
        int codigo = int.Parse(Console.ReadLine());
        char genero = char.Parse(Console.ReadLine());

        double preco = double.Parse(Console.ReadLine());
        double preco2 = double.Parse(Console.ReadLine());
        double medida = double.Parse(Console.ReadLine());

        Console.WriteLine("Produtos:");
        Console.WriteLine($"{produto}, cujo preço é {preco}");
        Console.WriteLine($"{produto2}, cujo preço é {preco2}");

        Console.WriteLine($"Registro: {idade} anos de idade, código {5290} e gênero: {genero}");

        Console.WriteLine($"Medida com 8 casas decimais: {medida}");
        Console.WriteLine($"Arredondado (3 casas decimais): {medida.ToString("F3")}");
        Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3",CultureInfo.InvariantCulture)}");
    }
}
