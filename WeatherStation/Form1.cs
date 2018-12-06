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
            showLocation();
        }
        //data read in section
        private void getLocation()
        {
            string filename;
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            StreamReader TheData = new StreamReader(filename);
            int numOfYears, NumLocations;
            string LocName, streetNumAndName,county,postCode,latitude,longitude;
            Location[] allTheLocations=null;
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
                //create locaion object
                Location tempLocation = new Location(LocName, streetNumAndName, county, postCode, latitude, longitude, allTheYears);
 
                //size the array
                int size;
                if (Data.WeatherStationData == null)
                {
                    size = 0;
                }
                else
                {
                    size = Data.WeatherStationData.Length;
                }
                Array.Resize(ref Data.WeatherStationData, size + 1);
                Data.WeatherStationData[size] = tempLocation;
                allTheYears = null; //reset the year array
                

            }
           

        }
        private void getYear(StreamReader theData, ref Yearly[] allYears)
        {
            Monthly[] theMonths = null;
            //readin
            string desciption;
            int yearID;
            desciption = theData.ReadLine();
            yearID = Convert.ToInt32(theData.ReadLine());
            getMonths(theData,ref theMonths);
            //create object
            Yearly tempYears = new Yearly(yearID,desciption,theMonths);
            //resize array
            int size;
            if (allYears == null)
            {
                size = 0;
            }
            else
            {
                size = allYears.Length;
            }
            Array.Resize(ref allYears, size + 1);
            allYears[size] = tempYears;

        }
        private void getMonths(StreamReader theData,ref Monthly[] theMonths)
        {

            const int amountOfMonths = 12;
            for (int i = 0; i < amountOfMonths; i++)
            {
                string id;
                double maxTemp, minTemp, airFrost, rainfall, sunshine;
                //read in
                id = theData.ReadLine();
                maxTemp = Convert.ToDouble(theData.ReadLine());
                minTemp = Convert.ToDouble(theData.ReadLine());
                airFrost = Convert.ToDouble(theData.ReadLine());
                rainfall = Convert.ToDouble(theData.ReadLine());
                sunshine = Convert.ToDouble(theData.ReadLine());
                if(i < 11)
                {
                   string bin = theData.ReadLine();
                }




                //create object
                Monthly tempMonth = new Monthly(id,maxTemp,minTemp,airFrost,rainfall,sunshine);
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
                theMonths[size] = tempMonth;
            }
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void showLocation()
        {
            foreach (Location l in Data.WeatherStationData)
            {
                lstLocations.Items.Add(l.getLocationName());
            }
        }

        int locationSelected = -1;
        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearAllData();
            locationSelected = lstLocations.SelectedIndex;
            showLocationData();
            showYears();

        }
        int yearSelected = -1;
        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearSelected = lstYears.SelectedIndex;
            showYearData();
            showMonths();
        }
        int monthSelected = -1;
        private void lstMonths_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthSelected = lstMonths.SelectedIndex;
            showMonthData();
        }
        private void showLocationData()
        {
            lstLocData.Items.Clear();
            Location theLocation;
            theLocation = Data.WeatherStationData[locationSelected];
            lstLocData.Items.Add(theLocation.getLocationName());
            lstLocData.Items.Add(theLocation.getStreetNumAndName());
            lstLocData.Items.Add(theLocation.getCounty());
            lstLocData.Items.Add(theLocation.getPostCode());
            lstLocData.Items.Add(theLocation.getLatitude());
            lstLocData.Items.Add(theLocation.getLongitude());

        }

        public void showYears()
        {
            lstYears.Items.Clear();
            Yearly[] years = Data.WeatherStationData[locationSelected].getYears();
            foreach(Yearly y in years)
            {
                lstYears.Items.Add(y.getYear());
            }


        }
        private void showYearData()
        {
            lstYearData.Items.Clear();
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Yearly yearData = theYearData[yearSelected];
            lstYearData.Items.Add(yearData.getYear());
            lstYearData.Items.Add(yearData.getDescription());
        }
        private void showMonths()
        {
            lstMonths.Items.Clear();
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            foreach(Monthly m in theMonths)
            {
                lstMonths.Items.Add(m.getId());
            }

        }
        private void showMonthData()
        {
            lstMonthData.Items.Clear();
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            Monthly month = theMonths[monthSelected];
            lstMonthData.Items.Add(month.getId());
            lstMonthData.Items.Add(month.getMaxTemp());
            lstMonthData.Items.Add(month.getMinTemp());
            lstMonthData.Items.Add(month.getNumDaysAirFrost());
            lstMonthData.Items.Add(month.getMmRainfall());
            lstMonthData.Items.Add(month.getHoursSunshine());

        }
        private void clearAllData()
        {
            lstLocData.Items.Clear();
            lstYears.Items.Clear();
            lstYearData.Items.Clear();
            lstMonths.Items.Clear();
            lstMonthData.Items.Clear();

        }


    }
}
