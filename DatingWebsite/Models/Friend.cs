using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatingWebsite.Models
{
    public class Friend
    {
        [Key]
        public string FID { get; set; }

        public virtual User User { get; set; }
    }
}