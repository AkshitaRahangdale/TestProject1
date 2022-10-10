using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    public class Product
    {
        private int id, price;
        private string name;
        public Product(int id, int price, string name)
        {
            this.id = id;
            this.price = price;
            this.name = name;
        }
        public string Print()
        {
            return $"{id}{name}{price}";
        }

        static void Main(string[] args)
        {
            Product p1 = new Product(123, 56, "key");
            Product p2 = new Product(1236, 46, "ray");
            Console.WriteLine(p1.Print());
            Console.WriteLine(p2.Print());
        }
    }
}