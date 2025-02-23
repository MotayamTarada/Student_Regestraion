using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string  LastName { get; set; }
        public bool Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Mobile { get; set; }

        public int NationalityId { get; set; }

        public string NationalityName { get; set; }

        public string   GenderDisplayName { get; set; }

        public string DateOfBirthDisplay { get; set; }

        public int GradeNumberId { get; set; }

        public string GradeNumberName { get; set; }

        public int SectionId { get; set; }

        public string SectionName { get; set; }
    }
}
