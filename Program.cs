using System;
using System.Collections.Generic;

namespace CreatingTypesTask
{
    internal class Program
    {
        public static void Main(string[] args)
        {
       
            List<Customer> customersList = new List<Customer>()
            {
                new Customer("Artyom","Gomel","+375290000000"),
                new Customer("Oleg","Gomel","+37529112233"),
                new Customer("Nastya","Minsk","+37529112234")
            };
            
            List<Product> productsList = new List<Product>()
            {
                new Product(productName:"meat"),
                new Product(productName:"fish"),
                new Product(productName:"paprica")
            };
            
            List<Order> ordersList = new List<Order>()
            {
                new Order(customersList[0],new DateTime(2017,1,11,12,30,0),
                    productsList[0],productsList[1],productsList[2]),
                new Order(customersList[1],new DateTime(2017,2,13,12,30,0),
                    productsList[0]),
                new Order(customersList[0],new DateTime(2017,1,11,12,30,0),
                    productsList[2],productsList[0])
                
            };
          
           
            Shop newOrderInShop = new Shop(ordersList[0],ordersList[1],ordersList[2]);
            
            Console.WriteLine(newOrderInShop);
           

        }
    }
}