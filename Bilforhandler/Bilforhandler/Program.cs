//Bilforhandler: Lag en applikasjon som simulerer en bilforhandler. Du kan ha klasser for biler, kunder og forhandlere.
//Kunden kan kjøpe eller leie biler, og forhandleren kan legge til nye biler i lageret sitt og behandle salg og leieavtaler.

namespace CarDealer
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer1 = new Customer("Arne", 20000);
            var ferrari1 = new Car("Ferrari Ultimate N2", 15000, 3000, "2 år", "N1 Motor", "blå", "Kjør fra 0km/t til 100km/t på 2 sekunder.");
            var buggati1 = new Car("Buggati infinite SS2", 18000, 4500, "5 år", "Flex Motor", "Rød", "Kjør i stil");
            //customer1.BuyCar(ferrari1.BuyPrice);
            customer1.WriteOutCustomerInfo();
            var cardealer = new CarDealer();
            cardealer.AddCarToList(ferrari1);
            cardealer.AddCarToList(buggati1);
            var RemoveCar1 = "Ønsker du å fjerne bil 1 fra listen? skriv 'ja', skriv 'nei' hvis ikke";
            Console.WriteLine(RemoveCar1);
            var answer = Console.ReadLine();
            if (answer.ToLower() == "ja")
            {
                cardealer.RemoveCarFromList(ferrari1);
                var RemoveCarConfirmation = $"Du har fjernet {ferrari1.Name}";
                Console.WriteLine(RemoveCarConfirmation);
            }
            cardealer.WriteOutCarList();
        }
    }
}
