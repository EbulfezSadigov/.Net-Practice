using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_1.ViewModel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_1.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext db;

        public HomeController(AppDbContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            HomeViewModel viewModel = new HomeViewModel()
            {
                sliders = db.Sliders.ToList(),
                policies = db.Policies.ToList(),
                products = db.Products.ToList()
            };
            return View(viewModel);
        }

    }
}
