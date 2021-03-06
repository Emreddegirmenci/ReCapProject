using Business.Concrete;
using Core.Utilities.Results;
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
            //CustomerTest();
            //RentalTest();

            //BrandGetAllTest();
            //BrandGetByIdTest();
            //BrandAddTest();
            //BrandUpdateTest();
            //BrandDeleteTest();

            //ColorGetAllTest();
            //ColorGetByIdTest();
            //ColorAddTest();
            //ColorUpdateTest();
            //ColorDeleteTest();

            //CarGetAllTest();
            //CarGetByIdTest();
            //CarAddTest();
            //CarUpdateTest();
            //CarDeleteTest();
            //GetCarDetailsTest();

        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            Rental rental = new Rental { CarId = 2, CustomerId = 2, RentDate = DateTime.Today, ReturnDate = DateTime.Now };
            var result = rentalManager.Add(rental);
            if (result.Success == false)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            Customer customer = new Customer { UserId = 1, CompanyName = "Wissen" };
            var result = customerManager.Add(customer);
            Console.WriteLine(result.Message);
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.ColorName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { Id = 18 });
        }

        private static void CarUpdateTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 18, BrandId = 1, ColorId = 2, DailyPrice = 2000, ModelYear = 2022, Description = "Mercedes'e zam geldi" });
        }

        private static void CarAddTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 1, ColorId = 2, DailyPrice = 1600, ModelYear = 2022, Description = "Mercedes" });
        }

        private static void CarGetByIdTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(5));
        }

        private static void CarGetAllTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                Console.WriteLine(car.Description);
            }
        }

        private static void ColorDeleteTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());


            colorManager.Delete(new Color { ColorId = 12 });
        }

        private static void ColorUpdateTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Update(new Color { ColorId = 12, ColorName = "Açık Mavi" });
        }

        private static void ColorAddTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            colorManager.Add(new Color { ColorName = "Eflatun" });
        }

        private static void ColorGetByIdTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            Console.WriteLine(colorManager.GetById(3));
        }

        private static void ColorGetAllTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void BrandDeleteTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 13, BrandName = "Mercedes" });
        }

        private static void BrandUpdateTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 13, BrandName = "Mercedes" });
        }

        private static void BrandAddTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Opel" });
        }

        private static void BrandGetByIdTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            Console.WriteLine(brandManager.GetById(2));
        }

        private static void BrandGetAllTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

      
    }
}
 

       
    

