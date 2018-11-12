using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Month
    {
        // set properties 
        private string id; // Month id number
        private int maxTemp; // Maximum temperature
        private int minTemp; // Minimum temperature
        private int numDaysAirFrost; // Numer of days of air frost
        private int mmRainfall; // Millimetres of rainfall in the month
        private int hoursSunshine; // Hours of sunchine that month

        //Constuctors 
        public void Month(string theId, int theMaxTemp, int theMinTemp, int theNumDaysAirFrost,int theMmRainfall,int theHoursSunshine){
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
        public int getMaxTemp(){// returns Max temp
            return maxTemp;
        }
        public int getMinTemp(){// returns Min temp
            return minTemp;
        }
        public int getNumDaysAirFrost(){// returns Number of Days of Air Frost
            return numDaysAirFrost;
        }
        public int getMmRainfall(){// returns millimetres of rainfall that month
            return mmRainfall;
        }
        public int getHoursSunshine(){// returns hours of sunshine that month
            return hoursSunshine;
        }

        // setters
        public void setId(string theId){ // sets the id 
            id = theId;
        }
        public void setMaxTemp(int theMaxTemp){ // sets the max temp
            maxTemp = theMaxTemp;
        }       
        public void setMinTemp(int theMinTemp){ //sets the minimum temp
            minTemp = theMinTemp;
        } 
        public void setNumDaysAirFrost(int theNumDaysAirFrost){ // sets the number of days of Air Frost
            numDaysAirFrost = theNumDaysAirFrost;
        }
        public void setMmRainfall(int theMmRainfall){ //sets the millimetres of rainfall that month
            mmRainfall = theMmRainfall;
        }
        public void setHoursSunshine(int theHoursSunshine){ // sets the hours of sunshine in that month
            hoursSunshine = theHoursSunshine;
        }
    }
}
