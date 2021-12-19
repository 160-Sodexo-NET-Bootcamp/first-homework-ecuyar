using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EnesCanUyar_Odev1_BooksApi.Controllers
{
    [Route("api/[controller]s")]
    [ApiController]
    public class BookController : ControllerBase
    {
        public List<Book> books = new();

        public BookController()
        {
            //create list of books with random values
            books.Add(new Book { Id = 1, KitapSeriNo = "SDF65JHYB", KitapAdi = "Wit", Yazari = "Des MacHale", SayfaSayisi = 650 });
            books.Add(new Book { Id = 2, KitapSeriNo = "KHHNB7786", KitapAdi = "Battle Cry of Freedom", Yazari = "James M. McPherson", SayfaSayisi = 150 });
            books.Add(new Book { Id = 3, KitapSeriNo = "KFDSE4569", KitapAdi = "The Book of Useless Information", Yazari = "Noel Botham", SayfaSayisi = 100 });
            books.Add(new Book { Id = 4, KitapSeriNo = "KHHNB7786", KitapAdi = "101 Things to Do Before You Die", Yazari = "Richard Horne ", SayfaSayisi = 75 });
            books.Add(new Book { Id = 5, KitapSeriNo = "MNUI123CV", KitapAdi = "The Little Book of Answers", Yazari = "Doug Lennox", SayfaSayisi = 73 });
            books.Add(new Book { Id = 6, KitapSeriNo = "LKI65H637", KitapAdi = "Time to Eat", Yazari = "Steve Jenkins ", SayfaSayisi = 98 });
        }

        //Get all books by post request
        [HttpPost]
        public ActionResult<List<Book>> GetAllBooks()
        {
            //simply return list
            return books;
        }

        //Get book by using route
        [HttpGet("{id}")]
        public ActionResult GetBookByIdByRoute([FromRoute] int id)
        {
            var book = books.FirstOrDefault(q => q.Id == id);

            //check if there is a book with specified id. if not found, show 404 error.
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        //Get book by using query parameter
        [HttpGet]
        public ActionResult GetBookByIdByQuery([FromQuery] int id)
        {
            var book = books.FirstOrDefault(q => q.Id == id);

            //check if there is a book with specified id. if not found, show 404 error.
            if (book == null)
            {
                return NotFound();
            }

            return Ok(book);
        }
    }
}
