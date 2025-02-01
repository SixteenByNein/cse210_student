using System;

class Program
{
    static void Main(string[] args)
    {

        Address ernieAddress = new Address();

        ernieAddress.SetAddress("123 Sesame Street", "New York", "New York", "USA");

        Customer ernie = new Customer();

        ernie.SetCustomer("Ernie", ernieAddress);

        Product rubberDuck = new Product();

        rubberDuck.SetProduct("Rubber Duckie", 00123, 4.99, 15);

        Product saxophone = new Product();

        saxophone.SetProduct("Saxophone", 00213, 56.99, 1);

        Order cart00 = new Order();


        cart00.SetOrder([rubberDuck, saxophone], ernie);

        cart00.PackingLabel();

        cart00.ShippingLabel();



        Address bertAddress = new Address();

        bertAddress.SetAddress("123 Sesame Street", "New York", "New York", "USA");

        Customer bert = new Customer();

        bert.SetCustomer("Bert", bertAddress);

        Product lemon = new Product();

        lemon.SetProduct("Lemon", 2252354, 0.55, 20);

        Product lightbulb = new Product();

        lightbulb.SetProduct("Lightbulb", 2323, 1.10, 4);

        Product lampPost = new Product();

        lampPost.SetProduct("Lamp Post", 022122, 123.99, 1);


        Order cart01 = new Order();

        cart01.SetOrder([lemon, lightbulb, lampPost], bert);

        cart01.PackingLabel();

        cart01.ShippingLabel();

Address lukeAddress = new Address();

        lukeAddress.SetAddress("1402 North Tuscan Road", "Moisture Farms", "Junland Wastes", "Tatooine");

        Customer luke = new Customer();

        luke.SetCustomer("Luke Skywalker", lukeAddress);

        Product powerConverter = new Product();

        powerConverter.SetProduct("Power Converter", 14541, 45.99, 3);

        Product astromech = new Product();

        astromech.SetProduct("Astromech Droid", 22, 411.99, 1);

        Product protocol = new Product();

        protocol.SetProduct("Protocol Droid", 30, 842.99, 1);


        Order cart02 = new Order();

        cart02.SetOrder([powerConverter, astromech, protocol], luke);

        cart02.PackingLabel();

        cart02.ShippingLabel();



    }
}