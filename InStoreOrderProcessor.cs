using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_oop02
{
    public class InStoreOrderProcessor : IOrderProcessor
    {
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * (1 - 0.05M);
        }

        public void ProcessOrder()
        {
            Console.WriteLine(" in-store Process Order ");
        }
    }
}
