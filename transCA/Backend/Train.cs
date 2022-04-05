using System;
namespace transCA.Backend
{
    public class Train : Transportation
        //Muhammad Choudhary
    {



        public Train(Destination destination, int passengers)
        {
            _ticketPrice = destination.DestinationInfo[2];
            _speed = 250; //Speed of plane in KM/H
            _passengers = passengers;
            _distance = destination.DestinationInfo[0];
        }

        public override double GetTotal()
        {
            return _ticketPrice * _passengers;
        }

        public override DateTime GetArrival()
        {
            return DateTime.Now.AddHours((_distance / _speed) + 2); //Add 2hrs to compensate for time boarding and disembarking train.
        }


    }
}
