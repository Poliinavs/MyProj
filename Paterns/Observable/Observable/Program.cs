using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    class Program
    {
        static void Main(string[] args)
        {
           WheatherData wheatherData = new WheatherData();//объект
            CurrentCondition currentCondition = new CurrentCondition(wheatherData);
            wheatherData.setMeasurements(12,22);
            wheatherData.setMeasurements(22, 32);
        }
    }
}