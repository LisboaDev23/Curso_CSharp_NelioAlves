public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Escreva 2 números para somar");
        Console.WriteLine("Numero 1: ");

        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Numero 2: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("A soma dos dois números é " + Soma(number1, number2));
    }

    public static int Soma(int number1, int number2)
    {
        return number1 + number2;
    } 
}
