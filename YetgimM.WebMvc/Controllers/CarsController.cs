using Microsoft.AspNetCore.Mvc;
using YetgimM.WebMvc.Models;

namespace YetgimM.WebMvc.Controllers;

//http://localhost:5284/Cars/Index
public class CarsController : Controller
{
    public IActionResult Index()
    {
        Car[] cars =  {
            new Car(){
                Brand = "Ford",
                ModelName = "Focus",
                Color = "Yeşil",
                FuelType = "Dizel",
                Image = "image.jpg",
                Price = 255000,
                Transmission = "Manuel",
                Year = 2010
            },
            
            new Car(){
                Brand = "Ford",
                ModelName = "Fiesta",
                Color = "Yeşil",
                FuelType = "Dizel",
                Image = "image.jpg",
                Price = 155000,
                Transmission = "Otomatik",
                Year = 2011
            },
            new Car(){
                Brand = "Renault",
                ModelName = "Megane",
                Color = "Mavi",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 1255000,
                Transmission = "Otomatik",
                Year = 2014
            },
            new Car(){
                Brand = "Renault",
                ModelName = "Megane",
                Color = "Mavi",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 1255000,
                Transmission = "Otomatik",
                Year = 2014
            },
            new Car(){
                Brand = "Renault",
                ModelName = "Megane",
                Color = "Mavi",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 1255000,
                Transmission = "Otomatik",
                Year = 2014
            },
            new Car(){
                Brand = "Renault",
                ModelName = "Megane",
                Color = "Mavi",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 1255000,
                Transmission = "Otomatik",
                Year = 2014
            },
            
            new Car(){
                Brand = "Volkswagen",
                ModelName = "Passat (Aşiret Paket)",
                Color = "Siyah",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 2255000,
                Transmission = "Otomatik",
                Year = 2019
            },
        };
      
        
        return View(cars);
    }
}