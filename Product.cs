using System;

namespace CreatingTypesTask
{
    public class Product
    {
        private int _productPrice;
        private string _productName;
        private string _productDescription;

       
        public Product(int productPrice = 0, string productName = "Simple name", string productDescription = "Simple Description")
        {
            _productPrice = productPrice;
            _productName = productName;
            _productDescription = productDescription;
        }

        public int ProductPrice
        {
            get => _productPrice;
            set => _productPrice = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public string ProductDescription
        {
            get => _productDescription;
            set => _productDescription = value;
        }

        public override string ToString()
        {
            return String.Format("Product name: {0,-20} Product price: {1,-20} Product description: {2,-20} \n",
                _productName,_productPrice,_productDescription);
        }
    }
}