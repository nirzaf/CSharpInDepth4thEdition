using NUnit.Framework;
using System;

namespace NullableReferences
{
    public class DamnItOperatorValidation
    {
        public class Customer
        {
            public string Name { get; }
            public Address? Address { get; }

            public Customer(string name, Address? address)
            {
                Name = name ?? throw new ArgumentNullException(nameof(name));
                Address = address;
            }
        }

        public class Address
        {
            public string Country { get; }

            public Address(string country)
            {
                Country = country ?? throw new ArgumentNullException(nameof(country));
            }
        }

        [Test]
        public void Customer_NameValidation()
        {
            Address address = new Address("UK");
            Assert.Throws<ArgumentNullException>(() => new Customer(null!, address));
        }

        [Test]
        public void Address_CountryValidation()
        {
            Assert.Throws<ArgumentNullException>(() => new Address(null!));
        }
    }
}
