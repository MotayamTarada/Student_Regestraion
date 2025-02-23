using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Models
{
    public class StudentDetailsModel
    {
        public string StudentName { get; set; }
        public string  TeacherName { get; set; }

        public string ClassName { get; set; }

        public string SectionName { get; set; }

        public int GradeNumberId { get; set; }

        public int SectionId { get; set; }
    }
}
