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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lstLocations = new System.Windows.Forms.ListBox();
            this.lstYears = new System.Windows.Forms.ListBox();
            this.lstMonths = new System.Windows.Forms.ListBox();
            this.lstLocData = new System.Windows.Forms.ListBox();
            this.lstYearData = new System.Windows.Forms.ListBox();
            this.lstMonthData = new System.Windows.Forms.ListBox();
            this.boxEditLoc = new System.Windows.Forms.GroupBox();
            this.btnEditLoc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // lstLocations
            // 
            this.lstLocations.FormattingEnabled = true;
            this.lstLocations.Location = new System.Drawing.Point(11, 25);
            this.lstLocations.Margin = new System.Windows.Forms.Padding(2);
            this.lstLocations.Name = "lstLocations";
            this.lstLocations.Size = new System.Drawing.Size(200, 147);
            this.lstLocations.TabIndex = 1;
            this.lstLocations.SelectedIndexChanged += new System.EventHandler(this.lstLocations_SelectedIndexChanged);
            // 
            // lstYears
            // 
            this.lstYears.FormattingEnabled = true;
            this.lstYears.Location = new System.Drawing.Point(217, 25);
            this.lstYears.Name = "lstYears";
            this.lstYears.Size = new System.Drawing.Size(163, 147);
            this.lstYears.TabIndex = 2;
            this.lstYears.SelectedIndexChanged += new System.EventHandler(this.lstYears_SelectedIndexChanged);
            // 
            // lstMonths
            // 
            this.lstMonths.FormattingEnabled = true;
            this.lstMonths.Location = new System.Drawing.Point(386, 25);
            this.lstMonths.Name = "lstMonths";
            this.lstMonths.Size = new System.Drawing.Size(192, 147);
            this.lstMonths.TabIndex = 3;
            this.lstMonths.SelectedIndexChanged += new System.EventHandler(this.lstMonths_SelectedIndexChanged);
            // 
            // lstLocData
            // 
            this.lstLocData.FormattingEnabled = true;
            this.lstLocData.Location = new System.Drawing.Point(11, 181);
            this.lstLocData.Name = "lstLocData";
            this.lstLocData.Size = new System.Drawing.Size(200, 173);
            this.lstLocData.TabIndex = 4;
            // 
            // lstYearData
            // 
            this.lstYearData.FormattingEnabled = true;
            this.lstYearData.Location = new System.Drawing.Point(217, 181);
            this.lstYearData.Name = "lstYearData";
            this.lstYearData.Size = new System.Drawing.Size(163, 173);
            this.lstYearData.TabIndex = 5;
            // 
            // lstMonthData
            // 
            this.lstMonthData.FormattingEnabled = true;
            this.lstMonthData.Location = new System.Drawing.Point(386, 181);
            this.lstMonthData.Name = "lstMonthData";
            this.lstMonthData.Size = new System.Drawing.Size(192, 173);
            this.lstMonthData.TabIndex = 6;
            // 
            // boxEditLoc
            // 
            this.boxEditLoc.Location = new System.Drawing.Point(784, 25);
            this.boxEditLoc.Name = "boxEditLoc";
            this.boxEditLoc.Size = new System.Drawing.Size(406, 182);
            this.boxEditLoc.TabIndex = 7;
            this.boxEditLoc.TabStop = false;
            this.boxEditLoc.Text = "Edit Location";
            // 
            // btnEditLoc
            // 
            this.btnEditLoc.Location = new System.Drawing.Point(11, 500);
            this.btnEditLoc.Name = "btnEditLoc";
            this.btnEditLoc.Size = new System.Drawing.Size(178, 51);
            this.btnEditLoc.TabIndex = 8;
            this.btnEditLoc.Text = "Edit location";
            this.btnEditLoc.UseVisualStyleBackColor = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1271, 624);
            this.Controls.Add(this.btnEditLoc);
            this.Controls.Add(this.boxEditLoc);
            this.Controls.Add(this.lstMonthData);
            this.Controls.Add(this.lstYearData);
            this.Controls.Add(this.lstLocData);
            this.Controls.Add(this.lstMonths);
            this.Controls.Add(this.lstYears);
            this.Controls.Add(this.lstLocations);
            this.Name = "mainForm";
            this.Text = "Weather Station application";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lstLocations;
        private System.Windows.Forms.ListBox lstYears;
        private System.Windows.Forms.ListBox lstMonths;
        private System.Windows.Forms.ListBox lstLocData;
        private System.Windows.Forms.ListBox lstYearData;
        private System.Windows.Forms.ListBox lstMonthData;
        private System.Windows.Forms.GroupBox boxEditLoc;
        private System.Windows.Forms.Button btnEditLoc;
    }
}

