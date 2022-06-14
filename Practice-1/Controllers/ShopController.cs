using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Practice_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext db;

        public ShopController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            ShopViewModel shop = new ShopViewModel() {
                categories=db.Categories.Include(x=>x.Products).ToList(),
                products=db.Products.ToList()
            };
            return View(shop);
        }
    }
}
