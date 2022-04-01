using System;
using System.Collections.Generic;
using System.Text;

namespace transCA
{
    public class Destination
    {
        private int _distance; //Distance in KM
        public int Distance{ get { return _distance; } }

        private int _distance; //Distance in KM
        public int Distance { get { return _distance; } }
        private List<int> _destinationInfo; //[Distance, Plane price, Train Price, Bus Price]
        public List<int> DestinationInfo { get { return _destinationInfo; } }

        public Destination(string province)
        {
            GetProvinceInfo(province);
        }

        private void GetProvinceInfo(string province)
        {
            switch (province)
            {

                case "yukon":
                    _destinationInfo = new List<int> { 4000, 900, 450, 225 };
                    break;
                case "british columbia":
                    _destinationInfo = new List<int> { 3400, 800, 400, 200 };
                    break;
                case "northwest territories":
                    _destinationInfo = new List<int> { 3100, 1000, 500, 250 };
                    break;
                case "alberta":
                    _destinationInfo = new List<int> { 2700, 700, 350, 175 };
                    break;
                case "saskatchewan":
                    _destinationInfo = new List<int> { 2200, 600, 300, 150 };
                    break;
                case "nunavut":
                    _destinationInfo = new List<int> { 2300, 1000, 500, 250 };
                    break;
                case "manitoba":
                    _destinationInfo = new List<int> { 1500, 500, 250, 125 };
                    break;
                case "quebec":
                    _destinationInfo = new List<int> { 760, 300, 150, 75 };
                    break;
                case "newfoundland and labrador":
                    
                    _destinationInfo = new List<int> { 2200, 1000, 500, 250 };
                    break;
                case "prince edwards island":
                    _destinationInfo = new List<int> { 1300, 700, 350, 175 };
                    break;
                case "new brunswick":
                    _destinationInfo = new List<int> { 1100, 600, 300, 150 };
                    break;
                case "nova scotia":
                    _destinationInfo = new List<int> { 2000, 900, 450, 225 };
                    break;
                default:
                    throw new Exception();
            }
        }
    }

}
    }
}
