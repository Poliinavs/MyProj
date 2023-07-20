using Decorator.Additeves;
using Decorator.MainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
         CofeShop Latte = new Latte();
         Console.WriteLine(Latte.getDescription()+" Стоимость: "+ Latte.cost());

            Latte = new Mocha(Latte);
            Latte = new Sugar(Latte);
            Latte = new Sugar(Latte);
            Console.WriteLine(Latte.getDescription() + " Стоимость: " + Latte.cost());



        }
    }
}