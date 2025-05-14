using AutoMapper;
using ECommerce.Models;
using ECommerce.Models.Dtos.Products;
using ECommerce.Models.ViewModels.Products;
using ECommerce.Services.Abstracts;
using ECommerce.Services.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Controllers;

public class ProductsController : Controller
{ 
    
   private readonly IProductService _productService;
   private readonly IMapper _mapper;


   public ProductsController(IProductService productService, IMapper mapper)
   {
       _productService = productService;
       _mapper = mapper;

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
    public IActionResult Add(ProductAddViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        
        Product product = _mapper.Map<Product>(viewModel);
        _productService.Add(product);
        return RedirectToAction("Index","Home");
    }


    // Attribute
    [HttpGet]
    public IActionResult Detail(Guid id)
    {
        // SELECT * FROM Products Where Id = 2
        var product = _productService.GetById(id);
        return View(product);

    }


    /*[HttpGet]
    public IActionResult Update(Guid id)
    {

        var product = _productService.GetById(id);
        return View(product);
    }*/


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