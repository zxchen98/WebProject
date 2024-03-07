namespace WebProject.Models;

public class Product
{
    public int id { get; set; }
    public string name { get; set; }
    public int ShipperId { get; set; }
    public decimal price { get; set; }
    public string description { get; set; }
}