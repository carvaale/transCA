using System;
using System.Collections.Generic;
using System.Text;

namespace transCA
{
    public class Destination
    {
        private int _distance; //Distance in KM
        public int Distance{ get { return _distance; } }

        public Destination(string province)
        {
            _distance = GetProvinceDistance(province);
        }

        private int GetProvinceDistance(string province)
        {
      
        }
    }
}
