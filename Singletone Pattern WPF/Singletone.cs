using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;

namespace Singletone_Pattern_WPF
{
    sealed public class Singletone
    {
        static private Singletone _instance;
        private Singletone() { }
        static public Singletone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singletone();
                }
                return _instance;
            }
            set { }
        }
        public void AddCar(List<Car> Cars,Car car)
        {
            Cars.Add(car);
        }
        public void DeleteCar(List<Car> Cars, Car car)
        {
            Cars.Remove(car);
        }
    }

}
