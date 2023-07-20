using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Espresso : CofeShop
    {
        public Espresso() {
           description = "Espresso";
        }
        public override double cost()
        {
            return 1.99;
        }
    }
}
