namespace DDD1.Application.InputAdapter;

using DDD1.Domain.Entities;
using DDD1.Domain.Repositories;
using DDD1.Infraestructure.InputPort;

public class PersonUseCaseServices : IPersonUseCaseServices
{
    private readonly IPersonRepository repository;
    public PersonUseCaseServices(IPersonRepository _repository)
    {
        repository = _repository;
    }

    public async Task<int> createPerson(string name, int edad, string sexo)
    {
        return await repository.AddPerson(new Person(name, edad, sexo));
    }
    public async Task<Person> getPersonById(int id)
    {
        return await repository.GetPersonById(id);
    }
    public async Task<IEnumerable<Person>> getAllPerson()
    {
        return await repository.GetAllPerson();
    }

}