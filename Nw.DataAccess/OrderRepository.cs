using Nw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nw.DataAccess
{
    public class OrderRepository
    {
        private NorthwindModel model;
        public OrderRepository()
        {
            model = new NorthwindModel();
        }
        public List<Orders> GetAllOrders()
        {
            return model.Orders.ToList();
        }
    }
}
