using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Order
    {
        private List<Product> Products;

        public void AddOrders(string item, int quantity)
        {
            if (quantity >= 0)
            {
                for (int i = 1; i <= quantity; i++)
                {
                    Products.Add(new Product(item));
                }
                
            }
        }
    }
}
