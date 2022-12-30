using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpAPI.Model
{

 public  class BookingDates
 {
       public string Checkin { get; set; }
       public string Checkout { get; set; }
    }
  public class Bookings
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingDates bookingdates { get; set; }
        public string additionalneeds { get; set; }
        
    }

    public class Booked
    {
        public int bookingid { get; set; } 
        public Bookings bookings { get; set; }  
    }


}

