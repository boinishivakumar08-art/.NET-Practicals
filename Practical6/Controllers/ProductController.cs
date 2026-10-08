using Microsoft.AspNetCore.Mvc;
using Practical6.Models;

namespace Practical6.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = "High performance laptop",
                Category = "Electronics",
                Price = 60000
            },

            new Product
            {
                Id = 2,
                Name = "Smartphone",
                Description = "Latest smartphone",
                Category = "Electronics",
                Price = 25000
            },

            new Product
            {
                Id = 3,
                Name = "Headphones",
                Description = "Wireless headphones",
                Category = "Accessories",
                Price = 2000
            },

            new Product
            {
                Id = 4,
                Name = "Keyboard",
                Description = "Wireless keyboard",
                Category = "Accessories",
                Price = 1500
            }
        };

        public IActionResult Index()
        {
            return View(products);
        }

        public IActionResult Details(int id)
        {
            var product = products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            product.Id = products.Count + 1;

            products.Add(product);

            return RedirectToAction("Index");
        }
    }
}