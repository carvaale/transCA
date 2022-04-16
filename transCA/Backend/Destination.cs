using System;
using System.Collections.Generic;
using System.Text;

namespace transCA
{
    public class Destination
    {

        private List<int> _destinationInfo; 
        public List<int> DestinationInfo { get { return _destinationInfo; } }

        public Destination(string province)
        {
            GetProvinceInfo(province);
        }

        private void GetProvinceInfo(string province)
        {
            switch (province)
            {

                case "Yukon":
                    _destinationInfo = new List<int> { 4000, 900, 450, 225 }; //[Distance, Plane price, Train Price, Bus Price]
                    break;
                case "British Columbia":
                    _destinationInfo = new List<int> { 3400, 800, 400, 200 };
                    break;
                case "Northwest Territories":
                    _destinationInfo = new List<int> { 3100, 1000, 500, 250 };
                    break;
                case "Alberta":
                    _destinationInfo = new List<int> { 2700, 700, 350, 175 };
                    break;
                case "Saskatchewan":
                    _destinationInfo = new List<int> { 2200, 600, 300, 150 };
                    break;
                case "Nunavut":
                    _destinationInfo = new List<int> { 2300, 1000, 500, 250 };
                    break;
                case "Manitoba":
                    _destinationInfo = new List<int> { 1500, 500, 250, 125 };
                    break;
                case "Quebec":
                    _destinationInfo = new List<int> { 760, 300, 150, 75 };
                    break;
                case "Newfoundland and Labrador":
                    _destinationInfo = new List<int> { 2200, 1000, 500, 250 };
                    break;
                case "Prince Edwards Island":
                    _destinationInfo = new List<int> { 1300, 700, 350, 175 };
                    break;
                case "New Brunswick":
                    _destinationInfo = new List<int> { 1100, 600, 300, 150 };
                    break;
                case "Nova Scotia":
                    _destinationInfo = new List<int> { 2000, 900, 450, 225 };
                    break;
                default:
                    throw new Exception();
            }
        }
    }

}

