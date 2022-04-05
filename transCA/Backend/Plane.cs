using System;
using System.Collections.Generic;
using System.Text;

namespace transCA.Backend
{
    public class Plane : Transportation
    {
        public Plane(Destination destination, int passengers)
        {
            _ticketPrice = destination.DestinationInfo[1];
            _speed = 800; //Speed of plane in KM/H
            _passengers = passengers;
            _distance = destination.DestinationInfo[0];
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
