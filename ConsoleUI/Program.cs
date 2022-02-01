using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest1();
            //ColorTest();
            //BrandTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.BrandName);
            }
            brandManager.Add(new Brand { BrandName = "Opel" });
            brandManager.Update(new Brand { BrandId = 11, BrandName = "Mercedes" });
            brandManager.Delete(new Brand { BrandId = 11, BrandName = "Mercedes" });
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll())
            {
                Console.WriteLine(color.ColorName);
            }
            colorManager.Add(new Color { ColorName = "Eflatun" });
            colorManager.Update(new Color { ColorId = 11, ColorName = "Açık Mavi" });
            colorManager.Delete(new Color { ColorId = 11, ColorName = "Açık Mavi" });
        }
    }
}
 

        //private static void CarTest1()
        //{
        //    CarManager carManager = new CarManager(new EfCarDal());
        //    foreach (var car in carManager.GetCarsByBrandId(1))
        //    {
        //        Console.WriteLine(car.BrandId + " " + car.Description);
        //    }
        //    foreach (var car in carManager.GetCarsByColorId(2))
        //    {
        //        Console.WriteLine(car.ColorId + " " + car.Description);

        //    }

        //    Console.WriteLine("********AddCars***********");

        //    Car car1 = new Car
        //    {
        //        BrandId = 1,
        //        ColorId = 1,
        //        ModelYear = 2020,
        //        DailyPrice = 0,
        //        Description = "Alfa Romeo"
        //    };

        //    carManager.Add(car1);

        //    Car car2 = new Car
        //    {
        //        BrandId = 1,
        //        ColorId = 1,
        //        ModelYear = 2005,
        //        DailyPrice = 0,
        //        Description = "a"
        //    };

        //    carManager.Add(car2);
        //}
    

