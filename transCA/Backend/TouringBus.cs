using System;
using System.Collections.Generic;
using System.Text;

namespace transCA.Backend
{
    internal class TouringBus: Transportation
    {
        public TouringBus(Destination destinationTouringBus, int passengersTouringBus)
        {
            _ticketPrice = destinationTouringBus.DestinationInfo[3];
            _speed = 100;
            _passengers = passengersTouringBus;
            _distance = destinationTouringBus.DestinationInfo[0];
            _total = GetTotal();
            _arrival = GetArrival();

        }
        public override double GetTotal()
        {
            return _ticketPrice * _passengers;
        }
      


    }
}
