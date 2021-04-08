using RestWithASP_NETUdemy.Data.Converter.Contract;
using RestWithASP_NETUdemy.Data.VO;
using RestWithASP_NETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Data.Converter.Implementations
{
    public class BookConverter : IParser<BookVO, Book>, IParser<Book, BookVO>
    {
        public Book Parse(BookVO origin)
        {
           if (origin == null)
                return null;

           return new Book
           {
               Id = origin.Id,
               Title = origin.Title,
               LaunchDate = origin.LaunchDate,
               Price = origin.Price,
               Author = origin.Author  
           };
        }


        public BookVO Parse(Book origin)
        {
            if (origin == null)
                return null;

            return new BookVO
            {
                Id = origin.Id,
                Title = origin.Title,
                LaunchDate = origin.LaunchDate,
                Price = origin.Price,
                Author = origin.Author
            };
        }

        public List<BookVO> Parse(List<Book> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item=> Parse(item)).ToList();
        }

        public List<Book> Parse(List<BookVO> origin)
        {
            if (origin == null)
                return null;

            return origin.Select(item => Parse(item)).ToList();
        }
    }
}
