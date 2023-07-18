using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class CurrentCondition : IObserver, IDislayElement
    {
        private float temp;
        private float humidity;
        private ISubject weatherData;
        public CurrentCondition(ISubject weather)
        {
            this.weatherData = weather;
            weatherData.registerObserver(this);//решистрация элемента в кач наблюдателя
        }
        public void display()
        {
            Console.WriteLine("Температура:" + temp + " влажн" + humidity);
        }

        void IObserver.update(float temp, float humidity)
        {
          this.temp = temp;
            this.humidity = humidity;
            display();
        }
    }
}
