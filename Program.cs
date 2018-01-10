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

           /* Shop newOrderInShop = new Shop(new Order(customersList[0],
                new Product(productName:"notmeat"),new DateTime(2017,1,11,12,30,0)));*/    //product not found 
            Shop newOrderInShop = new Shop(new Order(customersList[0],
                new Product(productName:"meat"),new DateTime(2017,1,11,12,30,0))); //order numb=1
            Shop newOrderInShop2 = new Shop(new Order(customersList[0],
                new Product(productName:"meat"),new DateTime(2017,1,11,12,30,0))); //order numb=2
            Console.WriteLine(newOrderInShop);
           

        }
    }
}