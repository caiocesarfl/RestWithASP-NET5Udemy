using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASP_NETUdemy.Business;
using RestWithASP_NETUdemy.Data.VO;
using RestWithASP_NETUdemy.Hypermedia.Filters;
using RestWithASP_NETUdemy.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NETUdemy.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Authorize("Bearer")]
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

        [HttpGet("{sortDirection}/{pageSize}/{page}")]
        [ProducesResponseType((200), Type = typeof(List<BookVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(
             [FromQuery] string title,
             string sortDirection,
             int pageSize,
             int page)
        {
            return Ok(bookBusiness.FindWithPagedSearch(title, sortDirection, pageSize, page));
        }

        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get (long id)
        {
            var book = bookBusiness.FindByID(id);
            if (book == null)
            {
                return NotFound();
            }
                return Ok(book);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody]BookVO book)
        {
            if (book == null)
                return NotFound();
            return Ok (bookBusiness.Create(book));
        }

        [HttpPut]
        [ProducesResponseType((200), Type = typeof(BookVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put ([FromBody] BookVO book)
        {
            if (book == null)
                return NotFound();
            return Ok(bookBusiness.Update(book));
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Delete (long id)
        {
            var book = bookBusiness.FindByID(id);
            if (book == null)
            {
                return NotFound();
            }

            bookBusiness.Delete(id);
            return NoContent();
        }
    }
}
