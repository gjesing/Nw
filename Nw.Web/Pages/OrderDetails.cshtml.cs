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
    public class OrderDetailsModel : PageModel
    {
        public Orders Order { get; set; }
        public List<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        public IActionResult OnGet(int id)
        {
            OrderRepository orderRepository = new OrderRepository();
            Order = orderRepository.GetOrderById(id);
            return Page();
        }
    }
}