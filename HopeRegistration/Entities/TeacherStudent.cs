using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class TeacherStudent
    {
        public int TeacherStudentId { get; set; }
        public int StudentId { get; set; }
        public int GradeNumberId { get; set; }
        public int SectionNumberId { get; set; }

        public virtual GradeNumber GradeNumber { get; set; }
        public virtual SectionNumber SectionNumber { get; set; }
        public virtual Student Student { get; set; }
    }
}
