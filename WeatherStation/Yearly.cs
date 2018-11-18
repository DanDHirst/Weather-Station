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


        // methods

        //getters
        public int getYear(){
            return year;
        }
        public string getDescription(){
            return description;
        }
        public Monthly[] getMonths(){
            return months;
        }




        // setters
        public void setYear(int inYear){
            year = inYear;  
        }
        public void setDescription(string theDescription){
            description = theDescription;
        }
        public void setMonths(Monthly[]theMonths){
            months = theMonths;
        }
    }
}
