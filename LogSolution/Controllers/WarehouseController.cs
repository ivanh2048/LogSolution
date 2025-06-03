using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using LogSolution.Models;

public class WarehouseController : Controller
{
    // For demo: static list (replace with DB in real app)
    private static List<Product> products = new List<Product>
    {
        new Product { Name = "Laptop", Quantity = 10, Sector = "A", Alley = "1", Row = "2", ProductCode = "123456789012" },
        new Product { Name = "Monitor", Quantity = 5, Sector = "B", Alley = "2", Row = "1", ProductCode = "234567890123" },
        new Product { Name = "Mouse", Quantity = 50, Sector = "A", Alley = "3", Row = "4", ProductCode = "345678901234" }
    };

    public IActionResult Index()
    {
        return View(products);
    }

    [HttpGet]
    public IActionResult Edit(string code)
    {
        var product = products.FirstOrDefault(p => p.ProductCode == code);
        if (product == null) return NotFound();
        return View(product);
    }

    [HttpPost]
    public IActionResult Edit(Product edited)
    {
        var product = products.FirstOrDefault(p => p.ProductCode == edited.ProductCode);
        if (product == null) return NotFound();
        product.Quantity = edited.Quantity;
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Product newProduct)
    {
        // Validate: ProductCode must be 12 digits, first not 0
        if (string.IsNullOrWhiteSpace(newProduct.ProductCode) ||
            newProduct.ProductCode.Length != 12 ||
            !newProduct.ProductCode.All(char.IsDigit) ||
            newProduct.ProductCode[0] == '0')
        {
            ModelState.AddModelError("ProductCode", "Kod produktu musi mieć 12 cyfr i nie może zaczynać się od 0.");
            return View(newProduct);
        }

        products.Add(newProduct);
        return RedirectToAction("Index");
    }
}
