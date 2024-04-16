using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Customer
    {
        private string Name;
        private int Budget;

        public Customer(string name, int budget)
        {
            Name = name;
            Budget = budget;
        }

        internal void BuyCar(int price)
        {
            Budget -= price;
        }

        internal void RentCar(int price)
        {
            Budget -= price;
        }

        internal void WriteOutCustomerInfo()
        {
            string cusInfo = $"Navn: {Name}, Budsjett: {Budget}";
            Console.WriteLine(cusInfo);
        }
    }
}
