using Nw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nw.DataAccess
{
    public class OrderDetailRepository
    {
        private NorthwindModel model;
        public List<OrderDetails> GetOrderDetailsByOrderId(int id)
        {
            return model.OrderDetails.Where(o => o.OrderId == id).ToList();
        }
    }
}
