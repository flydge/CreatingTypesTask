using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CreatingTypesTask
{
    public class Shop
    {
        private Order _order;
        private bool _foodCheck;
        

        public Shop(Order order)
        {
            _order = order;
            ProductCheck();
        }
       
        public Order Order => _order;


        void ProductCheck()
        {
            _foodCheck = false;
            int enumPosition = 0;
            
            foreach (var enumProductName in Enum.GetNames(typeof(EnumProducts)))
            {
               
                if (String.Equals(enumProductName,_order.Product.ProductName,StringComparison.OrdinalIgnoreCase))
                {
                    _foodCheck = true;
                    ProductsSwitch(enumPosition);
                }
                enumPosition++;
               
            }
            
        }
        

        public enum EnumProducts
        {
            Fish,Meat,Bread
        }

        void ProductsSwitch(int enumPosition )
        {
            switch ((EnumProducts)enumPosition)
            {
                case EnumProducts.Bread:
                {
                    _order.Product.ProductDescription =
                        "Bread is a staple food prepared from a dough of flour and water, usually by baking. ";
                    _order.Product.ProductPrice = 132;
                    break;
                }
                case EnumProducts.Fish:
                {
                    _order.Product.ProductDescription =
                        "Fish are the gill-bearing aquatic craniate animals that lack limbs with digits. ";
                    _order.Product.ProductPrice = 400;
                    break;
                    
                }
                case EnumProducts.Meat:
                {
                    _order.Product.ProductDescription = "Meat is animal flesh that is eaten as food.";
                    _order.Product.ProductPrice = 350;
                    break;
                    
                }
                    
                default: throw new InvalidOperationException("Product is not available");
            }
        }


        public override string ToString()
        {

            string val;
                if (_foodCheck)
                {
                    val = "Order acepted"+"\n"+Order;
                }
                else
                {
                    val = "Product not found";
                }
                
                return String.Format(val);
        }
    }
    
}