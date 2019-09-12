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
    public class HRModel : PageModel
    {
        public List<Employees> Employees { get; set; } = new List<Employees>();
        public void OnGet()
        {
            EmployeeRepository employeeRepository = new EmployeeRepository();
            Employees = employeeRepository.GetAllEmployees();
        }
    }
}