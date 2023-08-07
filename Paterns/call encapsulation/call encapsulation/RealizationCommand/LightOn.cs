using call_encapsulation.Classes;
using call_encapsulation.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace call_encapsulation.RealizationCommand
{
    public class LightOn : ICommand1
    {
        Light Light;
        public LightOn(Light Light) {
        this.Light=Light;
        }

        public void Execute()
        {
            Light.LightOn();
        }
    }
}
