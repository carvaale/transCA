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

    }
}
