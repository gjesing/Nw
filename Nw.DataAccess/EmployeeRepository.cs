using Nw.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nw.DataAccess
{
    public class EmployeeRepository
    {
        private NorthwindModel model;
        public EmployeeRepository()
        {
            model = new NorthwindModel();
        }
        public List<Employees> GetAllEmployees()
        {
            return model.Employees.ToList();
        }
        public Employees GetEmployeeById(int id)
        {
            return model.Employees.Where(e => e.EmployeeId == id).First<Employees>();
        }
    }
}
