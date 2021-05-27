using RestWithASP_NETUdemy.Model;
using RestWithASP_NETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable (long id);

        List<Person> FindByName(string firstName, string lastName);

    }
}
