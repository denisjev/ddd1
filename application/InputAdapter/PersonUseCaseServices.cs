namespace DDD1.Application.InputAdapter;

using DDD1.Domain.Entities;
using DDD1.Domain.Repositories;
using DDD1.Infraestructure.InputPort;
using DDD1.Infraestructure.InputPort;

class PersonUseCaseServices : IPersonUseCaseServices
{
    private readonly IPersonRepository repository;
    public PersonUseCaseServices(IPersonRepository _repository)
    {
        repository = _repository;
    }

    public async Task createPerson(string name, int edad, string sexo)
    {
        await repository.AddPerson(new Person(name, edad, sexo));
    }
    public async Task<Person> getById(int id)
    {
        return await repository.GetPersonById(id);
    }
}