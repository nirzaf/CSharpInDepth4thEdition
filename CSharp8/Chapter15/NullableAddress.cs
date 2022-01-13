using System;
using System.ComponentModel;

namespace NullableReferences
{
    [Description("Listing 15.3")]
    class NullableAddress
    {
        public class Customer
        {
            public string Name { get; set; }
            public Address? Address { get; set; }

            public Customer(string name) =>
                Name = name;
        }

        public class Address
        {
            public string Country { get; set; }

            public Address(string country) =>
                Country = country;
        }

        static void Main()
        {
            Customer customer = new Customer("Jon");
            // Suppressed to avoid it being constantly listed, but the intention of this listing
            // is to show that it *is* shown as a warning... comment out the pragma to see the warning.
#pragma warning disable CS8602 // Possible dereference of a null reference.
            Console.WriteLine(customer.Address.Country);
        }
    }
}
