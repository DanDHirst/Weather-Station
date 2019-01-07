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
        //save to file code
        private void saveToFile()
        {
            //save the location data first
            string filename;
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            StreamWriter theData = new StreamWriter(filename);
            theData.WriteLine(Data.WeatherStationData.Length);
            foreach (Location locationData in Data.WeatherStationData)//loop through each location 
            {
                //write all of the location info
                theData.WriteLine(locationData.getLocationName());
                theData.WriteLine(locationData.getStreetNumAndName());
                theData.WriteLine(locationData.getCounty());
                theData.WriteLine(locationData.getPostCode());
                theData.WriteLine(locationData.getLatitude());
                theData.WriteLine(locationData.getLongitude());
                //call the save year procedure passing theData and location data array
                saveYears(theData, locationData);



            }
            // close stream writer
            theData.Close();

        }
        private void saveYears(StreamWriter theData,  Location locationData)
        {
            theData.WriteLine(locationData.getYears().Length); // save number of years in data set
            //loop through year data for all the years for specific location
            foreach (Yearly yearData in locationData.getYears())
            {
                //write the description of the year to file
                theData.WriteLine(yearData.getDescription());
                //call the saveMonths procedure passing theData and yearData
                saveMonths(theData, yearData);
            }
        }
        private void saveMonths(StreamWriter theData, Yearly yearData)
        {
            //loop through each month in the year
            foreach(Monthly monthData in yearData.getMonths())
            {
                theData.WriteLine(yearData.getYear()); // save the year id as it repeats in every month
                // write all of the month data to the file
                theData.WriteLine(monthData.getId());
                theData.WriteLine(monthData.getMaxTemp());
                theData.WriteLine(monthData.getMinTemp());
                theData.WriteLine(monthData.getMmRainfall());
                theData.WriteLine(monthData.getNumDaysAirFrost());
                theData.WriteLine(monthData.getHoursSunshine());
            }

        }
        //end save to file

        //data read in section
        private void getLocation()
        {
            string filename;
            openFileDialog1.ShowDialog(); // open up a file dialog
            filename = openFileDialog1.FileName; // assign the name of file to filename
            StreamReader TheData = new StreamReader(filename); //create a file object using streamReader with filename
            int numOfYears, NumLocations;
            string LocName, streetNumAndName,county,postCode,latitude,longitude;
            Yearly[] allTheYears=null;// temp storage for year objects
            NumLocations = Convert.ToInt32(TheData.ReadLine());//read the number of locations
            while (!TheData.EndOfStream)//read until the last line
            {
                //read in location info 
                LocName = TheData.ReadLine();
                streetNumAndName = TheData.ReadLine();
                county = TheData.ReadLine();
                postCode = TheData.ReadLine();
                latitude = TheData.ReadLine();
                longitude = TheData.ReadLine();
                numOfYears = Convert.ToInt32(TheData.ReadLine());
                //loop through the get year function dependent on the amount of years
                for (int i = 0; i < numOfYears; i++)
                {
                    getYear(TheData, ref allTheYears);
                }
                //create locaion object
                Location tempLocation = new Location(LocName, streetNumAndName, county, postCode, latitude, longitude, allTheYears);
 
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
                allTheYears = null; //reset the year array
                

            }
            TheData.Close();//close the streamreader
            

        }
        private void getYear(StreamReader theData, ref Yearly[] allYears)
        {
            Monthly[] theMonths = null; // temp monthly array storage
            //readin
            string desciption;
            int yearID;
            //read description and yearID
            desciption = theData.ReadLine();
            yearID = Convert.ToInt32(theData.ReadLine());
            //call the getMonths procedure with theData and a reference to theMonths temp storage 
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
            //loop for months for 12 times
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
                // due to the data file has a yearid repeating i am removing it when reading in
                if(i < 11)
                {
                   string bin = theData.ReadLine();
                }




                //create object
                Monthly tempMonth = new Monthly(id,maxTemp,minTemp,airFrost,rainfall,sunshine);
                //resize the array
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
        //end data read in


        //location selectors
        int locationSelected = -1;
        private void lstLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            clearAllData();
            locationSelected = lstLocations.SelectedIndex;//when location clicked assign the index to the variable
            //show the location data
            showLocationData();
            //show the years for the selected location
            showYears();

        }
        int yearSelected = -1;
        private void lstYears_SelectedIndexChanged(object sender, EventArgs e)
        {
            yearSelected = lstYears.SelectedIndex;//when a year clicked assign the index to the varaible
            //show year data
            showYearData();
            //show the months data in datagrid
            showMonths();
            //check then uncheck radio button so it refreshes the graph
            radMaxTemp.Checked = false;
            radMaxTemp.Checked = true;
        }
        //end location selecters
        /// <summary>
        /// the location routines
        /// </summary>

        private void showLocation()
        {
            //loop through all of the locations and output there name to the listview
            foreach (Location l in Data.WeatherStationData)
            {
                lstLocations.Items.Add(l.getLocationName());
            }
        }

        private void showLocationData()
        {
            //show the location data in text boxes dependent on the location selected
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
            //save the data editied in the text box to the data.weatherstore
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
            //add a new location dependent on the data entered
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
            //search the data for location mataching the data entered by the user
            string searchQuery = txtLocSearch.Text;
            int length = Data.WeatherStationData.Length;
            bool found = false;
            //loop through all of the locations compare each one to the search query
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
        //end location
        /// <summary>
        /// All of the year subroutines
        /// </summary>
        public void showYears()
        {
            lstYears.Items.Clear();
            Yearly[] years = Data.WeatherStationData[locationSelected].getYears();
            if (years != null)// to prevent the program crashing when a new location added and year is empty
            {
                //loop through all of the years adding them to the list
                foreach (Yearly y in years)
                {
                    lstYears.Items.Add(y.getYear());
                }
            }


        }
        private void showYearData()
        {
            //show the year data into text boxes
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Yearly yearData = theYearData[yearSelected];
            txtYear.Text = yearData.getYear().ToString();
            txtDescription.Text = yearData.getDescription();
        }
        private void btnEditYear_Click(object sender, EventArgs e)
        {
            //change the desciption id dependant on the user input
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Yearly yearData = theYearData[yearSelected];
            yearData.setDescription(txtDescription.Text);
            // to refresh the list so the changes that are made show up
            lstYears.Items.Clear();
            showYears();


        }

        private void btnAddNewYear_Click(object sender, EventArgs e)//adds a new year and creates the monthly data but is all blank
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

        private void btnSearchYearData_Click(object sender, EventArgs e)// loop through all of the years comparing it to the user input
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
        //end year
        /// <summary>
        /// All of the month routines
        /// </summary>
        private void showMonths()
        {
            CreateBlankGrid();
            const int rows = 12;
            const int cols = 6;

            //show the data passing the rows and cols
            showMonthData(rows,cols);

        }
        private void showMonthData(int rows, int cols)
        {
            //get the months for the correct location and year
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            //loop through each row saving the value from the month year selected
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
            //loop through all the grid to save all the changes
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
            //checking if the location and year is selected
            if (locationSelected >= 0 && yearSelected >= 0)
            {
                Yearly[] theyear = Data.WeatherStationData[locationSelected].getYears();
                Monthly[] theMonths = theyear[yearSelected].getMonths();


                const int length = 12; //due to 12 months in a year
                bool found = false;
                try
                {
                    //loop though all month id for selected year and if macthes id highlight it
                    for (int i = 0; i < length; i++)
                    {
                        if (theMonths[i].getId() == searchQuery)
                        {

                            dgdMonths.Rows[i].Selected = true;
                            found = true;

                        }
                    }
                }
                catch (IndexOutOfRangeException exception)
                {
                    lblSearchMonth.Text = "Exception caught" + exception.Message;


                }
                if (found == false)
                {
                    lblSearchMonth.Text = "Month id not found";
                }
            }
            else
            {
                MessageBox.Show("Select a Location and a Year to search");
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radMaxTemp_CheckedChanged(object sender, EventArgs e)
        {
            //clear the data draw on
            panelGraph.Refresh();
            //set up the legend
            lblKey1.Text = "5";
            lblKey2.Text = "10";
            lblKey3.Text = "15";
            lblKey4.Text = "20";
            lblKey5.Text = "25";
            lblTitle.Text = "Maximum Temperature (celsuis)";
            //end setup
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            const int monthsInAYear = 12;
            int MaxTemp;
            int spacing = 20;
            Brush solidBrush;
            Color solidColor = Color.Blue;
            Rectangle solidRectangle;
            for (int i = 0; i < monthsInAYear; i++)
            {
                MaxTemp = Convert.ToInt32(theMonths[i].getMaxTemp() * 10);// amplifly the results by 10 times 

                solidRectangle = new Rectangle(10 + spacing, (300 - MaxTemp), 30, MaxTemp);
                using (Graphics panelGraphics = panelGraph.CreateGraphics())
                using (solidBrush = new SolidBrush(solidColor))
                {
                    panelGraphics.FillRectangle(solidBrush, solidRectangle);
                }
                spacing = spacing + 35;
            }

        }

        private void radMinTemp_CheckedChanged(object sender, EventArgs e)
        {
            //clear the data draw on
            panelGraph.Refresh();
            //set up the legend
            lblKey1.Text = "5";
            lblKey2.Text = "10";
            lblKey3.Text = "15";
            lblKey4.Text = "20";
            lblKey5.Text = "25";
            lblTitle.Text = "Minimum Temperature (celsuis)";
            //end setup
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            const int monthsInAYear = 12;
            int MinTemp;
            int spacing =20;
            Brush solidBrush;
            Color solidColor = Color.Blue;
            Rectangle solidRectangle;
            for (int i = 0; i < monthsInAYear; i++)
            {
                MinTemp = Convert.ToInt32(theMonths[i].getMinTemp()*10);// amplifly the results by 10 times 
                
                solidRectangle = new Rectangle(10 + spacing, (300-MinTemp), 30, MinTemp);
                using (Graphics panelGraphics = panelGraph.CreateGraphics())
                using (solidBrush= new SolidBrush(solidColor))
                {
                    panelGraphics.FillRectangle(solidBrush, solidRectangle);
                }
                spacing = spacing + 35;
            }

        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {
            Pen linePen;
            int penSize;
            Color myColor = Color.Black;
            penSize = 4;
            //create pen with color and thickness
            linePen = new Pen(myColor, penSize);

            //declare and create a graphcis object for the panel
            using (Graphics panelGraphics = panelGraph.CreateGraphics())
            {
                panelGraphics.DrawLine(linePen, 20, 30, 20, 300);
                panelGraphics.DrawLine(linePen, 20, 300, 450, 300);
            }
            linePen.Dispose();
        } //end painting

        private void radNumDaysOfAirFrost_CheckedChanged(object sender, EventArgs e)
        {
            //clear the data draw on
            panelGraph.Refresh();
            //set up the legend
            lblKey1.Text = "5";
            lblKey2.Text = "10";
            lblKey3.Text = "15";
            lblKey4.Text = "20";
            lblKey5.Text = "25";
            lblTitle.Text = "Air Frost(days)";
            //end setup
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            const int monthsInAYear = 12;
            int airFrost;
            int spacing = 20; // spacing so the rectangles arent all on one location
            Brush solidBrush;
            Color solidColor = Color.Blue; //select color to blue
            Rectangle solidRectangle;
            for (int i = 0; i < monthsInAYear; i++)
            {
                airFrost = Convert.ToInt32(theMonths[i].getNumDaysAirFrost() * 10);// amplifly the results by 10 times 
                //draw graphics dependent on the data
                solidRectangle = new Rectangle(10 + spacing, (300 - airFrost), 30, airFrost);
                using (Graphics panelGraphics = panelGraph.CreateGraphics())
                using (solidBrush = new SolidBrush(solidColor))
                {
                    panelGraphics.FillRectangle(solidBrush, solidRectangle);//draw graphics
                }
                spacing = spacing + 35;
            }
        }

        private void radMMRainfall_CheckedChanged(object sender, EventArgs e)
        {
            //clear the data draw on
            panelGraph.Refresh();
            //set up the legend
            lblKey1.Text = "50";
            lblKey2.Text = "100";
            lblKey3.Text = "150";
            lblKey4.Text = "200";
            lblKey5.Text = "250";
            lblTitle.Text = "Rainfall(mm)";
            //end setup
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            const int monthsInAYear = 12;
            int rainfall;
            int spacing = 20;
            Brush solidBrush;
            Color solidColor = Color.Blue;
            Rectangle solidRectangle;
            for (int i = 0; i < monthsInAYear; i++)
            {
                rainfall = Convert.ToInt32(theMonths[i].getMmRainfall() );// amplifly the results by 5 times 

                solidRectangle = new Rectangle(10 + spacing, (300 - rainfall), 30, rainfall);
                using (Graphics panelGraphics = panelGraph.CreateGraphics())
                using (solidBrush = new SolidBrush(solidColor))
                {
                    panelGraphics.FillRectangle(solidBrush, solidRectangle);//draw graphics
                }
                spacing = spacing + 35;
            }
        }

        private void radHoursSunshine_CheckedChanged(object sender, EventArgs e)
        {
            //clear the data draw on
            panelGraph.Refresh();
            //set up the legend
            lblKey1.Text = "50";
            lblKey2.Text = "100";
            lblKey3.Text = "150";
            lblKey4.Text = "200";
            lblKey5.Text = "250";
            lblTitle.Text = "Sunshine(Hours)";
            //end setup
            Yearly[] theYearData = Data.WeatherStationData[locationSelected].getYears();
            Monthly[] theMonths = theYearData[yearSelected].getMonths();
            const int monthsInAYear = 12;
            int sunshine;
            int spacing = 20;
            Brush solidBrush;
            Color solidColor = Color.Blue;
            Rectangle solidRectangle;
            for (int i = 0; i < monthsInAYear; i++)
            {
                sunshine = Convert.ToInt32(theMonths[i].getHoursSunshine());// amplifly the results by 5 times 

                solidRectangle = new Rectangle(10 + spacing, (300 - sunshine), 30, sunshine);
                using (Graphics panelGraphics = panelGraph.CreateGraphics())
                using (solidBrush = new SolidBrush(solidColor))
                {
                    panelGraphics.FillRectangle(solidBrush, solidRectangle);//draw graphics
                }
                spacing = spacing + 35;
            }
        }
    }
}
