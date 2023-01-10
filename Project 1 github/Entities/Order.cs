using System;
using Project_1_github.Entities.Enuns;

namespace Project_1_github.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id 
                + ", "
                + Moment
                + ", "
                + Status;
        }


    }
}
