using Microsoft.AspNetCore.Mvc;
using WebProject.Models;
namespace WebProject.Controllers;

public class ShipperController : Controller
{
    public static List<Shipper> shippers = new List<Shipper>
    {
        new Shipper { id = 1, name = "Fedex", city = "New York" },
        new Shipper { id = 2, name = "UPS", city = "Los Angeles" },
        new Shipper { id = 3, name = "USPS", city = "Seattle" }
    };
    public IActionResult Index()
    {
        return View(shippers);
    }
    public IActionResult About(int shipperId)
    {
        var shipper = shippers.FirstOrDefault(s => s.id == shipperId);
        Console.WriteLine(shipper.city+"------------------");
        return View(shipper);
    }
    public IActionResult Contact(int shipperId)
    {
        var shipper = shippers.FirstOrDefault(s => s.id == shipperId);
        Console.WriteLine(shipper.city+"------------------");
        return View(shipper);
    }
}