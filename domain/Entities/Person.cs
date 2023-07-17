namespace DDD1.Domain.Entities;

public class Person
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public int Edad { get; set; }
    public string Sexo { get; set; }

    public Person() { }
    public Person(string nombre, int edad, string sexo)
    {
        Nombre = nombre;
        Edad = edad;
        Sexo = sexo;
    }
}
