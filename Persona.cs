using System.Dynamic;

public class Persona
{
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }

    public int Edad { get; set; }

    public void ImprimeInformacion()
    {
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Apellido: {Apellido}");
        Console.WriteLine($"Edad: {Edad}");
    }
}