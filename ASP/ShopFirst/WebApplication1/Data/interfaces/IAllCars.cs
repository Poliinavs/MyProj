using System.Collections;
using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> getFavorCar { get; set; }
        IEnumerable<Car> Cars{get; }
        Car getObjectCar(int CarId);

    }
}
