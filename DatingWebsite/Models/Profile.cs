using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatingWebsite.Models
{
    public class Profile
    {
        [Key]
        public int PRID { get; set; }
        public virtual User User { get; set; }
        public virtual Post Post { get; set; }
    }
}