namespace Atividade1
{
    public class Retangulo
    {

        public double Largura { get; set; }

        public double Altura { get; set; }

        public Retangulo (double altura, double largura)
        {
            this.Altura = altura;
            this.Largura = largura;
        }

        public double Area ()
        {
            return Largura * Altura;
        }

        public double Perimetro ()
        {
            return 2 * (Largura + Altura);
        }

        public double Diagonal ()
        {
            double potenciaLargura = Math.Pow (Largura, 2);
            double potenciaAltura = Math.Pow (Altura, 2);

            return Math.Sqrt(potenciaAltura + potenciaLargura);
        }
    }
}
