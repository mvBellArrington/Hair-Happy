using System;
using System.Collections.Generic;
using System.Text;

namespace Hair_Happy_App.Models
{
    class Account
    {
        public string UserName { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string ProfileUrl { get; set; }
        public string[] HairBio { get; set; }
        public Gallery[] PersonalGallery { get; set; }

    }
}
