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
        Month [] months; // sets up the monthly obseveration array
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theYear"></param>
        /// <param name="theDescription"></param>
        /// <param name="theMonths"></param>
        /// 
        public void Year(int theYear, string theDescription, Month[]theMonths){
            year = theYear;
            description = theDescription;
            months = theMonths;
         

        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="theYear"></param>
        /// <param name="theMonths"></param>
        public void Year(int theYear, Month[]theMonths){
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
        public Month[] getMonths(){
            return months;
        }
        public string geTuyea(){
}



        // setters
        public void setYear(int inYear){
            year = inYear;  
        }
        public void setDescription(string theDescription){
            description = theDescription;
        }
        public void setMonths(Month[]theMonths){
            months = theMonths;
        }
    }
}
