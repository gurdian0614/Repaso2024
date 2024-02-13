using Repaso2024;

try
{
    double n1, n2, n3;
    Clase clase = new Clase();
    clase.NombreClase = "Programación II";
    clase.HoraClase = "18:00 - 19:30";
    clase.NombreCatedratico = "Ing. Roger Ivan Gurdian Castillo";
    clase.Nombre = "Roger Gurdian";
    clase.NumeroCuenta = "200611410011";
    clase.Email = "rogergurdian@unitec.edu";
    clase.MostrarClase();
    clase.MostrarAlumno();

    Console.WriteLine("Ingrese nota 1:");
    n1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese nota 2:");
    n2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese nota 3:");
    n3 = double.Parse(Console.ReadLine());

    Promedio promedio = new Promedio(n1, n2, n3);
    promedio.CalcularPromedio(n1, n2, n3);
    promedio.CalcularPromedio();
    Console.WriteLine(promedio.MostrarPromedio(n1, n2, n3));
    Console.WriteLine(promedio.MostrarPromedio());

} catch (Exception e)
{
    Console.WriteLine(e.Message);
}