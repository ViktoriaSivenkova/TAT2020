using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dev5
{
    public class CatalogHelpers
    {
        private List<Car> CarsList => CarCatalog.GetInstance().CarsList;

        public int CountAll()
        {
            return CarsList.Sum(x => x.Amount);
        }

        public int CountTypes()
        {
            return CarsList.GroupBy(x => x.Brand).Count();
        }

        public double AveragePrice()
        {
            return CarsList.Average(x => x.UnitPrice);
        }

        public double AveragePriceType(string brand)
        {
            brand = brand.ToLower();
            return CarsList.Where(x => x.Brand.ToLower() == brand).Average(x => x.UnitPrice);
        }

        public void AddToCatalog(Car car)
        {
            bool isTheSameCar = CarsList.Any(i => (i.Brand == car.Brand) && (i.Model == car.Model) && (i.UnitPrice == car.UnitPrice));
            
            if (isTheSameCar)
            {
                Car carFromList = CarsList.First(i => (i.Brand == car.Brand) && (i.Model == car.Model) && (i.UnitPrice == car.UnitPrice));
                carFromList.Amount += car.Amount;
            }
            else
            {
                CarsList.Add(car);
            }
        }
    }
}
