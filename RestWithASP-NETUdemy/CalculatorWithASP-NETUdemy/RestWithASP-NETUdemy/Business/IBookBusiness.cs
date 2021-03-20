using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestWithASP_NETUdemy.Model;

namespace RestWithASP_NETUdemy.Business
{
    public interface IBookBusiness
    {
        List<Book> FindAll();

        Book FindById(long id);

        Book Create(Book book);

        Book Update(Book book);

        void Delete(long id);

        
    }
}
