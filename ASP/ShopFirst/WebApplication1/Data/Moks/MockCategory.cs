using WebApplication1.Data.interfaces;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.Moks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get {
                return new List<Category>() { 
                new Category{categoryName="Электромобили", desc="Современный вид"},
                 new Category{categoryName="классические автомобили", desc="C двигателем"}
                };

            }
        }
    }
}
