namespace Atividade4
{
    public static class ConversorDeMoeda
    {
        public static double ConverterMoeda(double cotacao, double valor)
        {
            double valorSemIOF = cotacao * valor;
            double diferenca = valorSemIOF * 0.06;

            return valorSemIOF + diferenca;
        }
    }
}
