using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IFlyBehavior
{
        public void FLy();
}
   //реализуют поведение 
   public class FlyWithWings : IFlyBehavior
    {
       
        public void FLy()
        {
            Console.WriteLine("I fly whith wings");
        }
    }

    public class FlyNoWay : IFlyBehavior
    {
        public void FLy()
        {
            Console.WriteLine("I can't fly");
        }
    }


}
