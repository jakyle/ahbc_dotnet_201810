using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ahbc.Class.FortyFull.Models
{
    public class DemoInputModel
    {
        [Required]
        [MaxLength(50)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [MaxLength(50)]
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }

        [DisplayName("Is Active")]
        public bool IsActive { get; set; }
    }
}