using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Location
    {
        //properties
        private string locationName;
        private string StreetNumAndName;
        private string county;
        private string postCode;
        private string latitude;
        private string longitude;
        private Yearly[] years; // the years for montly observations
        
        /// <summary>
        ///Contructor
        /// </summary>
        /// <param locationName="theLocationName"></param>
        /// <param StreetNumAndName="theStreetNumAndName"></param>
        /// <param county="theCounty"></param>
        /// <param postCode="thePostCode"></param>
        /// <param latitude="theLatitude"></param>
        /// <param longitude="theLongitude"></param>
        /// <param years="theYears"></param>
        public Location(string theLocationName, string theStreetNumAndName, string theCounty, string thePostCode,string theLatitude,string theLongitude, Yearly[] theYears)
        {
            locationName = theLocationName;
            StreetNumAndName = theStreetNumAndName;
            county = theCounty;
            postCode = thePostCode;
            latitude = theLatitude;
            longitude = theLongitude;
            years = theYears;
        }

        //getters
        public string getLocationName()
        {
             return locationName;
        }
        public string getStreetNumAndName()
        {
             return StreetNumAndName;
        }
        public string getCounty()
        {
             return county;
        }
        public string getPostCode()
        {
             return postCode;
        }
        public string getLatitude()
        {
             return latitude;
        }
        public string getLongitude()
        {
             return longitude;
        }
        public Yearly[] getYears()
        {
            return years;
        }

        /// <summary>
        /// setters
        /// </summary>
        /// <param locationName="theLocationName"></param>
        /// <param StreetNumAndName="theStreetNumAndName"></param>
        /// <param county="theCounty"></param>
        /// <param postCode="thePostCode"></param>
        /// <param latitude="theLatitude"></param>
        /// <param longitude="theLongitude"></param>
        /// <param years="theYears"></param>
        public void setLocationName(string theLocationName)
        {
            locationName = theLocationName;
        }
        public void setStreetNumAndName(string theStreetNumAndName)
        {
            StreetNumAndName = theStreetNumAndName;
        }
        public void setCounty(string theCounty)
        {
            county = theCounty;
        }
        public void setPostCode(string thePostCode)
        {
            postCode = thePostCode;
        }
        public void setLatitude(string theLatitiude)
        {
            latitude = theLatitiude;
        }
        public void setLongitude(string theLongitude)
        {
            longitude = theLongitude;
        }
        public void setYears(Yearly[] theYears)
        {
            years = theYears;
        }

    }
}
