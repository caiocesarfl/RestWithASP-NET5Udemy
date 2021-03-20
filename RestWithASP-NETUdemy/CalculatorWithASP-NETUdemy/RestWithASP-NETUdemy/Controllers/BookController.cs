using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASP_NETUdemy.Business;
using RestWithASP_NETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class BookController : Controller
    {
       private readonly ILogger<BookController> _logger;
       private readonly IBookBusiness bookBusiness;

        public BookController(ILogger<BookController> logger, IBookBusiness bookBusiness)
        {
            _logger = logger;
            this.bookBusiness = bookBusiness;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(bookBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get (long id)
        {
            var book = bookBusiness.FindById(id);
            if (book == null)
            {
                return NotFound();
            }
                return Ok(book);
        }

        [HttpPost]
        public IActionResult Post([FromBody]Book book)
        {
            if (book == null)
                return NotFound();
            return Ok (bookBusiness.Create(book));
        }

        [HttpPut]
        public IActionResult Put ([FromBody] Book book)
        {
            if (book == null)
                return NotFound();
            return Ok(bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete (long id)
        {
            var book = bookBusiness.FindById(id);
            if (book == null)
            {
                return NotFound();
            }

            bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
