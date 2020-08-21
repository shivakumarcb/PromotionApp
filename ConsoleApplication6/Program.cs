using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
           
            Console.WriteLine("Enter product A quantity ");
            int qnty = Convert.ToInt16(Console.ReadLine());
            order.AddOrders("A", qnty);

            Console.WriteLine("Enter product B quantity ");
             int qnty2 = Convert.ToInt16(Console.ReadLine());
            order.AddOrders("B", qnty2);

            Console.WriteLine("Enter product C quantity ");
            int qnty3 = Convert.ToInt16(Console.ReadLine());
            order.AddOrders("C", qnty3);

            Console.WriteLine("Enter product D quantity ");
            int qnty4 = Convert.ToInt16(Console.ReadLine());
            order.AddOrders("D", qnty4);
         
             
            

        }
    }
}
