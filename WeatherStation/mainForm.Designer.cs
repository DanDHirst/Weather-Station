﻿namespace WeatherStation
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.boxLocaData = new System.Windows.Forms.GroupBox();
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
            this.label11 = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnEditYear = new System.Windows.Forms.Button();
            this.btnAddYear = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.dgdMonths = new System.Windows.Forms.DataGridView();
            this.boxMonth = new System.Windows.Forms.GroupBox();
            this.btnEditMonth = new System.Windows.Forms.Button();
            this.btnSaveChnages = new System.Windows.Forms.Button();
            this.boxLocaData.SuspendLayout();
            this.boxYearData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdMonths)).BeginInit();
            this.boxMonth.SuspendLayout();
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
            this.boxLocaData.Size = new System.Drawing.Size(354, 313);
            this.boxLocaData.TabIndex = 7;
            this.boxLocaData.TabStop = false;
            this.boxLocaData.Text = "Location data";
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.Location = new System.Drawing.Point(39, 121);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(40, 13);
            this.lblCounty.TabIndex = 13;
            this.lblCounty.Text = "County";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(39, 233);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(54, 13);
            this.lblLongitude.TabIndex = 12;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(39, 196);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(45, 13);
            this.lblLatitude.TabIndex = 11;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblPostCode
            // 
            this.lblPostCode.AutoSize = true;
            this.lblPostCode.Location = new System.Drawing.Point(39, 159);
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
            this.lblLocName.Location = new System.Drawing.Point(38, 38);
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
            this.boxYearData.Controls.Add(this.label11);
            this.boxYearData.Controls.Add(this.lblYear);
            this.boxYearData.Controls.Add(this.btnEditYear);
            this.boxYearData.Controls.Add(this.btnAddYear);
            this.boxYearData.Controls.Add(this.txtDescription);
            this.boxYearData.Controls.Add(this.txtYear);
            this.boxYearData.Location = new System.Drawing.Point(460, 398);
            this.boxYearData.Name = "boxYearData";
            this.boxYearData.Size = new System.Drawing.Size(354, 313);
            this.boxYearData.TabIndex = 28;
            this.boxYearData.TabStop = false;
            this.boxYearData.Text = "Year data";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Description";
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
            // btnEditYear
            // 
            this.btnEditYear.Location = new System.Drawing.Point(200, 131);
            this.btnEditYear.Name = "btnEditYear";
            this.btnEditYear.Size = new System.Drawing.Size(106, 40);
            this.btnEditYear.TabIndex = 7;
            this.btnEditYear.Text = "Edit";
            this.btnEditYear.UseVisualStyleBackColor = true;
            this.btnEditYear.Click += new System.EventHandler(this.btnEditYear_Click);
            // 
            // btnAddYear
            // 
            this.btnAddYear.Location = new System.Drawing.Point(52, 131);
            this.btnAddYear.Name = "btnAddYear";
            this.btnAddYear.Size = new System.Drawing.Size(92, 41);
            this.btnAddYear.TabIndex = 6;
            this.btnAddYear.Text = "Add";
            this.btnAddYear.UseVisualStyleBackColor = true;
            this.btnAddYear.Click += new System.EventHandler(this.btnAddYear_Click);
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
            this.boxMonth.Controls.Add(this.btnEditMonth);
            this.boxMonth.Location = new System.Drawing.Point(852, 398);
            this.boxMonth.Name = "boxMonth";
            this.boxMonth.Size = new System.Drawing.Size(354, 313);
            this.boxMonth.TabIndex = 30;
            this.boxMonth.TabStop = false;
            this.boxMonth.Text = "Month Controls";
            // 
            // btnEditMonth
            // 
            this.btnEditMonth.Location = new System.Drawing.Point(33, 54);
            this.btnEditMonth.Name = "btnEditMonth";
            this.btnEditMonth.Size = new System.Drawing.Size(106, 40);
            this.btnEditMonth.TabIndex = 7;
            this.btnEditMonth.Text = "Edit";
            this.btnEditMonth.UseVisualStyleBackColor = true;
            this.btnEditMonth.Click += new System.EventHandler(this.btnEditMonth_Click);
            // 
            // btnSaveChnages
            // 
            this.btnSaveChnages.Location = new System.Drawing.Point(586, 768);
            this.btnSaveChnages.Name = "btnSaveChnages";
            this.btnSaveChnages.Size = new System.Drawing.Size(106, 40);
            this.btnSaveChnages.TabIndex = 31;
            this.btnSaveChnages.Text = "Save Changes";
            this.btnSaveChnages.UseVisualStyleBackColor = true;
            this.btnSaveChnages.Click += new System.EventHandler(this.btnSaveChnages_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1573, 876);
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
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnAddYear;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.DataGridView dgdMonths;
        private System.Windows.Forms.GroupBox boxMonth;
        private System.Windows.Forms.Button btnEditMonth;
        private System.Windows.Forms.Button btnSaveChnages;
    }
}

