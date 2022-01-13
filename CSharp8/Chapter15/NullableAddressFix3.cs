using System;
using System.ComponentModel;

namespace NullableReferences
{
    [Description("Listing 15.6")]
    class NullableAddressFix3
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
            if (customer.Address != null)
            {
                Console.WriteLine(customer.Address.Country);
            }
            else
            {
                Console.WriteLine("(Address unknown)");
            }
        }
    }
}
