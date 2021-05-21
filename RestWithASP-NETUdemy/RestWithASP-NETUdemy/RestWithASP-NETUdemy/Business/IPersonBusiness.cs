﻿using RestWithASP_NETUdemy.Data.VO;
using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create (PersonVO person);
        PersonVO FindByID (long id);
        List<PersonVO> FindAll();
        PersonVO Update (PersonVO person);
        PersonVO Disable(long id);
        void Delete (long id);
    }
}
