using System;
using System.ComponentModel;

namespace NullableReferences
{
    [Description("Listing 15.2")]
    class EverythingNonNullable
    {
        public class Customer
        {
            public string Name { get; set; }
            public Address Address { get; set; }

            public Customer(string name, Address address) =>
                (Name, Address) = (name, address);
        }

        public class Address
        {
            public string Country { get; set; }

            public Address(string country) =>
                Country = country;
        }

        static void Main()
        {
            Customer customer = new Customer("Jon", new Address("UK"));
            Console.WriteLine(customer.Address.Country);
        }
    }
}
