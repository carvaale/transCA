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
            switch(province)
            {
                case "yukon":
                    return 4000;
                case "british columbia":
                    return 3400 ;
                case "northwest territories":
                    return 3100;
                case "alberta":
                    return 2700;
                case "saskatchewan":
                    return 2200;
                case "nunavut":
                    return 2300;
                case "manitoba":
                    return 1500;
                case "quebec":
                    return 760;
                case "newfoundland and labrador":
                    return 2200;
                case "prince edwards island":
                    return 1300;
                case "new brunswick":
                    return 1100;
                case "nova scotia":
                    return 2000;
                default:
                    return 0;
                    
            }     
        }
    }
}
