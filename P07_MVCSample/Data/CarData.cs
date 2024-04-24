using P07_MVCSample.Models;
using System.Diagnostics;

namespace P07_MVCSample.Data
{
    public class CarData
    {
        // Verileri bir liste yapısı olarak manuel olarak tutacağım.

        public static List<Car> Cars = new List<Car>()
        {
            new Car
            {
                CarId=1,
                BrandName="Volvo",
                Family="XC70",
                Year=1995
            },
            new Car
            {
                CarId=2,
                BrandName="Volvo",
                Family="XC90",
                Year=2000
            },
            new Car
            {
                CarId=3,
                BrandName="Volkswagen",
                Family="Beetle",
                Year=1974
            },
            new Car
            {
                CarId=4,
                BrandName="Bugatti",
                Family="Chiron",
                Year=2000
            },
            new Car
            {
                CarId=5,
                BrandName="Renault",
                Family="Safrane",
                Year=1998
            }
        };
    }
}

//carlist.Add(new Cars() { CarId = 1, BrandName = "Volvo", Family = "XC70", Year = 1995 });
//carlist.Add(new Cars() { CarId = 2, BrandName = "Volkswagen", Family = "Beetle 1303", Year = 1974 });
//carlist.Add(new Cars() { CarId = 3, BrandName = "Bugatti", Family = "Chiron", Year = 2015 });
//carlist.Add(new Cars() { CarId = 4, BrandName = "Ferrari", Family = "California", Year = 2022 });
//carlist.Add(new Cars() { CarId = 5, BrandName = "Dodge", Family = "Charger SRT 8", Year = 1970 });