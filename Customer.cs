using System;

namespace CreatingTypesTask
{
    public class Customer
    {
        private string _customerName;
        private string _customerAddress;
        private string _customerPhone;

        public Customer()
        {
        }

        public Customer(string customerName, string customerAddress, string customerPhone)
        {
            _customerName = customerName;
            _customerAddress = customerAddress;
            _customerPhone = customerPhone;
        }


        public string CustomreName
        {
            get => _customerName;
            set => _customerName = value;
        }

        public string CustomerAddress
        {
            get => _customerAddress;
            set => _customerAddress = value;
        }

        public string CustomerPhone
        {
            get => _customerPhone;
            set => _customerPhone = value;
        }


        public override string ToString()
        {
            return String.Format("Customer name: {0,-20} Customer address: {1,-20} Customer phone: {2,-20} \n",
                _customerName,_customerAddress,_customerPhone);
        }
    }
}