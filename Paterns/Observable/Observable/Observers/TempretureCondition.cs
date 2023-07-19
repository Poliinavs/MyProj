using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable.Observers
{
    public class TempretureCondition : IObserver, IDislayElement
    {
        private float temp;
        private float humidity;
        private ISubject weatherData;
        public TempretureCondition(ISubject weather)
        {
            this.weatherData = weather;
            weatherData.registerObserver(this);//решистрация элемента в кач наблюдателя
        }
        public void display()
        {
            Console.WriteLine("Температура:" + temp +"TempretureCond");
        }

        void IObserver.update(float temp, float humidity)
        {
            this.temp = temp;
            this.humidity = humidity;
            display();
        }
    }
}
