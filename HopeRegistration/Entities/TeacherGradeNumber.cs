using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class TeacherGradeNumber
    {
        public int TeacherGraderNumberId { get; set; }
        public int GradeNumberId { get; set; }
        public int TeacherId { get; set; }
        public int SectionNumberId { get; set; }

        public virtual GradeNumber GradeNumber { get; set; }
        public virtual SectionNumber SectionNumber { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
