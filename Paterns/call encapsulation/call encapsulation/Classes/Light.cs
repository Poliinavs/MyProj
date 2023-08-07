using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_encapsulation.Classes
{
    public class Light
    {
        public void LightOn() => Console.WriteLine("Свет включен"); 
        public void LightOff() => Console.WriteLine("Свет выключен"); 
    }
}
