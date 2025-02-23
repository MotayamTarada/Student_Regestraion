using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class GradeNumber
    {
        public GradeNumber()
        {
            TeacherGradeNumbers = new HashSet<TeacherGradeNumber>();
            TeacherStudents = new HashSet<TeacherStudent>();
        }

        public int GradeNumberId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TeacherGradeNumber> TeacherGradeNumbers { get; set; }
        public virtual ICollection<TeacherStudent> TeacherStudents { get; set; }
    }
}
