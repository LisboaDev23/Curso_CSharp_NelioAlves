using OperadoresComparativos;

public class Program
{
    public static void Main(string[] args)
    {
        string viado = "BAITOLA";
        string bolsonaro = viado;
        //bolsonaro = "LADRÃO";

        if (bolsonaro != viado)
        {
            Console.WriteLine("Alguma coisa ta errada!");
            return;
        }
        Console.WriteLine("BOLSONARO É VIADO!");

        Console.WriteLine(bolsonaro == viado);

        OutrosOperadores logicaCasalFoda = new OutrosOperadores();
        logicaCasalFoda.casalIsFoda();
    }
}
