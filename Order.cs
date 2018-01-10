using System;

namespace CreatingTypesTask
{
    public class Order
    {
        private static int _orderNumb;
        private Customer _customer;
        private Product _product;
        private DateTime _orderDateTime;
        private DateTime _deliveryDateTime;

        public Order(Customer customer, Product product, DateTime deliveryDateTime)
        {
            _customer = customer;
            _product = product;
            _deliveryDateTime = deliveryDateTime;
            _orderNumb++;
        }

        public DateTime OrderDateTime => _orderDateTime = DateTime.Now;

        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public Product Product
        {
            get => _product;
            set => _product = value;
        }

        public DateTime DeliveryDateTime
        {
            get => _deliveryDateTime;
            set => _deliveryDateTime = value;
        }

        public static int OrderNumb => _orderNumb;


        public override string ToString()
        {
            return String.Format(Product+Customer.ToString()+
                                 "Order Date-Time:{0,-20} Delivery Date-Time:{1,-20} OrderNumb:{2,-20}",
                OrderDateTime,_deliveryDateTime,_orderNumb);
        }
    }
}