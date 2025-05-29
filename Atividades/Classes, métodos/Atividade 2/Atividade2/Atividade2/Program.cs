namespace Atividade2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Salário Bruto:");
            double salarioBruto = double.Parse(Console.ReadLine());

            Console.WriteLine("Imposto:");
            double imposto = double.Parse(Console.ReadLine());

            Funcionario funcionario = new Funcionario(nome, salarioBruto, imposto);

            Console.WriteLine($"Funcionário {nome}, ${funcionario.SalarioLiquido()}.");

            Console.WriteLine("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());  

            funcionario.AumentarSalario( porcentagem );
        }
    }
}