namespace DDD1.Infraestructure.InputPort;

using DDD1.Domain.Entities;

public interface IPersonUseCaseServices
{
    public Task createPerson(string name, int edad, string sexo);
    public Task<Person> getById(int id);
}