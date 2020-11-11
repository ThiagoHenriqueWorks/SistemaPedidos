using System;
using SistemaPedidos.Entities.Enums;

namespace SistemaPedidos.Entities
{
    class Order
    {
        public int Id { get; set; }
        public int Moment { get; set; }

        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return Id + ", " + Moment + ", " + Status;
        }

    }
}
