using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _carList;
        Car tempCar=null;
        public InMemoryCarDal()
        {
            _carList = new List<Car>{};
            
        }
        public void Add(Car car)
        {
            _carList.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _carList.SingleOrDefault(p => p.CarId == car.CarId);
            _carList.Remove(carToDelete);
            Console.WriteLine("Car is deleted which is Id {0}", car.CarId);
            Console.WriteLine("----------------------------------------");
        }

        public List<Car> GetAll()
        {
            return _carList;
        }

        public List<Car> GetById(int carId)
        {
            return _carList.Where(p => p.CarId == carId).ToList(); 
        }
         
        public void Update(int carId, Car car, int carIdNew, Car newCar)
        {
                tempCar = new Car();
                tempCar.Description = car.Description;
                car.CarId = newCar.CarId;
                car.BrandId = newCar.BrandId;
                car.ColorId = newCar.ColorId;
                car.DailyPrice = newCar.ColorId;
                car.Description = newCar.Description;


            Console.WriteLine("Car is updated which is Id {0}", car.CarId);
            Console.WriteLine("New Car is description is {0} to {1}", tempCar.Description,car.Description);
            Console.WriteLine("------------------------------------------");
        }
    }
}
