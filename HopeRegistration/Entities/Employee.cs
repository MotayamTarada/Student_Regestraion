using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }
        public DateTime? HireDate { get; set; }
        public int EmployeeTypeId { get; set; }

        public virtual EmployeesType EmployeeType { get; set; }
    }
}
