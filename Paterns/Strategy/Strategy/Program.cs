using Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
        
         Duck mallard= new MallardDuck();
            mallard.perfomQuack();
            mallard.perfomFly();

            mallard.setFlyBehavior(new FlyNoWay());//изменение повдения
            mallard.perfomFly();




        }
    }
}