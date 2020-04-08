using System;
using System.Collections.Generic;
using System.Text;

namespace Dev5
{
    class CarCatalog
    {
        private static CarCatalog instance;
        public List<Car> CarsList;
        private CarCatalog()
        {
            CarsList = new List<Car>();
        }

        public static CarCatalog GetInstance()
        {
            if (instance == null)
            {
                instance = new CarCatalog();
            }
            return instance;        
        }        
    }
}
