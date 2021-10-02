using System;
using System.Collections.Generic;
using System.Text;

namespace Hair_Happy_App.Models
{
    class Service
    {
        public long ServiceId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Cost { get; set; }
        public DateTime TimeSpent { get; set; }

    }
}
