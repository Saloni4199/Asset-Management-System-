using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AssetMS.DataBase;
using AssetMS.Models;


namespace AssetMS.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IAsset<Book> _bookRepository;

        public BookController(IAsset<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }


        [HttpGet]
        public async Task<IEnumerable<Book>> GetBookCollection()
        {
            var BookList = _bookRepository.ListAllAsset();
            return await BookList;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Book>> GetBook(int id)
        {
            var book = _bookRepository.SearchAsset(id);
            if (book == null)
                return NotFound();
            else
                return await book;

        }

        [HttpPost]
        public async Task PostData(Book book)
        {
            await _bookRepository.AddAsset(book);

        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Book>> DeleteRequest(int id)
        {
            var book = await _bookRepository.DeleteAsset(id);
            if (book == null)
                return NotFound();
            else
                return Ok();
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Book>> UpdateDetails(int id, Book book)
        {
            if (id != book.BookId)
            {
                return BadRequest();
            }

            bool result = false;
            result = await _bookRepository.UpdateAsset(id, book);
            if (result)
                return Ok();
            else
                return NotFound();

        }
    }
}