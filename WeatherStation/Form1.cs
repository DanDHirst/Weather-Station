using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            Location plymouth = new Location("plymouth", "asd2", "asd", "pl12", "324234", "213123");
            Yearly id3 = new Yearly(2017);
            Monthly febuary = new Monthly("asdasd", 2, 4, 2, 4, 2);
            MessageBox.Show(plymouth.getLocationName()+ id3.getYear() + febuary.getId());


        }
    }
}
