﻿namespace Command.Entities
{
    using Interfaces;
    using System.Collections.Generic;

    public class Broker
    {
        private List<IOrder> orderList = new List<IOrder>();

        public void TakeOrder(IOrder order)
        {
            orderList.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (IOrder order in orderList)
            {
                order.Execute();
            }
            orderList.Clear();
        }
    }
}