using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observable
{
    public interface ISubject
    {
        public void registerObserver(IObserver o); //регистрирует наблюдателя
        public void removeObserver(IObserver o);
        public void notifyObservers();//оповещение наблюдателей о изменении состояния


    }
}
