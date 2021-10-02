using System;
using System.Collections.Generic;
using System.Text;

namespace Hair_Happy_App.Models
{
    class Gallery
    {
        public long GalleryId { get; set; }
        public string Client { get; set; } //default = "Guest" for those w/o a profile
        public bool IsPublic { get; set; }
        public DateTime Date { get; set; }
        public string Url { get; set; }

    }
}
