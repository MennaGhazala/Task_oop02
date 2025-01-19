namespace Task_oop02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order() { };

            Console.WriteLine("Enter Order ID:");
            order.OrderId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer Name:");
            order.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter Order Amount:");
            order.OrderAmount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter Order Type :");
            
            string OrederType  = Console.ReadLine();
            order.AssignOrderProcessor(OrederType);

            Console.WriteLine($" {order.OrderProcessor }");

        }


    }
}
