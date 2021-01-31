using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            
            foreach (var car in carManager.GetAll()) 
            {
                Console.WriteLine(car.Description);
            }
            
            Car car1 = new Car
            {
                CarId = 1,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 1500,
                ModelYear = "2001",
                Description = "Nissan"
            };
            Car car2 = new Car
            {
                CarId = 2,
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 1500,
                ModelYear = "2018",
                Description = "Ford"
            };

            Car car3 = new Car();
            car3.CarId = 3;
            car3.ColorId = 2;
            car3.BrandId = 1;
            car3.DailyPrice = 1580;
            car3.ModelYear = "2018";
            car3.Description = "Suzuki";
            
            carManager.Delete(car1);
            carManager.Update(car1.CarId, car1, car3.CarId, car3);

        }
    }
}
