namespace Atividade2
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            double diferenca = Salario * (porcentagem / 100);
            double salarioLiquido = SalarioLiquido();
            salarioLiquido += diferenca;
            Console.WriteLine($"Dados Atualizados: {Nome}, {salarioLiquido}.");
        }

        public Funcionario(string nome, double salario, double imposto)
        {
            this.Salario = salario;
            this.Imposto = imposto; 
            this.Nome = nome;
        }
    }
}
