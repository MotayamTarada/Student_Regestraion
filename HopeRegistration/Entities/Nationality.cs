using System;
using System.Collections.Generic;

#nullable disable

namespace HopeRegistration.Entities
{
    public partial class Nationality
    {
        public Nationality()
        {
            Students = new HashSet<Student>();
        }

        public int NationalityId { get; set; }
        public string NationalityName { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
