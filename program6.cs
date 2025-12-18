using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Product_id {get;set;}
    public string P_name {get; set;}

    public double price {get; set;}
}

class Program 
{
    static void Main()
    {
        List<Product> product = new List<Product>
        {
            new Product() {Product_id=1, P_name="book", price=34000},
            new Product() {Product_id=2, P_name="pen", price=2000}
        };

        Console.WriteLine("The Product detiles are");
        foreach (var p in product)
        {
            Console.WriteLine("Produc is "+p.Product_id+" name "+p.P_name + " price" +p.price);
        }
    }
}
