namespace DDD1.Infraestructure.OutputAdapter.EFRepositories;

using DDD1.Domain.Entities;
using DDD1.Domain.Repositories;

public class PersonRepository : IPersonRepository
{
    private AppDbContext appDbContext;
    public PersonRepository(AppDbContext _appDbContext)
    {
        appDbContext = _appDbContext;
    }

    public async Task<Person> GetPersonById(int id)
    {
        return await appDbContext.Persons.FindAsync(id);
    }
    public async Task AddPerson(Person person)
    {
        await appDbContext.Persons.AddAsync(person);
        await appDbContext.SaveChangesAsync();
    }
}