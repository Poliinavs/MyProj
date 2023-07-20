using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Additeves
{
    public class Mocha : CodimentDecorator
    {
        CofeShop cofeShop; 
        public Mocha(CofeShop cofeshop) {
            this.cofeShop = cofeshop;
        }
        public override double cost()
        {
           return 0.20 +cofeShop.cost();
        }

        public override string getDescription()//содержится название напитка и  все дополнения
        {
           return cofeShop.getDescription()+ ", Mocha";
        }
    }
}
