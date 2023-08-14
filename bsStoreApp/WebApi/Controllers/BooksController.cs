using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;
using WebApi.Repositories;

namespace WebApi.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly RepositoryContext _context;

        public BooksController(RepositoryContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllBooks()
        {
            var books = _context.Books.ToList();
            return Ok(books);
        }

        [HttpGet("{id:int}")]
        public IActionResult GetOneBook([FromRoute(Name = "id")] int id)
        {
            try
            {
                var books = _context.Books.Where(x => x.Id == id).SingleOrDefault();

                if (books is null)
                    return NotFound(); //404 
                return Ok(books);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult CreateOneBook([FromBody] Book book)
        {
            try
            {
                if (book is null)
                    return BadRequest(); //400
                _context.Books.Add(book);
                _context.SaveChanges();
                return StatusCode(201, book); //201
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateOneBook([FromRoute(Name = "id")] int id, [FromBody] Book book)
        {
            try
            {
                var entity = _context.Books.Where(x => x.Id == id).SingleOrDefault();
                if (entity is null)
                    return NotFound();//404
                if (id != entity.Id)
                    return BadRequest();
                entity.Title = book.Title;
                entity.Price = book.Price;
                _context.Books.Update(entity);
                _context.SaveChanges();
                return Ok(book);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult DeleteOneBooks([FromRoute(Name = "id")] int id)
        {
            try
            {
                var entite = _context.Books.Where(x => x.Id == id).SingleOrDefault();
                if (entite is null)
                    return NotFound();
                if (id != entite.Id)
                    return BadRequest();

                _context.Books.Remove(entite);
                _context.SaveChanges();
                return Ok(entite);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

        }


    }

}
