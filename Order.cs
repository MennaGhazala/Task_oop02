using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_oop02
{
    internal class Order
    {
       

        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public decimal OrderAmount { get; set; }
        public IOrderProcessor OrderProcessor { get; set; }

        public void AssignOrderProcessor(string orderType)
             
        {

            decimal finalAmount = OrderAmount;
            decimal discountRate = 0;
            if (orderType=="Online")
            {
                discountRate = 0.10m;
                OrderProcessor = new OnlineOrderProcessor();
            }
            else if (orderType=="In-Store")
            {
                discountRate = 0.05m;
                OrderProcessor = new InStoreOrderProcessor();

                Console.WriteLine($"Order {OrderId} processed for {CustomerName}. Final amount after {discountRate * 100}% discount: {finalAmount:C}");
            }
           
        }
    }
}
