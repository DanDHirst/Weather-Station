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
            string filename;
            openFileDialog1.ShowDialog();
            filename = openFileDialog1.FileName;
            StreamReader TheData = new StreamReader(filename);
            int numOfYears, NumLocations;
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
    }
}
