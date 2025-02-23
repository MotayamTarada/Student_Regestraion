using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Models
{
    public class TeacherModel
    {
        public int TeacherId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string Education { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string Subject { get; set; }
        public double? Salary { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string Mobile { get; set; }
        public DateTime? HireDate { get; set; }
        public bool? Gender { get; set; }

        public string GenderDisplayName { get; set; }

        public int GradeNumberId { get; set; }

        public string GradeNumberName { get; set; }

        public int SectionId { get; set; }

        public string SectionName { get; set; }

    }
}
