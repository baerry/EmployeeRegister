using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Security.AccessControl;

namespace EmployeeRegister.DataAccessLayer
{
    public class EmployeesContex : DbContext
    {

        public DbSet<Models.Employee> Employees { get; set; }
        public EmployeesContex() : base("name=DefaultConnection")
        {
            
        }
           
    }

        
    


}

