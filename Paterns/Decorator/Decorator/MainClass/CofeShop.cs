using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class CofeShop //Bevarage 
    {
      public  string description = "Uncknow coffe";
     
        public string getDescription() { return description; }
        public abstract double cost();
    }
}
