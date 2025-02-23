using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HopeRegistration.Models
{
    public class LoginModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "This field is Required")]
        public string Password { get; set; }
    }
}
