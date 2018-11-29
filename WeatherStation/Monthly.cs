using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Monthly
    {
        // set properties 
        private string id; // Month id number
        private double maxTemp; // Maximum temperature
        private double minTemp; // Minimum temperature
        private double numDaysAirFrost; // Numer of days of air frost
        private double mmRainfall; // Millimetres of rainfall in the month
        private double hoursSunshine; // Hours of sunchine that month

        //Constuctors 
        /// <summary>
        /// Constructor for monthly observations
        /// </summary>
        /// <param id="theId"></param>
        /// <param maxtemp="theMaxTemp"></param>
        /// <param minTemp="theMinTemp"></param>
        /// <param numDaysAirFrost="theNumDaysAirFrost"></param>
        /// <param mmRainfall="theMmRainfall"></param>
        /// <param hoursSunsine="theHoursSunshine"></param>
        public Monthly(string theId, double theMaxTemp, double theMinTemp, double theNumDaysAirFrost,double theMmRainfall,double theHoursSunshine){
            id = theId;
            maxTemp = theMaxTemp;
            minTemp = theMinTemp;
            numDaysAirFrost = theNumDaysAirFrost;
            mmRainfall = theMmRainfall;
            hoursSunshine = theHoursSunshine;
        }
        // getters
        public string getId(){ // returns id
            return id;
        }
        public double getMaxTemp(){// returns Max temp
            return maxTemp;
        }
        public double getMinTemp(){// returns Min temp
            return minTemp;
        }
        public double getNumDaysAirFrost(){// returns Number of Days of Air Frost
            return numDaysAirFrost;
        }
        public double getMmRainfall(){// returns millimetres of rainfall that month
            return mmRainfall;
        }
        public double getHoursSunshine(){// returns hours of sunshine that month
            return hoursSunshine;
        }

        // setters
        public void setId(string theId){ // sets the id 
            id = theId;
        }
        public void setMaxTemp(double theMaxTemp){ // sets the max temp
            maxTemp = theMaxTemp;
        }       
        public void setMinTemp(double theMinTemp){ //sets the minimum temp
            minTemp = theMinTemp;
        } 
        public void setNumDaysAirFrost(double theNumDaysAirFrost){ // sets the number of days of Air Frost
            numDaysAirFrost = theNumDaysAirFrost;
        }
        public void setMmRainfall(double theMmRainfall){ //sets the millimetres of rainfall that month
            mmRainfall = theMmRainfall;
        }
        public void setHoursSunshine(double theHoursSunshine){ // sets the hours of sunshine in that month
            hoursSunshine = theHoursSunshine;
        }
    }
}
