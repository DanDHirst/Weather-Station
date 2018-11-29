using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            getLocation();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Location plymouth = new Location("plymouth", "asd2", "asd", "pl12", "324234", "213123");
            Yearly id3 = new Yearly(2017);
            Monthly febuary = new Monthly("asdasd", 2, 4, 2, 4, 2);
            MessageBox.Show(plymouth.getLocationName()+ id3.getYear() + febuary.getId());


        }
        private void getLocation()
        {
            StreamReader TheData = new StreamReader(@"README EXTENDED.txt");
            int NumLocations,numOfYears;
            string LocName, streetNumAndName,county,postCode,latitude,longitude;
            Location[] allTheLocations;
            Yearly[] allTheYears=null;
            NumLocations = Convert.ToInt32(TheData.ReadLine());
            while (!TheData.EndOfStream)
            {

                LocName = TheData.ReadLine();
                streetNumAndName = TheData.ReadLine();
                county = TheData.ReadLine();
                postCode = TheData.ReadLine();
                latitude = TheData.ReadLine();
                longitude = TheData.ReadLine();
                numOfYears = Convert.ToInt32(TheData.ReadLine());
                for (int i = 0; i < numOfYears; i++)
                {
                    getYear(TheData, ref allTheYears);
                }
                
                
            }
            //need to reset array data

        }
        private void getYear(StreamReader theData, ref Yearly[] allYears)
        {
            Monthly[] theMonths = null;
            string desciption;
            int yearID;
            getMonths(theData,ref theMonths);

        }
        private void getMonths(StreamReader theData,ref Monthly[] theMonths)
        {

            const int amountOfMonths = 12;
            for (int i = 0; i < amountOfMonths; i++)
            {
                string id;
                int maxTemp, minTemp, airFrost, rainfall, sunshine;
                //read in
                id = theData.ReadLine();
                maxTemp = Convert.ToInt32(theData.ReadLine());
                minTemp = Convert.ToInt32(theData.ReadLine());
                airFrost = Convert.ToInt32(theData.ReadLine());
                rainfall = Convert.ToInt32(theData.ReadLine());
                sunshine = Convert.ToInt32(theData.ReadLine());



                //create object
                Monthly month = new Monthly(id,maxTemp,minTemp,airFrost,rainfall,sunshine);
                //size the array
                int size;
                if (theMonths == null)
                {
                    size = 0;
                }
                else
                {
                    size = theMonths.Length;
                }
                Array.Resize(ref theMonths, size + 1);
                theMonths[size] = month;
            }
            
        }
    }
}
