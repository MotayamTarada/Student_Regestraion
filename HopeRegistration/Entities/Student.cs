using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class Student
    {
        public Student()
        {
            TeacherStudents = new HashSet<TeacherStudent>();
        }

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool? Gender { get; set; }
        public string Mobile { get; set; }
        public int? NationalityId { get; set; }

        public virtual Nationality Nationality { get; set; }
        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}
