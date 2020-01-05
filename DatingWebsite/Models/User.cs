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

        public string Username { get; set; } //EMAIL
        public string Forename { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }     
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; } // mm-dd-yyyy
     // public VARBINARY(MAX) profilephoto { get; set; }
    }
}