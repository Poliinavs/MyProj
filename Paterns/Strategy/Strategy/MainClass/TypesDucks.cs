using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MallardDuck : Duck
    {
       public MallardDuck()
        {
            quackBehavior = new MuteQuack();//при вызове интерфейсной ссылки будем вызывать переопределенный метод
            flyBehavior = new FlyWithWings();

          }
        public override void display()
        {
           
            Console.WriteLine("I'm Mallard duck");
        }
    }
}
