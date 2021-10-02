using System;
using System.Collections.Generic;
using System.Text;

namespace Hair_Happy_App.Models
{
    class Booking
    {
        public long Id { get; set; }
        public Boolean IsGuest { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string HairType { get; set; }
        public string HairLength { get; set; }
        public int[] OtherCondition { get; set; }
        public Service[] BookingService { get; set; }
        public DateTime Schedule { get; set; }
        public double FullPrice { get; set; }
        public string Status { get; set; }
        

    }
}
