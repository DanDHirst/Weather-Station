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
    public partial class mainForm : Form
    {
        
        public mainForm()
        {
            InitializeComponent();
            getLocation();
            showLocation();
        }
        private void saveToFile()
        {
            //save the location data first
            string filename;
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            StreamWriter theData = new StreamWriter(filename);
            theData.WriteLine(Data.WeatherStationData.Length);
            foreach (Location locationData in Data.WeatherStationData)
            {
                theData.WriteLine(locationData.getLocationName());
                theData.WriteLine(locationData.getStreetNumAndName());
                theData.WriteLine(locationData.getCounty());
                theData.WriteLine(locationData.getPostCode());
                theData.WriteLine(locationData.getLatitude());
                theData.WriteLine(locationData.getLongitude());
                saveYears(theData, locationData);



            }
            theData.Close();

        }
        private void saveYears(StreamWriter theData,  Location locationData)
        {
            theData.WriteLine(locationData.getYears().Length); // save number of years in data set
            foreach (Yearly yearData in locationData.getYears())
            {
                theData.WriteLine(yearData.getDescription());
                saveMonths(theData, yearData);
            }
        }
        private void saveMonths(StreamWriter theData, Yearly yearData)
        {
            foreach(Monthly monthData in yearData.getMonths())
            {
                theData.WriteLine(yearData.getYear()); // save the year as it repeats in every month
                theData.WriteLine(monthData.getId());
                theData.WriteLine(monthData.getMaxTemp());
                theData.WriteLine(monthData.getMinTemp());
                theData.WriteLine(monthData.getMmRainfall());
                theData.WriteLine(monthData.getNumDaysAirFrost());
                theData.WriteLine(monthData.getHoursSunshine());
            }

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
            TheData.Close();
            

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



        //location selectors
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
        /// <summary>
        /// the location routines
        /// </summary>

        private void showLocation()
        {
            foreach (Location l in Data.WeatherStationData)
            {
                lstLocations.Items.Add(l.getLocationName());
            }
        }

        private void showLocationData()
        {
            Location theLocation;
            theLocation = Data.WeatherStationData[locationSelected];
            txtLocName.Text=theLocation.getLocationName();
            txtstreetNumAndName.Text = theLocation.getStreetNumAndName();
            txtCounty.Text = theLocation.getCounty();
            txtPostCode.Text = theLocation.getPostCode();
            txtLatitude.Text = theLocation.getLatitude();
            txtLongitude.Text = theLocation.getLongitude();

        }



        private void btnEditLoc_Click(object sender, EventArgs e)
        {
            Location theLocation;
            theLocation = Data.WeatherStationData[locationSelected];
            theLocation.setLocationName(txtLocName.Text);
            theLocation.setStreetNumAndName(txtstreetNumAndName.Text);
            theLocation.setCounty(txtCounty.Text);
            theLocation.setPostCode(txtPostCode.Text);
            theLocation.setLatitude(txtLatitude.Text);
            theLocation.setLongitude(txtLongitude.Text);
            // to refresh the list so the changes that are made show up
            refreshLocation();

        }

        private void btnAddLoc_Click(object sender, EventArgs e)
        {
            string LocName, streetNumAndName, county, postCode, latitude, longitude;
            LocName = txtLocName.Text;
            streetNumAndName = txtstreetNumAndName.Text;
            county = txtCounty.Text;
            postCode = txtPostCode.Text;
            latitude = txtLatitude.Text;
            longitude = txtLongitude.Text;
            //create object 
            Location tempLocation = new Location(LocName, streetNumAndName, county, postCode, latitude, longitude);

            //resize the array
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
            // to refresh the list so the changes that are made show up
            refreshLocation();

        }
        private void btnLocSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtLocSearch.Text;
            int length = Data.WeatherStationData.Length;
            bool found = false;
            for (int i = 0; i < length; i++)
            {
                if (searchQuery == Data.WeatherStationData[i].getLocationName())
                {
                    lstLocations.SelectedIndex = i;
                    found = true;

                }
            }
            if(found == false)
            {
                lblLocationSearchResponse.Text = "Location not found";
            }

        }
        private void refreshLocation()
        {
            lstLocations.Items.Clear();
            showLocation();
        }
        /// <summary>
        /// All of the year subroutines
        /// </summary>
        public void showYears()
        {
            lstYears.Items.Clear();
            Yearly[] years = Data.WeatherStationData[locationSelected].getYears();
            if (years != null)// to prevent the program crashing when a new location added and year is empty
            {
                foreach (Yearly y in years)
                {
                    lstYears.Items.Add(y.getYear());
                }
            }


        }
        private void showYearData()
        {
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Yearly yearData = theYearData[yearSelected];
            txtYear.Text = yearData.getYear().ToString();
            txtDescription.Text = yearData.getDescription();
        }
        private void btnEditYear_Click(object sender, EventArgs e)
        {
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Yearly yearData = theYearData[yearSelected];
            yearData.setDescription(txtDescription.Text);
            // to refresh the list so the changes that are made show up
            lstYears.Items.Clear();
            showYears();


        }

        private void btnAddNewYear_Click(object sender, EventArgs e)
        {
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            int theYear;
            string Description;
            theYear = Convert.ToInt32(txtSetNewYear.Text);
            Description = txtSetYearDescription.Text;
            //set a blank monthly datagrid
            CreateBlankGrid();
            //set up loop to store all the blank months in an array
            Monthly[] tempBlankMonths= null;
            const int amountOfMonths = 12;
            for (int i = 0; i < amountOfMonths; i++)
            {
                string id;
                double maxTemp, minTemp, airFrost, rainfall, sunshine;
                //assign varaibles to 0 to create blank data
                id = ((i+1).ToString());
                maxTemp = 0;
                minTemp = 0;
                airFrost = 0;
                rainfall = 0;
                sunshine = 0;





                //create object
                Monthly tempBlankMonth = new Monthly(id, maxTemp, minTemp, airFrost, rainfall, sunshine);
                //size the array
                int sizeofMonth;
                if (tempBlankMonths == null)
                {
                    sizeofMonth = 0;
                }
                else
                {
                    sizeofMonth = tempBlankMonths.Length;
                }
                Array.Resize(ref tempBlankMonths, sizeofMonth + 1);
                tempBlankMonths[sizeofMonth] = tempBlankMonth;
            }
            //create object
            Yearly tempYear = new Yearly(theYear,Description,tempBlankMonths);

            Yearly [] tempLocation = Data.WeatherStationData[locationSelected].getYears();
            //resize the array
            int size;
            if (tempLocation == null)
            {
                size = 0;
            }
            else
            {
                size = tempLocation.Length;
            }
            Array.Resize(ref tempLocation, size + 1);
            tempLocation[size] = tempYear;
            Data.WeatherStationData[locationSelected].setYears(tempLocation);
            //to refresh the list so the changes that are made show up
            showYears();



        }
        /// <summary>
        /// loops sequentially through the years comapring it to the user input
        /// </summary>

        private void btnSearchYearData_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchYear.Text;
            int length = Data.WeatherStationData[locationSelected].getYears().Length;
            bool found = false;
            Yearly[] years = Data.WeatherStationData[locationSelected].getYears();
            for (int i = 0; i < length; i++)
            {
                if (searchQuery == years[i].getYear().ToString())
                {
                    lstYears.SelectedIndex = i;
                    found = true;

                }
            }
            if (found == false)
            {
                lblSearchYearResponse.Text = "Year not found";
            }
        }
        private void CreateBlankGrid()
        {
            const int rows = 12;
            const int cols = 6;
            //set up grid view
            dgdMonths.RowCount = rows;
            dgdMonths.ColumnCount = cols;
            //set up rows
            for (int i = 0; i < rows; i++)
            {
                dgdMonths.Rows[i].HeaderCell.Value = " Month " + Convert.ToString(i + 1);

            }
            //set the width so the text fits
            dgdMonths.RowHeadersWidth = 100;

            //set up row textvalues
            dgdMonths.Columns[0].HeaderText = "ID";
            dgdMonths.Columns[1].HeaderText = "Maximum Temperature";
            dgdMonths.Columns[2].HeaderText = "Minimum Temperature";
            dgdMonths.Columns[3].HeaderText = "Days with air frost";
            dgdMonths.Columns[4].HeaderText = "(mm) of rainfall";
            dgdMonths.Columns[5].HeaderText = "Sunshine(hrs)";
        }

        /// <summary>
        /// All of the month routines
        /// </summary>
        private void showMonths()
        {
            CreateBlankGrid();
            const int rows = 12;
            const int cols = 6;

            //show the data
            showMonthData(rows,cols);

        }
        private void showMonthData(int rows, int cols)
        {

            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            for (int i = 0; i < rows; i++)
            {
                    Monthly month = theMonths[i];
                    dgdMonths[0, i].Value = month.getId();
                    dgdMonths[1, i].Value = month.getMaxTemp();
                    dgdMonths[2, i].Value = month.getMinTemp();
                    dgdMonths[3, i].Value = month.getNumDaysAirFrost();
                    dgdMonths[4, i].Value = month.getMmRainfall();
                    dgdMonths[5, i].Value = month.getHoursSunshine();

            }

        }
        private void btnEditMonth_Click(object sender, EventArgs e)
        {
            const int rows = 12;
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            for (int i = 0; i < rows; i++)
            {
                Monthly month = theMonths[i];
                month.setId(dgdMonths[0, i].Value.ToString());
                month.setMaxTemp(Convert.ToDouble(dgdMonths[1, i].Value));
                month.setMinTemp(Convert.ToDouble(dgdMonths[2, i].Value));
                month.setNumDaysAirFrost(Convert.ToDouble(dgdMonths[3, i].Value));
                month.setMmRainfall(Convert.ToDouble(dgdMonths[4, i].Value));
                month.setHoursSunshine(Convert.ToDouble(dgdMonths[5, i].Value));

            }
        }
        private void btnSearchMonth_Click(object sender, EventArgs e)
        {
            string searchQuery = txtSearchMonth.Text;
            Yearly[] theyear = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theyear[yearSelected].getMonths();
            const int length = 12; //due to 12 months in a year
            bool found = false;
            for (int i = 0; i < length; i++)
            {
                if (theMonths[i].getId() == searchQuery)
                {
                    dgdMonths.Rows[i].Selected = true;
                    found = true;
                }
            }
            if (found == false)
            {
                lblSearchMonth.Text = "Month id not found";
            }

        }
        private void clearAllData()
        {
            lstYears.Items.Clear();
            dgdMonths.Rows.Clear();
            dgdMonths.Refresh();


        }

        private void btnSaveChnages_Click(object sender, EventArgs e)
        {
            saveToFile();
        }

        
    }
}
