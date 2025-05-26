
namespace Atividade1
{
    public class Program
    {
        public static void Main (string[] args)
        {
            //capturar a altura 
            Console.WriteLine("Digite a altura do retângulo:");
            double altura = double.Parse(Console.ReadLine());
            //capturar a largura
            Console.WriteLine("Digite a largura do retângulo");
            double largura = double.Parse(Console.ReadLine());

            Retangulo retangulo = new Retangulo(altura, largura);

            Console.WriteLine("Área: " + retangulo.Area());
            Console.WriteLine("Perimetro: " + retangulo.Perimetro());
            Console.WriteLine("Diagonal: " + retangulo.Diagonal());
        }
    }
}
