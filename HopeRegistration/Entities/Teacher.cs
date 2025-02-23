using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherGradeNumbers = new HashSet<TeacherGradeNumber>();
        }

        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Education { get; set; }
        public string Subject { get; set; }
        public double? Salary { get; set; }
        public string Mobile { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? Gender { get; set; }

        public virtual ICollection<TeacherGradeNumber> TeacherGradeNumbers { get; set; }
    }
}
