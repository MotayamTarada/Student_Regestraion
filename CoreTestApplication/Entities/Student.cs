using System;
using System.Collections.Generic;

#nullable disable

namespace CoreTestApplication.Entities
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
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int? DoctorId { get; set; }

        public virtual Doctor Doctor { get; set; }
        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}
