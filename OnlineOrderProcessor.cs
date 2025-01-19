using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_oop02
{
    internal class OnlineOrderProcessor : IOrderProcessor
    {
      
        public decimal CalculateDiscount(decimal orderAmount)
        {
            return orderAmount * (1 - 0.1M);
            
        }

        public void ProcessOrder()
        {
            Console.WriteLine(" Online Process Order ");
        }
    }
}
