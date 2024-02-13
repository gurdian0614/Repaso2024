
namespace Repaso2024
{
    public class Clase : Alumno
    {
        public string NombreClase { get; set; }
        public string HoraClase { get; set; }
        public string NombreCatedratico { get; set; }

        public override void MostrarAlumno()
        {
            Console.WriteLine($"Nombre de la clase: {NombreClase}");
            Console.WriteLine($"Horario: {HoraClase}");
            Console.WriteLine($"Nombre del catedrático: {NombreCatedratico}");
        }

        public void MostrarClase()
        {
            Console.WriteLine($"Nombre de la clase: {NombreClase}");
            Console.WriteLine($"Número de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo electrónico: {Email}");
        }
    }
}
