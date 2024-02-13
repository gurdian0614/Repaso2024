
namespace Repaso2024
{
    internal class Promedio : IPromedio
    {
        public double Valor1 { get; set; }
        public double Valor2 { get; set; }
        public double Valor3 { get; set; }

        public Promedio(double Valor1, double Valor2, double Valor3) {
            this.Valor1 = Valor1;
            this.Valor2 = Valor2;
            this.Valor3 = Valor3;
        }

        public double CalcularPromedio()
        {
            return (Valor1 + Valor2 + Valor3) / 3;
        }

        public double CalcularPromedio(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        public string MostrarPromedio()
        {
            return $"Promedio utilizando el método CalcularPromedio sin parámetros: {CalcularPromedio()}%";
        }

        public string MostrarPromedio(double a, double b, double c)
        {
            return $"Promedio utilizando el método CalcularPromedio con parámetros: {CalcularPromedio(a, b, c)}%";
        }
    }
}
