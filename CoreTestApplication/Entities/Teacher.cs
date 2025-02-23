using System;
using System.Collections.Generic;

#nullable disable

namespace CoreTestApplication.Entities
{
    public partial class Teacher
    {
        public Teacher()
        {
            TeacherStudents = new HashSet<TeacherStudent>();
        }

        public int TeacherId { get; set; }
        public string TeacherName { get; set; }
        public string TeacherSubject { get; set; }

        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}
