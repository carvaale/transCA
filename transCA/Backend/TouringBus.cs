using System;
using System.Collections.Generic;
using System.Text;

namespace transCA.Backend
{
    public class TouringBus : Transportation
    {
        public TouringBus(Destination destinationTouringBus, int passengersTouringBus)
        {
            _ticketPrice = destinationTouringBus.DestinationInfo[3];
            _speed = 75;
            _passengers = passengersTouringBus;
            _distance = destinationTouringBus.DestinationInfo[0];
        }
        public override double GetTotal()
        {
            return _ticketPrice * _passengers;
        }

        public override DateTime GetArrival()
        {
            return DateTime.Now.AddHours((_distance / _speed) + 10); // Total distance/ bus speed + the time taken for resting at the hotels
        }

    }
}
