using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface IQuackBehavior
    {
        public void Quack();

    }
    internal class MuteQuack:IQuackBehavior
        {
        public void Quack() {
            Console.WriteLine("Quack");
        }
        }
    internal class Squek : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Squek");
        }
    }

}
