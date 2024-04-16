using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarDealer
{
    internal class CarDealer 
    {
        private List<Car> listOfCars = new List<Car>();

        internal void AddCarToList(Car car)
        {
            listOfCars.Add(car);
        }

        internal void RemoveCarFromList(Car car) 
        {
            listOfCars.Remove(car);
        }

        internal void WriteOutCarList()
        {
            string ListeAvBilerTekst = "Liste av biler hos bilforhandler:";
            Console.WriteLine(ListeAvBilerTekst);
            foreach (Car car in listOfCars)
            {
                car.WriteOutCarInfo();
            }
        }
    }
}
