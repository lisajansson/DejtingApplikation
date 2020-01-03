using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatingWebsite.Models
{
    public class Post
    {
        [Key]
        public string PID { get; set; }
        public string content { get; set; }
        public string date { get; set; }
        public virtual User User { get; set; }
    }
}