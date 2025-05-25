using List10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace List10.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopDbContext _context;

        public ShopController(ShopDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int? categoryId)
        {
            var articles = await _context.Article.ToListAsync();

            if (categoryId != null)
            {
                articles = articles.Where(a => a.CategoryId == categoryId).ToList();
            }

            ViewBag.Categories = await _context.Category.ToListAsync();

            return View(articles);
        }
    }
}
