namespace DDD1.Infraestructure.InputPort;

using DDD1.Domain.Entities;

public interface IPersonUseCaseServices
{
    public Task<int> createPerson(string name, int edad, string sexo);
    public Task<Person> getPersonById(int id);
    public Task<IEnumerable<Person>> getAllPerson();
}