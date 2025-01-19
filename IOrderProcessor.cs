using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_oop02
{
     public interface IOrderProcessor
    {
        void ProcessOrder();
       decimal CalculateDiscount(decimal orderAmount);
    }
}
