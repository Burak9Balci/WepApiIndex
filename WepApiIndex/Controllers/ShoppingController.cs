using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WepApiIndex.Extentions;
using WepApiIndex.Models.ContextClass;
using WepApiIndex.Models.Entities.DomainEnties;
using WepApiIndex.ShoppingClasses;

namespace WepApiIndex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingController : ControllerBase
    {
        MyContext _db;
        public ShoppingController(MyContext db)
        {
            _db = db;
        }
        [HttpPost()]
        public async Task<IActionResult> AddBookToCart(int id)
        {
            Cart c = GetCartFromSession("scart") == null ? new Cart() : GetCartFromSession("scart");
            Book b = await _db.Books.FindAsync(id);
            CartItem cu = new()
            {
                ID = b.ID,
                Name = b.Name,
                UnitPrice = b.UnitPrice,

            };
            c.AddToCart(cu);
            SetCartToSession(c);
            return Ok($"sepete {cu.Name} isimli ürünü eklendin fiyatı da {cu.UnitPrice}");
        }
        [HttpGet]
        public async Task<IActionResult> CartInfoPage()
        {
            if (GetCartFromSession("scart") != null)
            {
                return Ok(GetCartFromSession("scart"));
            }
             return BadRequest("Sepet Hatası Sepet boş olabilir");
        }
        [HttpDelete()]
        public async Task<IActionResult> DecreaseFromCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.Decrease(id);
                SetCartToSession(c);
                return Ok($"Sepetinizdeki ürün azaltıldı {c}");
            }
            return BadRequest("Sepet Hatası Sepet boş olabilir");
        }
        [HttpDelete("id")]
        public async Task<IActionResult> DeleteCart(int id)
        {
            if (GetCartFromSession("scart") != null)
            {
                Cart c = GetCartFromSession("scart");
                c.DeleteFromCart(id);
                SetCartToSession(c);
                return Ok($"Sepetiniz Temizlendi {c}");
            }
            return BadRequest("Sepet Hatası Sepet boş olabilir");
        }
        void SetCartToSession(Cart c)
        {
            HttpContext.Session.SetObject("scart",c);
        }
        Cart GetCartFromSession(string key)
        {
           return HttpContext.Session.GetObject<Cart>(key);
        }
    }
}
