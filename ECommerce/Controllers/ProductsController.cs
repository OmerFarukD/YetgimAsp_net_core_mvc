using ECommerce.DataAccess.Contexts;
using ECommerce.Models;
using ECommerce.Models.Dtos.Products;
using ECommerce.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.Controllers;

public class ProductsController : Controller
{ 
    
   private readonly IProductService _productService;

   public ProductsController(IProductService productService)
   {
       _productService = productService;
   }
    
    
    // GET : bir kaynağı okuma işlemi yapar
    
    [HttpGet]
    public IActionResult Index()
    {
        // SELECT * FROM Products
        List<ProductResponseDto> products = _productService.GetAll();
        return View(products);
    }

    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Add(Product product)
    {
        
        _productService.Add(product);
        return RedirectToAction("Index","Home");
    }


    [HttpGet]
    public IActionResult Detail(Guid id)
    {
        // SELECT * FROM Products Where Id = 2
        var product = _productService.GetById(id);
        return View(product);

    }


    [HttpGet]
    public IActionResult Update(Guid id)
    {

        var product = _productService.GetById(id);
        return View(product);
    }


    [HttpPost]
    public IActionResult Update(Product product)
    {
        _productService.Update(product);
        return RedirectToAction("Index","Products");
    }


    [HttpGet]
    public IActionResult Delete(Guid id)
    {
        var product = _productService.GetById(id);
        _productService.Delete(id);
        return RedirectToAction("Index","Products");
    }
    
}