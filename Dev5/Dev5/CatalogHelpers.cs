using System.Collections.Generic;
using System.Linq;

namespace Dev5
{
    public class CatalogHelpers
    {
        private List<Car> CarsList => CarCatalog.GetInstance().CarsList;

        /// <summary>
        /// Method that counts all cars in catalog
        /// </summary>        
        public int CountAll()
        {
            return CarsList.Sum(x => x.Amount);
        }

        /// <summary>
        /// Method that counts cars types in catalog
        /// </summary>   
        public int CountTypes()
        {
            return CarsList.GroupBy(x => x.Brand).Count();
        }

        /// <summary>
        /// Method that returns average price
        /// </summary> 
        public double AveragePrice()
        {
            return CarsList.Average(x => x.UnitPrice);
        }

        /// <summary>
        /// Method that returns average price of any type
        /// </summary>
        public double AveragePriceType(string brand)
        {
            brand = brand.ToLower();
            return CarsList.Where(x => x.Brand.ToLower() == brand).Average(x => x.UnitPrice);
        }

        /// <summary>
        /// Method that adds new car to catalog
        /// </summary>
        /// <param name="car">Car for add</param>
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
