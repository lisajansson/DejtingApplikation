using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DatingWebsite.Models
{
    public class User
    {
        [Key]
        public int UID { get; set; }

        public string username { get; set; }
        public string password { get; set; }
        public string forename { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
     // public VARBINARY(MAX) profilephoto { get; set; }
    }
}