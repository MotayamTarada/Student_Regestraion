using System;
using System.Collections.Generic;

#nullable disable

namespace CoreTestApplication.Entities
{
    public partial class TeacherStudent
    {
        public int StudentTeacherId { get; set; }
        public int StudentId { get; set; }
        public int TeacherId { get; set; }
        public int Marks { get; set; }

        public virtual Student Student { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
