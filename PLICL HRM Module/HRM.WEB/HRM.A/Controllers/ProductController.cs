using HRM.A.Entities;
using HRM.A.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HRM.A.Controllers
{
    public class ProductController : Controller
    {
        private readonly HRMContext _context;
        public ProductController(HRMContext context)
        {
                _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        // CREATE Page
        public IActionResult Create()
        {
            return View();
        }

        // CREATE POST
        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }
    }
}
