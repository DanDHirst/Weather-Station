using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    class Year
    {
        //properties
        private int year; // variable for the year
        private string description; // Variable for the descirption for the year
        Month [] months = new Month [1]; // sets up the monthly obseveration array
        
        //constructors
        public void Year(int theYear, string theDescription, Month[]theMonths){
            year = theYear;
            Description = theDescription;
            months = theMonths;

        }
        public void Year(int theYear, Month[]theMonths){
            year = theYear;
            months = theMonths;
        }


        // methods
        
        
        // getters
        public int getYear(){
            return year;
        }
        public string getDescription(){
            return description;
        }



        // setters
        public void setYear(int inYear){
            year = inYear;  
        }
        public void setDescription(string theDescription){
            description = theDescription;
        }
    }
}
