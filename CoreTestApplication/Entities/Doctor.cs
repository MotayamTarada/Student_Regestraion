using System;
using System.Collections.Generic;

#nullable disable

namespace CoreTestApplication.Entities
{
    public partial class Doctor
    {
        public Doctor()
        {
            Students = new HashSet<Student>();
        }

        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
