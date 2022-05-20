using AspIntro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AspIntro.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(string search)
        {
            List<Product> products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    Name = "Test1",
                    Description = "test desc 1",
                    Price = 100,
                    Image = "camera.jfif"
                },
                new Product
                {
                    Id = 2,
                    Name = "Test2",
                    Description = "test desc 2",
                    Price = 102,
                    Image = "car.jpg"
                },
                new Product
                {
                    Id = 3,
                    Name = "Test3",
                    Description = "test desc 3",
                    Price = 103,
                    Image = "headphone.jfif"
                }
            };

            if (!string.IsNullOrWhiteSpace(search))
            {
                products = products.FindAll(p => p.Name.ToLower().Contains(search.ToLower()));
                if(products.Count == 0)
                    return NotFound();
            }

            return View(products);
        }
    }
}
