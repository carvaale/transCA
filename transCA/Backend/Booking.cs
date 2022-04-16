using System;
using System.Collections.Generic;
using System.Text;

namespace transCA.Backend
{
    public class Booking
    {
        public Destination DestinationRequired { get;  set; }
        public Transportation TransportationDetails { get; set; }
        public string ProvinceName { get; set; }
        public string TransportWay { get; set; }

        public Booking(Destination d, Transportation t, string p,string o)
        {
            DestinationRequired = d;
            TransportationDetails = t;
            ProvinceName = p;
            TransportWay = o;

        }

        public string Details
        {
            get
            {
                return $"{TransportationDetails.GetArrival()}" + "\t" + $"{TransportationDetails.GetTotal()} $";
            }
        }
    }
}
