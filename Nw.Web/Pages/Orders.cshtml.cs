using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Nw.DataAccess;
using Nw.Entities;

namespace Nw.Web.Pages
{
    public class OrdersModel : PageModel
    {
        public List<Orders> Orders { get; set; } = new List<Orders>();
        public void OnGet()
        {
            OrderRepository orderRepository = new OrderRepository();
            Orders = orderRepository.GetAllOrders();
        }
    }
}