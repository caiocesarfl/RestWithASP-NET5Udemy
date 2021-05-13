﻿using RestWithASP_NETUdemy.Data.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Business
{
    public interface ILoginBusiness
    {
        TokenVO ValidadeCredentials (UserVO user);

        TokenVO ValidadeCredentials(TokenVO token);
    }
}
