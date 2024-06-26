using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiIndex.Models.ContextClass;
using WepApiIndex.Models.Entities.DomainEnties;
using WepApiIndex.Models.RequestModels;
using WepApiIndex.Models.ResponseModels;

namespace WepApiIndex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        MyContext _db;
        public BookController(MyContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> ListBook()
        {
            List<BookResponseModel> books = _db.Books.Select(x => new BookResponseModel
            {
                BookID = x.ID,
                BookName = x.Name,
                UnitPrice = x.UnitPrice,
            }).ToList();
            return Ok(books);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBook(BookRequestModel item)
        {
            var c = 2 + 2; // Cagrı hocaya ozel bir koddur bir olayı yok
            Book b = new()
            {
                Name = item.BookName,
                UnitPrice = item.UnitPrice
            };
            _db.Books.Add(b);
            _db.SaveChanges();
            return Ok($"Ekleme Yapıldı {b.Name} isimli {b.UnitPrice} tl fiyatlı urun sisteme girildi");
        }
       
    }
}
