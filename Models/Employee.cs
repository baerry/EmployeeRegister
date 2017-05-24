using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeRegister.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Salery { get; set; }
        public string Department { get; set; }
        public string Position { get; set; }
    }
}