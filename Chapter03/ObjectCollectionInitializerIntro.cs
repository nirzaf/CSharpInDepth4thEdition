using System.Collections.Generic;
using System.ComponentModel;

namespace Chapter03
{
    [Description("Listing 3.1-3.3")]
    class ObjectCollectionInitializerIntro
    {
        public class Order
        {
            private readonly List<OrderItem> items = new List<OrderItem>();

            public string OrderId { get; set; }
            public Customer Customer { get; set; }
            public List<OrderItem> Items { get { return items; } }
        }

        public class Customer
        {
            public string Name { get; set; }
            public string Address { get; set; }
        }

        public class OrderItem
        {
            public string ItemId { get; set; }
            public int Quantity { get; set; }
        }

        static void Main()
        {
        }

        static void WithoutObjectAndCollectionInitializers()
        {
            var customer = new Customer();
            customer.Name = "Jon";
            customer.Address = "UK";
            var item1 = new OrderItem();
            item1.ItemId = "abcd123";
            item1.Quantity = 1;
            var item2 = new OrderItem();
            item2.ItemId = "abcd123";
            item2.Quantity = 2;
            var order = new Order();
            order.OrderId = "xyz";
            order.Customer = customer;
            order.Items.Add(item1);
            order.Items.Add(item2);
        }

        static void WithObjectAndCollectionInitializers()
        {
            var order = new Order
            {
                OrderId = "xyz",
                Customer = new Customer { Name = "Jon", Address = "UK" },
                Items =
                {
                    new OrderItem { ItemId = "abcd123", Quantity = 1 },
                    new OrderItem { ItemId = "fghi456", Quantity = 2 }
                }
            };
        }
    }
}
