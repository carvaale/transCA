using System;
using System.Collections.Generic;
using System.Text;

namespace transCA
{ 
    // Alexander Carvalho
    // Base abstract class of train, plane, bus subclasses
    public abstract class Transportation
    {
        protected int _ticketPrice;
        protected int _speed;
        protected int _passengers;
        protected int _distance;
        protected double _total;
        protected DateTime _arrival;
        public abstract double GetTotal();
        public abstract DateTime GetArrival();
        
    }
}
