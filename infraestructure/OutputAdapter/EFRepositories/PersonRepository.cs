namespace DDD1.Infraestructure.OutputAdapter.EFRepositories;

using DDD1.Domain.Entities;
using DDD1.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

public class PersonRepository : IPersonRepository
{
    AppDbContext appDbContext;
    public PersonRepository(AppDbContext _appDbContext)
    {
        appDbContext = _appDbContext;
    }

    public async Task<IEnumerable<Person>> GetAllPerson()
    {
        return await appDbContext.Persons.ToListAsync();
    }

    public async Task<Person> GetPersonById(int id)
    {
        return await appDbContext.Persons.FindAsync(id);
    }
    public async Task<int> AddPerson(Person person)
    {
        await appDbContext.Persons.AddAsync(person);
        return await appDbContext.SaveChangesAsync();
    }
}