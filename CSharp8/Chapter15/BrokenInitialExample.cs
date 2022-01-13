using System;
using System.ComponentModel;

// This example is meant to be in C# 7, so disable the C# 8 features.
#nullable disable

namespace NullableReferences
{
    [Description("Listing 15.1")]
    class BrokenInitialExample
    {
        public class Customer
        {
            public string Name { get; set; }
            public Address Address { get; set; }
        }

        public class Address
        {
            public string Country { get; set; }
        }

        static void Main()
        {
            Customer customer = new Customer { Name = "Jon" };
            Console.WriteLine(customer.Address.Country);
        }
    }
}
