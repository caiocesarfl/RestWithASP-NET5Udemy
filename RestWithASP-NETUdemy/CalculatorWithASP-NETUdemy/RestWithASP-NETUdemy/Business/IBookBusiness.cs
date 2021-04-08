using System;
using System.Collections.Generic;
using RestWithASP_NETUdemy.Data.VO;
using RestWithASP_NETUdemy.Model;

namespace RestWithASP_NETUdemy.Business
{
    public interface IBookBusiness
    {
        List<BookVO> FindAll();

        BookVO FindById(long id);

        BookVO Create(BookVO book);

        BookVO Update(BookVO book);

        void Delete(long id);

        
    }
}
