using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.MainObjects
{
    public class Latte : CofeShop
    {
        public Latte()
        {
            description = "Latte";
        }
        public override double cost()
        {
            return 2.99;
        }
    }
}
