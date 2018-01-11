using System;
using System.Collections.Generic;

namespace CreatingTypesTask
{
    public class Order
    {
        private Customer _customer;
        private DateTime _orderDateTime;
        private DateTime _deliveryDateTime;
        private List<Product> _productsList;

        public Order(Customer customer, DateTime deliveryDateTime, params Product[] products)
        {
            _productsList = new List<Product>();
            _customer = customer;
            _deliveryDateTime = deliveryDateTime;
            foreach (var product in products)
            {
                _productsList.Add(product);
            }
           
        }


        public List<Product> ProductsList
        {
            get => _productsList;
            set => _productsList = value;
        }


        public DateTime OrderDateTime => _orderDateTime = DateTime.Now;

        public Customer Customer
        {
            get => _customer;
            set => _customer = value;
        }

        public DateTime DeliveryDateTime
        {
            get => _deliveryDateTime;
            set => _deliveryDateTime = value;
        }


        public override string ToString()
        {
            string productList = "";
            int fullCost = 0;
            foreach (var product in _productsList)
            {
                productList += product+"";
                fullCost += product.ProductPrice;
            }
            return String.Format(productList+"full cost: {0} \n"+Customer+
                                 "Order Date-Time:{1,-20} Delivery Date-Time:{2,-20}",
                fullCost, OrderDateTime,_deliveryDateTime);
        }
    }
}