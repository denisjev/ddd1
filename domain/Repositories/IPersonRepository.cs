namespace DDD1.Domain.Repositories;

using DDD1.Domain.Entities;
public interface IPersonRepository
{
    Task<Person> GetPersonById(int id);
    Task AddPerson(Person person);
}