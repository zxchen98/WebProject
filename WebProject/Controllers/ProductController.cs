using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
namespace WebProject.Controllers;

public class ProductController : Controller
{
    public static List<Product> products = new List<Product>
    {
        new Product { id = 1, name = "Iphone", price = 639.99m, ShipperId = 1,description = "Iphones are good phones" },
        new Product { id = 2, name = "Ipad", price = 839.99m, ShipperId = 1,description = "Description of Ipad" },
        new Product { id = 3, name = "Mac", price = 1639.99m, ShipperId = 1,description = "Description of Mac" },
        new Product { id = 4, name = "Desktop", price = 2229.99m, ShipperId = 2,description = "Description of Desktop" },
        new Product { id = 5, name = "Book", price = 19.99m, ShipperId = 3,description = "Description of Book" },
        new Product { id = 6, name = "Pen", price = 1.99m, ShipperId = 3,description = "Description of Pen" },
        new Product { id = 7, name = "Desk", price = 119.99m, ShipperId = 3,description = "Description of Desk" },
        new Product { id = 8, name = "Sofa", price = 339.99m, ShipperId = 4,description = "Description of Sofa" },
        new Product { id = 9, name = "Monitor", price = 239.99m, ShipperId = 4,description = "Description of Monitor" },
    };
    public IActionResult Index()
    {

        return View(products);
    }
    public IActionResult Purchase(int id)
    {
        var product = products.FirstOrDefault(p => p.id == id);

        return View(product);
    }
    public IActionResult Shipping(int shipperId)
    {
        var shipper = ShipperController.shippers.FirstOrDefault(s => s.id == shipperId);
        return View(shipper);
    }
}