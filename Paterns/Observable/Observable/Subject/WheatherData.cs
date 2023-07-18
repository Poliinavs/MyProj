using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public class WheatherData : ISubject
    {
        private ArrayList observers;//хранение наблюдателей
        private float temperature;
        private float humidity;

        public WheatherData()
        {
            observers = new ArrayList();
        }
        public void notifyObservers()
        {
           for (int i=0; i<observers.Count; i++)
            {
               IObserver observer= (IObserver)observers[i];
                observer.update(temperature, humidity);
            }
        }

        public void registerObserver(IObserver o)
        {
           observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
           int i = observers.IndexOf(o);
            if(i>=0) { observers.Remove(i); }
        }

        public void meassurementsChanged() //оповещение наблюдателей о появлении новых данных
        {
            notifyObservers();
        }
        public void setMeasurements(float temp, float humidity)
        {
            this.temperature = temp;
            this.humidity = humidity;
            meassurementsChanged();
        }
    }
}
