namespace Atividade4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dólar?");
            double cotacao = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Quantos dólares você vai comprar?");
            double valor = double.Parse(Console.ReadLine()!);

            double valorConvertido = ConversorDeMoeda.ConverterMoeda(cotacao, valor);

            Console.WriteLine($"Valor a ser pago em reais = {valorConvertido}");
        }
    }
}
