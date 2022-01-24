using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, DailyPrice=800, Description="Alfa Romeo", ModelYear=2018},
                new Car{Id=2, BrandId=2, ColorId=1, DailyPrice=300, Description="Ford",  ModelYear=2004},
                new Car{Id=3, BrandId=2, ColorId=2, DailyPrice=500, Description="Toyota", ModelYear=2012},
                new Car{Id=4, BrandId=3, ColorId=2, DailyPrice=600, Description="Hyundai", ModelYear=2015},
                new Car{Id=5, BrandId=4, ColorId=3, DailyPrice=1500, Description="Porsche", ModelYear=2021},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
