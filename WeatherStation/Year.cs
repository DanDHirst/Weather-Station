using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation // add validation using the books class on the getters and setters
{
    class Year
    {
        //properties
        private int year; // variable for the year
        private string description; // Variable for the descirption for the year
        Month [] months; // sets up the monthly obseveration array
        
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
        public int getYear(){ // returns the year
            return year;
        }
        public string getDescription(){ // returns the desciption
            return description;
        }
        public Month[] getMonths(){ // returns the months
            return months;
        }



        // setters 
        public void setYear(int inYear){ // sets the year
            year = inYear;  
        }
        public void setDescription(string theDescription){ // sets the desciption
            description = theDescription;
        }
        public void setMonths(Month[] theMonths){
            months = theMonths;
        }
    }// end of year class 
}
