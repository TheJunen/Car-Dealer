using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDealer
{
    internal class Car : CarDealerCarList
    {
        internal string Name { get; private set; }
        internal int BuyPrice { get; private set; }
        internal int RentPrice {  get; private set; }
        internal string Warranty { get; private set; }
        internal string Engine { get; private set; }
        internal string Color { get; private set; }
        internal string Description { get; private set; }

        public Car(string name, int buyprice, int rentprice, string warranty, string engine, string color, string description)
        {
            Name = name;
            BuyPrice = buyprice;
            RentPrice = rentprice;
            Warranty = warranty;
            Engine = engine;
            Color = color;
            Description = description;
        }

        internal void WriteOutCarInfo()
        {
            Console.WriteLine($"Navn: {Name}, Kjøpspris: {BuyPrice}, Leiepris: {RentPrice}, Garanti: {Warranty}, Motor. {Engine}, Farge: {Color}, Beskrivelse: {Description}");
        }


    }
}
