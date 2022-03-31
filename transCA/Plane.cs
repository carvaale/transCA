using System;
using System.Collections.Generic;
using System.Text;

namespace transCA
{
    public class Plane : Transportation
    {

        public double Total { get { return _total; } }
        public DateTime Arrival { get { return _arrival; } }

        public Plane(Destination destination, int passengers)
        {
            _ticketPrice = 250;
            _speed = 800; //Speed of plane in KM/H
            _passengers = passengers;
            _distance = destination.Distance;
            _total = GetTotal();
            _arrival = GetArrival();
        }

        public override double GetTotal()
        {
            return _ticketPrice * _passengers;
        }

        public override DateTime GetArrival()
        {
            return DateTime.Now.AddHours((_distance / _speed) + 5); //Add 5hrs to compensate for time boarding and disembarking flight.
        }
    }
}
