using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Yearly
    {
        //properties
        private int year; // variable for the year
        private string description; // Variable for the descirption for the year
        Monthly [] months; // sets up the monthly obseveration array

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theYear"></param>
        /// <param name="theDescription"></param>
        /// <param name="theMonths"></param>

        public Yearly(int theYear, string theDescription, Monthly[]theMonths){
            year = theYear;
            description = theDescription;
            months = theMonths;
         

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theYear"></param>
        /// <param name="theMonths"></param>

        public Yearly(int theYear, Monthly[]theMonths){
            year = theYear;
            months = theMonths;
        }



        //getters
        
        // getters
        public int getYear(){ // returns the year
            return year;
        }
        public string getDescription(){ // returns the desciption
            return description;
        }
        public Monthly[] getMonths(){ // returns the months
            return months;
        }



        // setters 
        public void setYear(int inYear){ // sets the year
            year = inYear;  
        }
        public void setDescription(string theDescription){ // sets the desciption
            description = theDescription;
        }
        public void setMonths(Monthly[]theMonths){
            months = theMonths;
        }
    }// end of year class 
}
