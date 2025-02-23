using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class EmployeesType
    {
        public EmployeesType()
        {
            Employees = new HashSet<Employee>();
        }

        public int EmployeeTypeId { get; set; }
        public string EmployeeName { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
