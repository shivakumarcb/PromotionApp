using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Order
    {
        private List<Product> Products= new List<Product>();

        public void AddOrders(string item, int quantity)
        {
            if (quantity >= 0)
            {
                for (int i = 1; i <= quantity; i++)
                {
                    Product p = new Product(item);
                    Products.Add(p);
                }
                
            }
        }

        public decimal GetOrderFinalPrice()
        {
            decimal origprice = Products.Sum(x => x.Price);
            return origprice ;
        }
    }
}
