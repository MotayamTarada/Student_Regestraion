using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreTestApplication.Models
{
    public class UserModel
    {
        public int ID { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage = "This field is Required")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string LastName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string Email { get; set; }

        public bool Gender { get; set; }

        public string Mobile { get; set; }

        public string Comments { get; set; }

        public string CommentsColor { get; set; }
    }
}
