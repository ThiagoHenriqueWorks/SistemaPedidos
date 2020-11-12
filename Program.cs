﻿using System;
using SistemaPedidos.Entities;
using SistemaPedidos.Entities.Enums;
namespace SistemaPedidos
{
    class Program
    {
        static void Main(string[] args)
        {

            Order order = new Order
            {
                Id = 1000,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment


            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();
            Console.WriteLine(txt);

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");  
            Console.WriteLine(os);
        }
    }
}
