using Microsoft.AspNetCore.Mvc;
using YetgimM.WebMvc.Models;

namespace YetgimM.WebMvc.Controllers;

//http://localhost:5284/Cars/Index
public class CarsController : Controller
{
    List<Car> cars = new List<Car>() {
            new Car(){
                Brand = "Ford",
                ModelName = "Focus",
                Color = "Yeşil",
                FuelType = "Dizel",
                Image = "image.jpg",
                Price = 355000,
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
                Price = 2225500,
                Transmission = "Otomatik",
                Year = 2014
            },
            new Car(){
                Brand = "Renault",
                ModelName = "Megane",
                Color = "Mavi",
                FuelType = "Benzinli",
                Image = "image.jpg",
                Price = 1456000,
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
    
    
    public IActionResult Index()
    {
        Car car = new Car()
        {
            Brand = "Mercedes",
            ModelName = "Benz",
            Color = "Siyah",
            FuelType = "Benzinli",
            Image = "image.jpg",
            Price = 3255000,
            Transmission = "Otomatik",
            Year = 2021
        };
        cars.Add(car);
        
        return View(cars);
    }


    // todo: Model yılı 2014 olan araçları filtreleyen fonksiyon
    // Language integrated Query 
    public IActionResult Filter1()
    {
        /*
        List<Car> filteredList = new List<Car>();

        foreach (Car car in cars)
        {
            if (car.Year == 2014)
            {
                filteredList.Add(car);
            }
        }
        */


        List<Car> filteredList = cars.Where(car => car.Year == 2014).ToList();
        return View(filteredList);
    }

    // todo: Fiyat aralığı 150000 ile  1500000 aralığında olan arabaları listeleyen kod
    public IActionResult Filter2()
    {
        List<Car> filteredList = cars.Where(car => car.Price >= 150000 && car.Price <= 1500000).ToList();

   /*foreach (Car car in cars)
   {
       if (car.Price >=150000 && car.Price <= 1500000)
       {
           filteredList.Add(car);
       }
   }*/

   /*ViewBag.Total = filteredList.Sum(x => x.Price);
   ViewBag.Ortalama = filteredList.Average(x => x.Price);*/
   
   /*TempData["Total"] =  filteredList.Sum(x => x.Price);
   TempData["Ortalama"] =  filteredList.Average(x => x.Price);*/
   
   
   /*ViewData["Total"] =  filteredList.Sum(x => x.Price);
   ViewData["Ortalama"] =  filteredList.Average(x => x.Price);*/

   CarViewModel viewModel = new CarViewModel()
   {
       Cars = filteredList
   };
   return View(viewModel);
    }


    
    
    public IActionResult Filter3()
    {
        var filtered = cars.OrderBy(x => x.Brand).ToList();
        return View(filtered);

    }

    public IActionResult Deneme()
    {
        Employee emo = new Employee()
        {
            CreatedDate = "",
            
        };
        
        
        
        return NotFound();
    }
    
    
    
}