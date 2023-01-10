using Project_1_github.Entities;
using Project_1_github.Entities.Enuns;

namespace Project_1_github
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order()
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };


            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
            Console.WriteLine(txt);
            Console.WriteLine(OrderStatus.PendingPayment);
        }
    }
}










