using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior flyBehavior;
      public  IQuackBehavior quackBehavior; //две переменные поведения
        public Duck() { }
        public abstract void display();
        public void perfomFly()
        {
            flyBehavior.FLy();
        }
        public void perfomQuack() //классы поведения, которым делегируют операции
        {
            quackBehavior.Quack();
        }
        public void swim()
        {
            Console.WriteLine("I can swim");
        }
        public void setFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }



    }
}
