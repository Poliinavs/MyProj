using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data.interfaces;

namespace WebApplication1.Controllers
{
    public class CarsController:Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;

        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }

        public ViewResult List()
        {
            ViewBag.Category = "Some text";
            var cars = _allCars.Cars;
            return View(cars);
        }

    }
}
