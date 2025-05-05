namespace YetgimM.WebMvc.Models;

public class CarViewModel
{
    public List<Car> Cars { get; set; }
    public double Toplam => Cars.Sum(x => x.Price);
    public double Ortalama => Cars.Average(x => x.Price);
}