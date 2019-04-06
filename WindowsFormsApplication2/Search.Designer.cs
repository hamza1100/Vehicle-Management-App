namespace WindowsFormsApplication2
{
    partial class Search
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
            this.label1 = new System.Windows.Forms.Label();
            this.ShowModelList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ShowYearList = new System.Windows.Forms.ComboBox();
            this.ShowRatingList = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ShowMakeList = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(118, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Make";
            // 
            // ShowModelList
            // 
            this.ShowModelList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowModelList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowModelList.FormattingEnabled = true;
            this.ShowModelList.Items.AddRange(new object[] {
            ""});
            this.ShowModelList.Location = new System.Drawing.Point(235, 181);
            this.ShowModelList.Name = "ShowModelList";
            this.ShowModelList.Size = new System.Drawing.Size(133, 24);
            this.ShowModelList.TabIndex = 2;
            this.ShowModelList.Click += new System.EventHandler(this.ShowModelList_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(118, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Plate";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(118, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // ShowYearList
            // 
            this.ShowYearList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowYearList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowYearList.FormattingEnabled = true;
            this.ShowYearList.Items.AddRange(new object[] {
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017"});
            this.ShowYearList.Location = new System.Drawing.Point(235, 275);
            this.ShowYearList.Name = "ShowYearList";
            this.ShowYearList.Size = new System.Drawing.Size(133, 24);
            this.ShowYearList.TabIndex = 5;
            // 
            // ShowRatingList
            // 
            this.ShowRatingList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowRatingList.FormattingEnabled = true;
            this.ShowRatingList.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.ShowRatingList.Location = new System.Drawing.Point(235, 367);
            this.ShowRatingList.Name = "ShowRatingList";
            this.ShowRatingList.Size = new System.Drawing.Size(133, 24);
            this.ShowRatingList.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(118, 374);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Driver Ratings";
            // 
            // ShowMakeList
            // 
            this.ShowMakeList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ShowMakeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ShowMakeList.FormattingEnabled = true;
            this.ShowMakeList.Items.AddRange(new object[] {
            "Toyota",
            "Honda",
            "Suzuki",
            "Ford",
            "Nissan",
            "BMW",
            "Mazda",
            "Mercedes",
            "Volkswagen",
            "Audi",
            "Kia",
            "Hyundai",
            "Ferrari",
            "Buggati",
            "Chevrolet"});
            this.ShowMakeList.Location = new System.Drawing.Point(235, 93);
            this.ShowMakeList.Name = "ShowMakeList";
            this.ShowMakeList.Size = new System.Drawing.Size(133, 24);
            this.ShowMakeList.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(402, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 16;
            this.button1.Text = "Search By Make";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(402, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 27);
            this.button2.TabIndex = 17;
            this.button2.Text = "Search By Plate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(402, 275);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 27);
            this.button3.TabIndex = 18;
            this.button3.Text = "Search By Year";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(402, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 27);
            this.button4.TabIndex = 19;
            this.button4.Text = "Search By Ratings";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(660, 490);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ShowMakeList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ShowRatingList);
            this.Controls.Add(this.ShowYearList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShowModelList);
            this.Controls.Add(this.label1);
            this.Name = "Search";
            this.Text = "Search Vehicle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ShowModelList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ShowYearList;
        private System.Windows.Forms.ComboBox ShowRatingList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ShowMakeList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}