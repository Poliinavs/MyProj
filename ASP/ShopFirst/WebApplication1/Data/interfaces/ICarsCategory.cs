using System.Collections.Generic;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
