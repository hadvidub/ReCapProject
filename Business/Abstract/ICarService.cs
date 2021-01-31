using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetById(int carId);

        void Add(Car car);
        void Update(int carId, Car car, int carIdNew, Car newCar);
        void Delete(Car car);

    }
}
