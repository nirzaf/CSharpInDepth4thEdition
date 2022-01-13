using System;
using System.ComponentModel;

namespace Chapter15
{
    [Description("Listing 15.12")]
    class PropertyPatterns2
    {
        public class Customer
        {
            public string? Name { get; set; }
            public Address? Address { get; set; }
        }

        public class Address
        {
            public string? Country { get; set; }
        }

        static void Main()
        {
            Greet(new Customer { Address = new Address { Country = "UK" } });
            Greet(new Customer { Address = new Address { Country = "USA" } });
            Greet(new Customer { Address = new Address { Country = "France" } });
            Greet(new Customer { Address = new Address() });
            Greet(new Customer());
            Greet(null);
        }

        static void Greet(Customer? customer)
        {
            string greeting = customer switch
            {
                { Address: { Country: "UK" } } => "Welcome, customer from the United Kingdom!",
                { Address: { Country: "USA" } } => "Welcome, customer from the USA!",
                { Address: { Country: string country } } => $"Welcome, customer from {country}!",
                { Address: { } } => "Welcome, customer whose address has no country!",
                { } => "Welcome, customer of an unknown address!",
                _ => "Welcome, nullness my old friend!"
            };
            Console.WriteLine(greeting);
        }
    }
}
