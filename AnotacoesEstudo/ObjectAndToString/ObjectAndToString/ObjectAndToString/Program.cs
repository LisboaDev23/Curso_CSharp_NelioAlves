using ObjectAndToString.Entities;

public class Program
{

    public static void Main (string[] args)
    {
        Produto produto = new Produto("Paracetamol", 20.00, 200);

        Console.WriteLine(produto);

    }
}
