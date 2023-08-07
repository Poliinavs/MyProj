using call_encapsulation.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace call_encapsulation
{
    public class RemoteControl
    {
        ICommand1 slot;
        public void setCommand(ICommand1 command)
        {
            slot= command;
        }
        public void buttonWasPressed() => slot.Execute();


    }
}
