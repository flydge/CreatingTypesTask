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

           // Shop newOrderInShop = new Shop(new Order(customersList[0],new Product("Fish"),new DateTime(2017,1,11,12,30,0)));
          //  Console.WriteLine(newOrderInShop);
            
            Order order = new Order(customersList[1],new Product(200,"potato","food"),new DateTime(2018,1,12,20,30,0) );
            Order order2 = new Order(customersList[1],new Product(200,"potato","food"),new DateTime(2018,1,12,20,30,0) );
            Console.WriteLine(order);

        }
    }
}