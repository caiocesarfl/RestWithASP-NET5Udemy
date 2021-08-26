using RestWithASP_NETUdemy.Data.VO;
using RestWithASP_NETUdemy.Hypermedia.Utils;
using System.Collections.Generic;

namespace RestWithASP_NETUdemy.Business
{
    public interface IBookBusiness
    {
        BookVO Create(BookVO book);
        BookVO FindByID(long id);
        List<BookVO> FindAll();
        PagedSearchVO<BookVO> FindWithPagedSearch(
            string title, string sortDirection, int pageSize, int page);
        BookVO Update(BookVO book);
        void Delete(long id);
    }
}