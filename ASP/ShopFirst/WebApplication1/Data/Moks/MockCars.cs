using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Moks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory categoryCars = new MockCategory();
   
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>() {
                    new Car { Name = "Tesla", shortDisc = "Современный тесла вид", longDesc = "Дорогой автомобиль электро", img = "", price = 4500, isFavourite = true, avaible = true, Category = categoryCars.AllCategories.First() },

                };

            }
            }
        IEnumerable<Car> IAllCars.getFavorCar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Car getObjectCar(int CarId)
        {
            throw new NotImplementedException();
        }
    }
}
