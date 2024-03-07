using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebProject.Models;

namespace WebProject.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var products = new List<Product>
        {
            new Product { id = 1, name = "Laptop", price = 1999.99m, ShipperId = 1,description = "This is a laptop" },
            new Product { id = 2, name = "Iphone", price = 699.99m, ShipperId = 2,description = "This is an Iphone" },
            new Product { id = 3, name = "Book", price = 9.99m, ShipperId = 3,description = "This is a book" },
            new Product { id = 4, name = "Desk", price = 299.99m, ShipperId = 1,description = "This is a Desk" },
            new Product { id = 5, name = "Ipad", price = 899.99m, ShipperId = 2,description = "This is an Ipad" }
        };
        return View(products);
    }
    
}