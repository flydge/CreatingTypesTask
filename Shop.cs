using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CreatingTypesTask
{
    public class Shop
    {
        private Order _order;
        private List<Order> _ordersList;
      
        

        public Shop(params Order[] order)
        {
            _ordersList = new List<Order>();
            foreach (var ord in order)
            {
                _order = ord;

                for (int i = 0; i < _order.ProductsList.Count; i++)
                {
                    var product = _order.ProductsList[i];
                    ProductCheck(product.ProductName, i);
                }
               
                _ordersList.Add(_order);
            }
        }
       
        public Order Order => _order;


        void ProductCheck(string productName, int productPosition)
        {
            int enumPosition = 0;
          
            foreach (var enumProductName in Enum.GetNames(typeof(EnumProducts)))
            {
                
                if (String.Equals(enumProductName, productName, StringComparison.OrdinalIgnoreCase))
                {
                    ProductsSwitch(enumPosition, productPosition);
                   
                    break;
                }
                    
                enumPosition++;
            }
            
        }
        

        public enum EnumProducts
        {
            Fish,Meat,Bread
        }

        void ProductsSwitch(int enumPosition, int productPosition )
        {
            switch ((EnumProducts)enumPosition)
            {
                case EnumProducts.Bread:
                {
                    _order.ProductsList[productPosition].ProductDescription =
                        "Bread is a staple food prepared from a dough of flour and water, usually by baking. ";
                    _order.ProductsList[productPosition].ProductPrice = 132;
                    break;
                }
                case EnumProducts.Fish:
                {
                    _order.ProductsList[productPosition].ProductDescription =
                        "Fish are the gill-bearing aquatic craniate animals that lack limbs with digits. ";
                    _order.ProductsList[productPosition].ProductPrice = 400;
                    break;
                    
                }
                case EnumProducts.Meat:
                {
                    _order.ProductsList[productPosition].ProductDescription = "Meat is animal flesh that is eaten as food.";
                    _order.ProductsList[productPosition].ProductPrice = 350;
                    break;
                    
                }
                    
                default: throw new InvalidOperationException("Product is not available");
            }
        }
       

        public override string ToString()
        {
            string val = "";
            
            foreach (var order in _ordersList)
            {
                
                val +="\nOrder acepted:"+"\n"+order+"\n";

            }
            return val;
        }
    }
    
}