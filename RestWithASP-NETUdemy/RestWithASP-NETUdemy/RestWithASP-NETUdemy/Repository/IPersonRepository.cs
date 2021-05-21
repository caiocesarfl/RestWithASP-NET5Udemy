﻿using RestWithASP_NETUdemy.Model;
using RestWithASP_NETUdemy.Repository.Generic;

namespace RestWithASP_NETUdemy.Repository
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person Disable (long id);

    }
}
