using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleton
{
    public class Single
    {
        private static Single UniqueInstance; //для хранения единственного экземпляра 
        private Single() { }
        public static Single getInstance() { 
            if (UniqueInstance == null)
        return new Single();
            return UniqueInstance;
        }
        public void Inform()
        {
            Console.WriteLine("Одиночка!");
        }

    }
}
