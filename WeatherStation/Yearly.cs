using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation // add validation using the books class on the getters and setters
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
<<<<<<< HEAD:WeatherStation/Yearly.cs

        //getters
        public int getYear(){
=======
        
        
        // getters
        public int getYear(){ // returns the year
>>>>>>> bef3cc1ea6ea9cf69a7876df6aae22f2e5f7dd3a:WeatherStation/Year.cs
            return year;
        }
        public string getDescription(){ // returns the desciption
            return description;
        }
<<<<<<< HEAD:WeatherStation/Yearly.cs
        public Monthly[] getMonths(){
=======
        public Month[] getMonths(){ // returns the months
>>>>>>> bef3cc1ea6ea9cf69a7876df6aae22f2e5f7dd3a:WeatherStation/Year.cs
            return months;
        }



<<<<<<< HEAD:WeatherStation/Yearly.cs

        // setters
        public void setYear(int inYear){
=======
        // setters 
        public void setYear(int inYear){ // sets the year
>>>>>>> bef3cc1ea6ea9cf69a7876df6aae22f2e5f7dd3a:WeatherStation/Year.cs
            year = inYear;  
        }
        public void setDescription(string theDescription){ // sets the desciption
            description = theDescription;
        }
<<<<<<< HEAD:WeatherStation/Yearly.cs
        public void setMonths(Monthly[]theMonths){
=======
        public void setMonths(Month[] theMonths){
>>>>>>> bef3cc1ea6ea9cf69a7876df6aae22f2e5f7dd3a:WeatherStation/Year.cs
            months = theMonths;
        }
    }// end of year class 
}
