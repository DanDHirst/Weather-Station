namespace WeatherStation
{
    partial class mainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.boxLocaData = new System.Windows.Forms.GroupBox();
            this.lblLocationSearchResponse = new System.Windows.Forms.Label();
            this.btnLocSearch = new System.Windows.Forms.Button();
            this.txtLocSearch = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblPostCode = new System.Windows.Forms.Label();
            this.lblStreetNumAndName = new System.Windows.Forms.Label();
            this.lblLocName = new System.Windows.Forms.Label();
            this.btnEditLoc = new System.Windows.Forms.Button();
            this.btnAddLoc = new System.Windows.Forms.Button();
            this.txtLongitude = new System.Windows.Forms.TextBox();
            this.txtPostCode = new System.Windows.Forms.TextBox();
            this.txtLatitude = new System.Windows.Forms.TextBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.txtstreetNumAndName = new System.Windows.Forms.TextBox();
            this.txtLocName = new System.Windows.Forms.TextBox();
            this.boxYearData = new System.Windows.Forms.GroupBox();
            this.lblSearchYearResponse = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearchYearData = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnAddNewYear = new System.Windows.Forms.Button();
            this.dgdMonths = new System.Windows.Forms.DataGridView();
            this.boxMonth = new System.Windows.Forms.GroupBox();
            this.lblSearchMonth = new System.Windows.Forms.Label();
            this.boxNewYearandMonth = new System.Windows.Forms.GroupBox();
            this.lblSetNewDescription = new System.Windows.Forms.Label();
            this.txtSetYearDescription = new System.Windows.Forms.TextBox();
            this.lblSetYear = new System.Windows.Forms.Label();
            this.txtSetNewYear = new System.Windows.Forms.TextBox();
            this.btnSearchMonth = new System.Windows.Forms.Button();
            this.txtSearchMonth = new System.Windows.Forms.TextBox();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnSaveChnages = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radHoursSunshine = new System.Windows.Forms.RadioButton();
            this.radMMRainfall = new System.Windows.Forms.RadioButton();
            this.radNumDaysOfAirFrost = new System.Windows.Forms.RadioButton();
            this.radMinTemp = new System.Windows.Forms.RadioButton();
            this.radMaxTemp = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.boxGraph = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblKey1 = new System.Windows.Forms.Label();
            this.lblKey5 = new System.Windows.Forms.Label();
            this.lblKey4 = new System.Windows.Forms.Label();
            this.lblKey3 = new System.Windows.Forms.Label();
            this.lblKey2 = new System.Windows.Forms.Label();
            this.panelGraph = new System.Windows.Forms.Panel();
            this.lblMonth12 = new System.Windows.Forms.Label();
            this.lblMonth1 = new System.Windows.Forms.Label();
            this.lblMonth11 = new System.Windows.Forms.Label();
            this.lblMonth2 = new System.Windows.Forms.Label();
            this.lblMonth10 = new System.Windows.Forms.Label();
            this.lblMonth3 = new System.Windows.Forms.Label();
            this.lblMonth9 = new System.Windows.Forms.Label();
            this.lblMonth4 = new System.Windows.Forms.Label();
            this.lblMonth8 = new System.Windows.Forms.Label();
            this.lblMonth5 = new System.Windows.Forms.Label();
            this.lblMonth7 = new System.Windows.Forms.Label();
            this.lblMonth6 = new System.Windows.Forms.Label();
            this.lblMonthGraph = new System.Windows.Forms.Label();
            this.boxLocaData.SuspendLayout();
            this.boxYearData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).BeginInit();
            this.boxMonth.SuspendLayout();
            this.boxNewYearandMonth.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.boxGraph.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(72, 25);
            this.lstLocations.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(354, 342);
            this.lstLocations.TabIndex = 1;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // lstYears
            // 
            this.lstYears.FormattingEnabled = true;
            this.lstYears.Location = new System.Drawing.Point(460, 25);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(248, 342);
            this.lstYears.TabIndex = 2;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // boxLocaData
            // 
            this.boxLocaData.Controls.Add(this.lblLocationSearchResponse);
            this.boxLocaData.Controls.Add(this.btnLocSearch);
            this.boxLocaData.Controls.Add(this.txtLocSearch);
            this.boxLocaData.Controls.Add(this.lblCounty);
            this.boxLocaData.Controls.Add(this.lblLongitude);
            this.boxLocaData.Controls.Add(this.lblLatitude);
            this.boxLocaData.Controls.Add(this.lblPostCode);
            this.boxLocaData.Controls.Add(this.lblStreetNumAndName);
            this.boxLocaData.Controls.Add(this.lblLocName);
            this.boxLocaData.Controls.Add(this.btnEditLoc);
            this.boxLocaData.Controls.Add(this.btnAddLoc);
            this.boxLocaData.Controls.Add(this.txtLongitude);
            this.boxLocaData.Controls.Add(this.txtPostCode);
            this.boxLocaData.Controls.Add(this.txtLatitude);
            this.boxLocaData.Controls.Add(this.txtCounty);
            this.boxLocaData.Controls.Add(this.txtstreetNumAndName);
            this.boxLocaData.Controls.Add(this.txtLocName);
            this.boxLocaData.Location = new System.Drawing.Point(72, 398);
            this.boxLocaData.Name = "boxLocaData";
            this.boxLocaData.Size = new System.Drawing.Size(354, 397);
            this.boxLocaData.TabIndex = 7;
            this.boxLocaData.TabStop = false;
            this.boxLocaData.Text = "Location data";
            // 
            // lblLocationSearchResponse
            // 
            this.lblLocationSearchResponse.AutoSize = true;
            this.lblLocationSearchResponse.Location = new System.Drawing.Point(119, 369);
            this.lblLocationSearchResponse.Name = "lblLocationSearchResponse";
            this.lblLocationSearchResponse.Size = new System.Drawing.Size(0, 13);
            this.lblLocationSearchResponse.TabIndex = 16;
            // 
            // btnLocSearch
            // 
            this.btnLocSearch.Location = new System.Drawing.Point(215, 337);
            this.btnLocSearch.Name = "btnLocSearch";
            this.btnLocSearch.Size = new System.Drawing.Size(106, 29);
            this.btnLocSearch.TabIndex = 15;
            this.btnLocSearch.Text = "Search Location";
            this.btnLocSearch.UseVisualStyleBackColor = true;
            this.btnLocSearch.Click += new System.EventHandler(this.btnLocSearch_Click);
            // 
            // txtLocSearch
            // 
            this.txtLocSearch.Location = new System.Drawing.Point(30, 346);
            this.txtLocSearch.Name = "txtLocSearch";
            this.txtLocSearch.Size = new System.Drawing.Size(154, 20);
            this.txtLocSearch.TabIndex = 14;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(13, 117);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 13;
            this.lblCounty.Text = "County";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(11, 233);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(54, 13);
            this.lblLongitude.TabIndex = 12;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(13, 196);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(45, 13);
            this.lblLatitude.TabIndex = 11;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(13, 158);
            this.lblPostCode.Name = "lblPostCode";
            this.lblPostCode.Size = new System.Drawing.Size(52, 13);
            this.lblPostCode.TabIndex = 10;
            this.lblPostCode.Text = "Postcode";
            // 
            // lblStreetNumAndName
            // 
            this.lblStreetNumAndName.AutoSize = true;
            this.lblStreetNumAndName.Location = new System.Drawing.Point(13, 81);
            this.lblStreetNumAndName.Name = "lblStreetNumAndName";
            this.lblStreetNumAndName.Size = new System.Drawing.Size(127, 13);
            this.lblStreetNumAndName.TabIndex = 9;
            this.lblStreetNumAndName.Text = "Street Number and Name";
            // 
            // lblLocName
            // 
            this.lblLocName.AutoSize = true;
            this.lblLocName.Location = new System.Drawing.Point(13, 38);
            this.lblLocName.Name = "lblLocName";
            this.lblLocName.Size = new System.Drawing.Size(79, 13);
            this.lblLocName.TabIndex = 8;
            this.lblLocName.Text = "Location Name";
            // 
            // btnEditLoc
            // 
            this.btnEditLoc.Location = new System.Drawing.Point(215, 266);
            this.btnEditLoc.Name = "btnEditLoc";
            this.btnEditLoc.Size = new System.Drawing.Size(106, 40);
            this.btnEditLoc.TabIndex = 7;
            this.btnEditLoc.Text = "Edit";
            this.btnEditLoc.UseVisualStyleBackColor = true;
            this.btnEditLoc.Click += new System.EventHandler(this.btnEditLoc_Click);
            // 
            // btnAddLoc
            // 
            this.btnAddLoc.Location = new System.Drawing.Point(42, 266);
            this.btnAddLoc.Name = "btnAddLoc";
            this.btnAddLoc.Size = new System.Drawing.Size(92, 41);
            this.btnAddLoc.TabIndex = 6;
            this.btnAddLoc.Text = "Add";
            this.btnAddLoc.UseVisualStyleBackColor = true;
            this.btnAddLoc.Click += new System.EventHandler(this.btnAddLoc_Click);
            // 
            // txtLongitude
            // 
            this.txtLongitude.Location = new System.Drawing.Point(146, 230);
            this.txtLongitude.Name = "txtLongitude";
            this.txtLongitude.Size = new System.Drawing.Size(188, 20);
            this.txtLongitude.TabIndex = 5;
            // 
            // txtPostCode
            // 
            this.txtPostCode.Location = new System.Drawing.Point(146, 156);
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.Size = new System.Drawing.Size(188, 20);
            this.txtPostCode.TabIndex = 4;
            // 
            // txtLatitude
            // 
            this.txtLatitude.Location = new System.Drawing.Point(146, 193);
            this.txtLatitude.Name = "txtLatitude";
            this.txtLatitude.Size = new System.Drawing.Size(188, 20);
            this.txtLatitude.TabIndex = 3;
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(146, 114);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(188, 20);
            this.txtCounty.TabIndex = 2;
            // 
            // txtstreetNumAndName
            // 
            this.txtstreetNumAndName.Location = new System.Drawing.Point(146, 78);
            this.txtstreetNumAndName.Name = "txtstreetNumAndName";
            this.txtstreetNumAndName.Size = new System.Drawing.Size(188, 20);
            this.txtstreetNumAndName.TabIndex = 1;
            // 
            // txtLocName
            // 
            this.txtLocName.Location = new System.Drawing.Point(146, 38);
            this.txtLocName.Name = "txtLocName";
            this.txtLocName.Size = new System.Drawing.Size(188, 20);
            this.txtLocName.TabIndex = 0;
            // 
            // boxYearData
            // 
            this.boxYearData.Controls.Add(this.lblSearchYearResponse);
            this.boxYearData.Controls.Add(this.label11);
            this.boxYearData.Controls.Add(this.btnSearchYearData);
            this.boxYearData.Controls.Add(this.lblYear);
            this.boxYearData.Controls.Add(this.txtSearchYear);
            this.boxYearData.Controls.Add(this.btnEditYear);
            this.boxYearData.Controls.Add(this.txtDescription);
            this.boxYearData.Controls.Add(this.txtYear);
            this.boxYearData.Location = new System.Drawing.Point(460, 398);
            this.boxYearData.Name = "boxYearData";
            this.boxYearData.Size = new System.Drawing.Size(354, 397);
            this.boxYearData.TabIndex = 28;
            this.boxYearData.TabStop = false;
            this.boxYearData.Text = "Year data";
            // 
            // lblSearchYearResponse
            // 
            this.lblSearchYearResponse.AutoSize = true;
            this.lblSearchYearResponse.Location = new System.Drawing.Point(119, 244);
            this.lblSearchYearResponse.Name = "lblSearchYearResponse";
            this.lblSearchYearResponse.Size = new System.Drawing.Size(0, 13);
            this.lblSearchYearResponse.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Description";
            // 
            // btnSearchYearData
            // 
            this.btnSearchYearData.Location = new System.Drawing.Point(215, 212);
            this.btnSearchYearData.Name = "btnSearchYearData";
            this.btnSearchYearData.Size = new System.Drawing.Size(106, 29);
            this.btnSearchYearData.TabIndex = 18;
            this.btnSearchYearData.Text = "Search Year";
            this.btnSearchYearData.UseVisualStyleBackColor = true;
            this.btnSearchYearData.Click += new System.EventHandler(this.btnSearchYearData_Click);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(38, 38);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 8;
            this.lblYear.Text = "Year";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Location = new System.Drawing.Point(30, 221);
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(154, 20);
            this.txtSearchYear.TabIndex = 17;
            // 
            // btnEditYear
            // 
            this.btnEditYear.Location = new System.Drawing.Point(146, 136);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(106, 40);
            this.btnEditYear.TabIndex = 7;
            this.btnEditYear.Text = "Edit";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(146, 78);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(188, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(146, 38);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(188, 20);
            this.txtYear.TabIndex = 0;
            // 
            // btnAddNewYear
            // 
            this.btnAddNewYear.Location = new System.Drawing.Point(107, 125);
            this.btnAddNewYear.Name = "btnAddNewYear";
            this.btnAddNewYear.Size = new System.Drawing.Size(92, 41);
            this.btnAddNewYear.TabIndex = 6;
            this.btnAddNewYear.Text = "Add";
            this.btnAddNewYear.UseVisualStyleBackColor = true;
            this.btnAddNewYear.Click += new System.EventHandler(this.btnAddNewYear_Click);
            // 
            // dgdMonths
            // 
            this.dgdMonths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdMonths.Location = new System.Drawing.Point(719, 25);
            this.dgdMonths.Name = "dgdMonths";
            this.dgdMonths.Size = new System.Drawing.Size(823, 344);
            this.dgdMonths.TabIndex = 29;
            // 
            // boxMonth
            // 
            this.boxMonth.Controls.Add(this.lblSearchMonth);
            this.boxMonth.Controls.Add(this.boxNewYearandMonth);
            this.boxMonth.Controls.Add(this.btnSearchMonth);
            this.boxMonth.Controls.Add(this.txtSearchMonth);
            this.boxMonth.Controls.Add(this.btnEditMonth);
            this.boxMonth.Location = new System.Drawing.Point(852, 398);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(354, 313);
            this.boxMonth.TabIndex = 30;
            this.boxMonth.TabStop = false;
            this.boxMonth.Text = "Month Controls";
            // 
            // lblSearchMonth
            // 
            this.lblSearchMonth.AutoSize = true;
            this.lblSearchMonth.Location = new System.Drawing.Point(116, 288);
            this.lblSearchMonth.Name = "lblSearchMonth";
            this.lblSearchMonth.Size = new System.Drawing.Size(0, 13);
            this.lblSearchMonth.TabIndex = 22;
            // 
            // boxNewYearandMonth
            // 
            this.boxNewYearandMonth.Controls.Add(this.lblSetNewDescription);
            this.boxNewYearandMonth.Controls.Add(this.txtSetYearDescription);
            this.boxNewYearandMonth.Controls.Add(this.lblSetYear);
            this.boxNewYearandMonth.Controls.Add(this.txtSetNewYear);
            this.boxNewYearandMonth.Controls.Add(this.btnAddNewYear);
            this.boxNewYearandMonth.Location = new System.Drawing.Point(6, 20);
            this.boxNewYearandMonth.Name = "boxNewYearandMonth";
            this.boxNewYearandMonth.Size = new System.Drawing.Size(342, 189);
            this.boxNewYearandMonth.TabIndex = 12;
            this.boxNewYearandMonth.TabStop = false;
            this.boxNewYearandMonth.Text = "Add new Year";
            // 
            // lblSetNewDescription
            // 
            this.lblSetNewDescription.AutoSize = true;
            this.lblSetNewDescription.Location = new System.Drawing.Point(16, 83);
            this.lblSetNewDescription.Name = "lblSetNewDescription";
            this.lblSetNewDescription.Size = new System.Drawing.Size(104, 13);
            this.lblSetNewDescription.TabIndex = 11;
            this.lblSetNewDescription.Text = "Set New Description";
            // 
            // txtSetYearDescription
            // 
            this.txtSetYearDescription.Location = new System.Drawing.Point(124, 80);
            this.txtSetYearDescription.Name = "txtSetYearDescription";
            this.txtSetYearDescription.Size = new System.Drawing.Size(188, 20);
            this.txtSetYearDescription.TabIndex = 10;
            // 
            // lblSetYear
            // 
            this.lblSetYear.AutoSize = true;
            this.lblSetYear.Location = new System.Drawing.Point(16, 43);
            this.lblSetYear.Name = "lblSetYear";
            this.lblSetYear.Size = new System.Drawing.Size(73, 13);
            this.lblSetYear.TabIndex = 10;
            this.lblSetYear.Text = "Set New Year";
            // 
            // txtSetNewYear
            // 
            this.txtSetNewYear.Location = new System.Drawing.Point(124, 43);
            this.txtSetNewYear.Name = "txtSetNewYear";
            this.txtSetNewYear.Size = new System.Drawing.Size(188, 20);
            this.txtSetNewYear.TabIndex = 9;
            // 
            // btnSearchMonth
            // 
            this.btnSearchMonth.Location = new System.Drawing.Point(212, 256);
            this.btnSearchMonth.Name = "btnSearchMonth";
            this.btnSearchMonth.Size = new System.Drawing.Size(106, 29);
            this.btnSearchMonth.TabIndex = 21;
            this.btnSearchMonth.Text = "Search Month";
            this.btnSearchMonth.UseVisualStyleBackColor = true;
            this.btnSearchMonth.Click += new System.EventHandler(this.btnSearchMonth_Click);
            // 
            // txtSearchMonth
            // 
            this.txtSearchMonth.Location = new System.Drawing.Point(27, 265);
            this.txtSearchMonth.Name = "txtSearchMonth";
            this.txtSearchMonth.Size = new System.Drawing.Size(154, 20);
            this.txtSearchMonth.TabIndex = 20;
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Location = new System.Drawing.Point(113, 210);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(106, 40);
            this.btnEditMonth.TabIndex = 7;
            this.btnEditMonth.Text = "Edit";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // btnSaveChnages
            // 
            this.btnSaveChnages.Location = new System.Drawing.Point(579, 824);
            this.btnSaveChnages.Name = "btnSaveChnages";
            this.btnSaveChnages.Size = new System.Drawing.Size(106, 40);
            this.btnSaveChnages.TabIndex = 31;
            this.btnSaveChnages.Text = "Save Changes";
            this.btnSaveChnages.UseVisualStyleBackColor = true;
            this.btnSaveChnages.Click += new System.EventHandler(this.btnSaveChnages_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radHoursSunshine);
            this.groupBox1.Controls.Add(this.radMMRainfall);
            this.groupBox1.Controls.Add(this.radNumDaysOfAirFrost);
            this.groupBox1.Controls.Add(this.radMinTemp);
            this.groupBox1.Controls.Add(this.radMaxTemp);
            this.groupBox1.Location = new System.Drawing.Point(1562, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 246);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Montly obervations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radHoursSunshine
            // 
            this.radHoursSunshine.AutoSize = true;
            this.radHoursSunshine.Location = new System.Drawing.Point(20, 209);
            this.radHoursSunshine.Name = "radHoursSunshine";
            this.radHoursSunshine.Size = new System.Drawing.Size(103, 17);
            this.radHoursSunshine.TabIndex = 4;
            this.radHoursSunshine.Text = "Sunshine(Hours)";
            this.radHoursSunshine.UseVisualStyleBackColor = true;
            this.radHoursSunshine.CheckedChanged += new System.EventHandler(this.radHoursSunshine_CheckedChanged);
            // 
            // radMMRainfall
            // 
            this.radMMRainfall.AutoSize = true;
            this.radMMRainfall.Location = new System.Drawing.Point(20, 166);
            this.radMMRainfall.Name = "radMMRainfall";
            this.radMMRainfall.Size = new System.Drawing.Size(82, 17);
            this.radMMRainfall.TabIndex = 3;
            this.radMMRainfall.Text = "Rainfall(mm)";
            this.radMMRainfall.UseVisualStyleBackColor = true;
            this.radMMRainfall.CheckedChanged += new System.EventHandler(this.radMMRainfall_CheckedChanged);
            // 
            // radNumDaysOfAirFrost
            // 
            this.radNumDaysOfAirFrost.AutoSize = true;
            this.radNumDaysOfAirFrost.Location = new System.Drawing.Point(20, 117);
            this.radNumDaysOfAirFrost.Name = "radNumDaysOfAirFrost";
            this.radNumDaysOfAirFrost.Size = new System.Drawing.Size(156, 17);
            this.radNumDaysOfAirFrost.TabIndex = 2;
            this.radNumDaysOfAirFrost.Text = "Number of Days Of Air Frost";
            this.radNumDaysOfAirFrost.UseVisualStyleBackColor = true;
            this.radNumDaysOfAirFrost.CheckedChanged += new System.EventHandler(this.radNumDaysOfAirFrost_CheckedChanged);
            // 
            // radMinTemp
            // 
            this.radMinTemp.AutoSize = true;
            this.radMinTemp.Location = new System.Drawing.Point(20, 70);
            this.radMinTemp.Name = "radMinTemp";
            this.radMinTemp.Size = new System.Drawing.Size(129, 17);
            this.radMinTemp.TabIndex = 1;
            this.radMinTemp.Text = "Minimum Temperature";
            this.radMinTemp.UseVisualStyleBackColor = true;
            this.radMinTemp.CheckedChanged += new System.EventHandler(this.radMinTemp_CheckedChanged);
            // 
            // radMaxTemp
            // 
            this.radMaxTemp.AutoSize = true;
            this.radMaxTemp.Location = new System.Drawing.Point(20, 32);
            this.radMaxTemp.Name = "radMaxTemp";
            this.radMaxTemp.Size = new System.Drawing.Size(132, 17);
            this.radMaxTemp.TabIndex = 0;
            this.radMaxTemp.Text = "Maximum Temperature";
            this.radMaxTemp.UseVisualStyleBackColor = true;
            this.radMaxTemp.CheckedChanged += new System.EventHandler(this.radMaxTemp_CheckedChanged);
            // 
            // boxGraph
            // 
            this.boxGraph.Controls.Add(this.lblTitle);
            this.boxGraph.Controls.Add(this.lblKey1);
            this.boxGraph.Controls.Add(this.lblKey5);
            this.boxGraph.Controls.Add(this.lblKey4);
            this.boxGraph.Controls.Add(this.lblKey3);
            this.boxGraph.Controls.Add(this.lblKey2);
            this.boxGraph.Controls.Add(this.panelGraph);
            this.boxGraph.Controls.Add(this.lblMonth12);
            this.boxGraph.Controls.Add(this.lblMonth1);
            this.boxGraph.Controls.Add(this.lblMonth11);
            this.boxGraph.Controls.Add(this.lblMonth2);
            this.boxGraph.Controls.Add(this.lblMonth10);
            this.boxGraph.Controls.Add(this.lblMonth3);
            this.boxGraph.Controls.Add(this.lblMonth9);
            this.boxGraph.Controls.Add(this.lblMonth4);
            this.boxGraph.Controls.Add(this.lblMonth8);
            this.boxGraph.Controls.Add(this.lblMonth5);
            this.boxGraph.Controls.Add(this.lblMonth7);
            this.boxGraph.Controls.Add(this.lblMonth6);
            this.boxGraph.Location = new System.Drawing.Point(1265, 409);
            this.boxGraph.Name = "boxGraph";
            this.boxGraph.Size = new System.Drawing.Size(536, 414);
            this.boxGraph.TabIndex = 33;
            this.boxGraph.TabStop = false;
            this.boxGraph.Text = "Graph";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(182, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(155, 13);
            this.lblTitle.TabIndex = 36;
            this.lblTitle.Text = "Maximum Temperature (celsuis)";
            // 
            // lblKey1
            // 
            this.lblKey1.AutoSize = true;
            this.lblKey1.Location = new System.Drawing.Point(4, 283);
            this.lblKey1.Name = "lblKey1";
            this.lblKey1.Size = new System.Drawing.Size(13, 13);
            this.lblKey1.TabIndex = 15;
            this.lblKey1.Text = "5";
            // 
            // lblKey5
            // 
            this.lblKey5.AutoSize = true;
            this.lblKey5.Location = new System.Drawing.Point(0, 89);
            this.lblKey5.Name = "lblKey5";
            this.lblKey5.Size = new System.Drawing.Size(19, 13);
            this.lblKey5.TabIndex = 17;
            this.lblKey5.Text = "25";
            // 
            // lblKey4
            // 
            this.lblKey4.AutoSize = true;
            this.lblKey4.Location = new System.Drawing.Point(0, 134);
            this.lblKey4.Name = "lblKey4";
            this.lblKey4.Size = new System.Drawing.Size(19, 13);
            this.lblKey4.TabIndex = 16;
            this.lblKey4.Text = "20";
            // 
            // lblKey3
            // 
            this.lblKey3.AutoSize = true;
            this.lblKey3.Location = new System.Drawing.Point(0, 182);
            this.lblKey3.Name = "lblKey3";
            this.lblKey3.Size = new System.Drawing.Size(19, 13);
            this.lblKey3.TabIndex = 15;
            this.lblKey3.Text = "15";
            // 
            // lblKey2
            // 
            this.lblKey2.AutoSize = true;
            this.lblKey2.Location = new System.Drawing.Point(0, 233);
            this.lblKey2.Name = "lblKey2";
            this.lblKey2.Size = new System.Drawing.Size(19, 13);
            this.lblKey2.TabIndex = 14;
            this.lblKey2.Text = "10";
            // 
            // panelGraph
            // 
            this.panelGraph.BackColor = System.Drawing.SystemColors.Window;
            this.panelGraph.Location = new System.Drawing.Point(23, 40);
            this.panelGraph.Name = "panelGraph";
            this.panelGraph.Size = new System.Drawing.Size(478, 318);
            this.panelGraph.TabIndex = 0;
            this.panelGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGraph_Paint);
            // 
            // lblMonth12
            // 
            this.lblMonth12.AutoSize = true;
            this.lblMonth12.Location = new System.Drawing.Point(451, 361);
            this.lblMonth12.Name = "lblMonth12";
            this.lblMonth12.Size = new System.Drawing.Size(19, 13);
            this.lblMonth12.TabIndex = 13;
            this.lblMonth12.Text = "12";
            // 
            // lblMonth1
            // 
            this.lblMonth1.AutoSize = true;
            this.lblMonth1.Location = new System.Drawing.Point(55, 361);
            this.lblMonth1.Name = "lblMonth1";
            this.lblMonth1.Size = new System.Drawing.Size(13, 13);
            this.lblMonth1.TabIndex = 2;
            this.lblMonth1.Text = "1";
            // 
            // lblMonth11
            // 
            this.lblMonth11.AutoSize = true;
            this.lblMonth11.Location = new System.Drawing.Point(412, 361);
            this.lblMonth11.Name = "lblMonth11";
            this.lblMonth11.Size = new System.Drawing.Size(19, 13);
            this.lblMonth11.TabIndex = 12;
            this.lblMonth11.Text = "11";
            // 
            // lblMonth2
            // 
            this.lblMonth2.AutoSize = true;
            this.lblMonth2.Location = new System.Drawing.Point(91, 361);
            this.lblMonth2.Name = "lblMonth2";
            this.lblMonth2.Size = new System.Drawing.Size(13, 13);
            this.lblMonth2.TabIndex = 3;
            this.lblMonth2.Text = "2";
            // 
            // lblMonth10
            // 
            this.lblMonth10.AutoSize = true;
            this.lblMonth10.Location = new System.Drawing.Point(380, 361);
            this.lblMonth10.Name = "lblMonth10";
            this.lblMonth10.Size = new System.Drawing.Size(19, 13);
            this.lblMonth10.TabIndex = 11;
            this.lblMonth10.Text = "10";
            // 
            // lblMonth3
            // 
            this.lblMonth3.AutoSize = true;
            this.lblMonth3.Location = new System.Drawing.Point(125, 361);
            this.lblMonth3.Name = "lblMonth3";
            this.lblMonth3.Size = new System.Drawing.Size(13, 13);
            this.lblMonth3.TabIndex = 4;
            this.lblMonth3.Text = "3";
            // 
            // lblMonth9
            // 
            this.lblMonth9.AutoSize = true;
            this.lblMonth9.Location = new System.Drawing.Point(344, 361);
            this.lblMonth9.Name = "lblMonth9";
            this.lblMonth9.Size = new System.Drawing.Size(13, 13);
            this.lblMonth9.TabIndex = 10;
            this.lblMonth9.Text = "9";
            // 
            // lblMonth4
            // 
            this.lblMonth4.AutoSize = true;
            this.lblMonth4.Location = new System.Drawing.Point(164, 361);
            this.lblMonth4.Name = "lblMonth4";
            this.lblMonth4.Size = new System.Drawing.Size(13, 13);
            this.lblMonth4.TabIndex = 5;
            this.lblMonth4.Text = "4";
            // 
            // lblMonth8
            // 
            this.lblMonth8.AutoSize = true;
            this.lblMonth8.Location = new System.Drawing.Point(309, 361);
            this.lblMonth8.Name = "lblMonth8";
            this.lblMonth8.Size = new System.Drawing.Size(13, 13);
            this.lblMonth8.TabIndex = 9;
            this.lblMonth8.Text = "8";
            // 
            // lblMonth5
            // 
            this.lblMonth5.AutoSize = true;
            this.lblMonth5.Location = new System.Drawing.Point(200, 361);
            this.lblMonth5.Name = "lblMonth5";
            this.lblMonth5.Size = new System.Drawing.Size(13, 13);
            this.lblMonth5.TabIndex = 6;
            this.lblMonth5.Text = "5";
            // 
            // lblMonth7
            // 
            this.lblMonth7.AutoSize = true;
            this.lblMonth7.Location = new System.Drawing.Point(269, 361);
            this.lblMonth7.Name = "lblMonth7";
            this.lblMonth7.Size = new System.Drawing.Size(13, 13);
            this.lblMonth7.TabIndex = 8;
            this.lblMonth7.Text = "7";
            // 
            // lblMonth6
            // 
            this.lblMonth6.AutoSize = true;
            this.lblMonth6.Location = new System.Drawing.Point(236, 361);
            this.lblMonth6.Name = "lblMonth6";
            this.lblMonth6.Size = new System.Drawing.Size(13, 13);
            this.lblMonth6.TabIndex = 7;
            this.lblMonth6.Text = "6";
            // 
            // lblMonthGraph
            // 
            this.lblMonthGraph.AutoSize = true;
            this.lblMonthGraph.Location = new System.Drawing.Point(1517, 797);
            this.lblMonthGraph.Name = "lblMonthGraph";
            this.lblMonthGraph.Size = new System.Drawing.Size(42, 13);
            this.lblMonthGraph.TabIndex = 35;
            this.lblMonthGraph.Text = "Months";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1837, 966);
            this.Controls.Add(this.lblMonthGraph);
            this.Controls.Add(this.boxGraph);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveChnages);
            this.Controls.Add(this.boxMonth);
            this.Controls.Add(this.dgdMonths);
            this.Controls.Add(this.boxYearData);
            this.Controls.Add(this.boxLocaData);
            this.Controls.Add(this.lstYears);
            this.Controls.Add(this.lstLocations);
            this.Name = "mainForm";
            this.Text = "Weather Station application";
            this.boxLocaData.ResumeLayout(false);
            this.boxLocaData.PerformLayout();
            this.boxYearData.ResumeLayout(false);
            this.boxYearData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).EndInit();
            this.boxMonth.ResumeLayout(false);
            this.boxMonth.PerformLayout();
            this.boxNewYearandMonth.ResumeLayout(false);
            this.boxNewYearandMonth.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.boxGraph.ResumeLayout(false);
            this.boxGraph.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.GroupBox boxLocaData;
        private System.Windows.Forms.TextBox txtLongitude;
        private System.Windows.Forms.TextBox txtPostCode;
        private System.Windows.Forms.TextBox txtLatitude;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.TextBox txtstreetNumAndName;
        private System.Windows.Forms.TextBox txtLocName;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblPostCode;
        private System.Windows.Forms.Label lblStreetNumAndName;
        private System.Windows.Forms.Label lblLocName;
        private System.Windows.Forms.Button btnEditLoc;
        private System.Windows.Forms.Button btnAddLoc;
        private System.Windows.Forms.GroupBox boxYearData;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnEditYear;
        private System.Windows.Forms.Button btnAddNewYear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DataGridView dgdMonths;
        private System.Windows.Forms.GroupBox boxMonth;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnSaveChnages;
        private System.Windows.Forms.Label lblSetNewDescription;
        private System.Windows.Forms.TextBox txtSetYearDescription;
        private System.Windows.Forms.Label lblSetYear;
        private System.Windows.Forms.TextBox txtSetNewYear;
        private System.Windows.Forms.GroupBox boxNewYearandMonth;
        private System.Windows.Forms.Button btnLocSearch;
        private System.Windows.Forms.TextBox txtLocSearch;
        private System.Windows.Forms.Label lblLocationSearchResponse;
        private System.Windows.Forms.Label lblSearchYearResponse;
        private System.Windows.Forms.Button btnSearchYearData;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label lblSearchMonth;
        private System.Windows.Forms.Button btnSearchMonth;
        private System.Windows.Forms.TextBox txtSearchMonth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radMMRainfall;
        private System.Windows.Forms.RadioButton radNumDaysOfAirFrost;
        private System.Windows.Forms.RadioButton radMinTemp;
        private System.Windows.Forms.RadioButton radMaxTemp;
        private System.Windows.Forms.RadioButton radHoursSunshine;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.GroupBox boxGraph;
        private System.Windows.Forms.Panel panelGraph;
        private System.Windows.Forms.Label lblMonth12;
        private System.Windows.Forms.Label lblMonth1;
        private System.Windows.Forms.Label lblMonth11;
        private System.Windows.Forms.Label lblMonth2;
        private System.Windows.Forms.Label lblMonth10;
        private System.Windows.Forms.Label lblMonth3;
        private System.Windows.Forms.Label lblMonth9;
        private System.Windows.Forms.Label lblMonth4;
        private System.Windows.Forms.Label lblMonth8;
        private System.Windows.Forms.Label lblMonth5;
        private System.Windows.Forms.Label lblMonth7;
        private System.Windows.Forms.Label lblMonth6;
        private System.Windows.Forms.Label lblMonthGraph;
        private System.Windows.Forms.Label lblKey5;
        private System.Windows.Forms.Label lblKey4;
        private System.Windows.Forms.Label lblKey3;
        private System.Windows.Forms.Label lblKey2;
        private System.Windows.Forms.Label lblKey1;
        private System.Windows.Forms.Label lblTitle;
    }
}

