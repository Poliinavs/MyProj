using call_encapsulation;
using call_encapsulation.Classes;
using call_encapsulation.RealizationCommand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            RemoteControl remoteControl= new RemoteControl();
            LightOn lightOn = new LightOn(new Light());
            remoteControl.setCommand(lightOn);
            remoteControl.buttonWasPressed();
        }
    }
}