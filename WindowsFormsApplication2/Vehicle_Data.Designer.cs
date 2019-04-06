namespace WindowsFormsApplication2
{
    partial class Vehicle_Data
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
            this.Add = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.AccessoryBox = new System.Windows.Forms.CheckedListBox();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.MakeBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.plateBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EditPlateBox = new System.Windows.Forms.ComboBox();
            this.EditAccessoryBox = new System.Windows.Forms.CheckedListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.EditModelBox = new System.Windows.Forms.TextBox();
            this.EditTypeBox = new System.Windows.Forms.ComboBox();
            this.EditYearBox = new System.Windows.Forms.ComboBox();
            this.EditMakeBox = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeletePlateBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.Add.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.Controls.Add(this.tabPage1);
            this.Add.Controls.Add(this.tabPage2);
            this.Add.Controls.Add(this.tabPage3);
            this.Add.Location = new System.Drawing.Point(12, 58);
            this.Add.Name = "Add";
            this.Add.SelectedIndex = 0;
            this.Add.Size = new System.Drawing.Size(644, 546);
            this.Add.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.AccessoryBox);
            this.tabPage1.Controls.Add(this.ModelBox);
            this.tabPage1.Controls.Add(this.TypeBox);
            this.tabPage1.Controls.Add(this.YearBox);
            this.tabPage1.Controls.Add(this.MakeBox);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.plateBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(636, 517);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(424, 450);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 46);
            this.button4.TabIndex = 19;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AccessoryBox
            // 
            this.AccessoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccessoryBox.FormattingEnabled = true;
            this.AccessoryBox.Items.AddRange(new object[] {
            "Rear airconditioner",
            "Cup-holders",
            "Sun/Moon Roof",
            "Fog lights",
            "TV",
            "Navigation system",
            "Rear-view cameras",
            "proximity sensors",
            "Leather seats",
            "Cold storage"});
            this.AccessoryBox.Location = new System.Drawing.Point(292, 321);
            this.AccessoryBox.Name = "AccessoryBox";
            this.AccessoryBox.Size = new System.Drawing.Size(236, 106);
            this.AccessoryBox.TabIndex = 18;
            // 
            // ModelBox
            // 
            this.ModelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ModelBox.Location = new System.Drawing.Point(292, 153);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(236, 22);
            this.ModelBox.TabIndex = 17;
            // 
            // TypeBox
            // 
            this.TypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "Luxury/VIP",
            "Large Capacity"});
            this.TypeBox.Location = new System.Drawing.Point(292, 269);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(236, 24);
            this.TypeBox.TabIndex = 16;
            // 
            // YearBox
            // 
            this.YearBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Items.AddRange(new object[] {
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
            this.YearBox.Location = new System.Drawing.Point(292, 211);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(236, 24);
            this.YearBox.TabIndex = 15;
            // 
            // MakeBox
            // 
            this.MakeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MakeBox.FormattingEnabled = true;
            this.MakeBox.Items.AddRange(new object[] {
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
            this.MakeBox.Location = new System.Drawing.Point(292, 94);
            this.MakeBox.Name = "MakeBox";
            this.MakeBox.Size = new System.Drawing.Size(236, 24);
            this.MakeBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(281, 450);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Accessories";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(144, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(144, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Year";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Model";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Make";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number Plate";
            // 
            // plateBox
            // 
            this.plateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.plateBox.Location = new System.Drawing.Point(292, 40);
            this.plateBox.Name = "plateBox";
            this.plateBox.Size = new System.Drawing.Size(236, 22);
            this.plateBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EditPlateBox);
            this.tabPage2.Controls.Add(this.EditAccessoryBox);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.EditModelBox);
            this.tabPage2.Controls.Add(this.EditTypeBox);
            this.tabPage2.Controls.Add(this.EditYearBox);
            this.tabPage2.Controls.Add(this.EditMakeBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(636, 517);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EditPlateBox
            // 
            this.EditPlateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditPlateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditPlateBox.FormattingEnabled = true;
            this.EditPlateBox.Location = new System.Drawing.Point(311, 40);
            this.EditPlateBox.Name = "EditPlateBox";
            this.EditPlateBox.Size = new System.Drawing.Size(230, 24);
            this.EditPlateBox.TabIndex = 34;
            this.EditPlateBox.Click += new System.EventHandler(this.EditPlateBox_SelectedIndexChanged);
            // 
            // EditAccessoryBox
            // 
            this.EditAccessoryBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditAccessoryBox.FormattingEnabled = true;
            this.EditAccessoryBox.Items.AddRange(new object[] {
            "Rear airconditioner",
            "Cup-holders",
            "Sun/Moon Roof",
            "Fog lights",
            "TV",
            "Navigation system",
            "Rear-view cameras",
            "proximity sensors",
            "Leather seats",
            "Cold storage"});
            this.EditAccessoryBox.Location = new System.Drawing.Point(311, 321);
            this.EditAccessoryBox.Name = "EditAccessoryBox";
            this.EditAccessoryBox.Size = new System.Drawing.Size(230, 106);
            this.EditAccessoryBox.TabIndex = 31;
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(392, 457);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 42);
            this.button5.TabIndex = 30;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(206, 457);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 42);
            this.button2.TabIndex = 24;
            this.button2.Text = "Edit Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "Accessories";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 17);
            this.label8.TabIndex = 21;
            this.label8.Text = "Type";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(142, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Year";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(142, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Model";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(142, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Make";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(142, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 17);
            this.label12.TabIndex = 17;
            this.label12.Text = "Number Plate";
            // 
            // EditModelBox
            // 
            this.EditModelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditModelBox.Location = new System.Drawing.Point(311, 149);
            this.EditModelBox.Name = "EditModelBox";
            this.EditModelBox.Size = new System.Drawing.Size(230, 22);
            this.EditModelBox.TabIndex = 33;
            // 
            // EditTypeBox
            // 
            this.EditTypeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditTypeBox.FormattingEnabled = true;
            this.EditTypeBox.Items.AddRange(new object[] {
            "Economy",
            "Business",
            "Luxury/VIP",
            "Large Capacity"});
            this.EditTypeBox.Location = new System.Drawing.Point(311, 259);
            this.EditTypeBox.Name = "EditTypeBox";
            this.EditTypeBox.Size = new System.Drawing.Size(230, 24);
            this.EditTypeBox.TabIndex = 27;
            // 
            // EditYearBox
            // 
            this.EditYearBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditYearBox.FormattingEnabled = true;
            this.EditYearBox.Items.AddRange(new object[] {
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
            this.EditYearBox.Location = new System.Drawing.Point(311, 203);
            this.EditYearBox.Name = "EditYearBox";
            this.EditYearBox.Size = new System.Drawing.Size(230, 24);
            this.EditYearBox.TabIndex = 26;
            // 
            // EditMakeBox
            // 
            this.EditMakeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditMakeBox.FormattingEnabled = true;
            this.EditMakeBox.Items.AddRange(new object[] {
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
            this.EditMakeBox.Location = new System.Drawing.Point(311, 93);
            this.EditMakeBox.Name = "EditMakeBox";
            this.EditMakeBox.Size = new System.Drawing.Size(230, 24);
            this.EditMakeBox.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.DeletePlateBox);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(636, 517);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeletePlateBox
            // 
            this.DeletePlateBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeletePlateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeletePlateBox.FormattingEnabled = true;
            this.DeletePlateBox.Location = new System.Drawing.Point(310, 164);
            this.DeletePlateBox.Name = "DeletePlateBox";
            this.DeletePlateBox.Size = new System.Drawing.Size(157, 24);
            this.DeletePlateBox.TabIndex = 21;
            this.DeletePlateBox.Click += new System.EventHandler(this.DeletePlateBox_SelectedIndexChanged);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(357, 270);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 42);
            this.button6.TabIndex = 20;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(169, 270);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 43);
            this.button3.TabIndex = 18;
            this.button3.Text = "Delete Vehicle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(166, 171);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(94, 17);
            this.label18.TabIndex = 17;
            this.label18.Text = "Number Plate";
            // 
            // Vehicle_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 609);
            this.Controls.Add(this.Add);
            this.Name = "Vehicle_Data";
            this.Text = "Vehicle";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Add.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Add;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox plateBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox EditTypeBox;
        private System.Windows.Forms.ComboBox EditYearBox;
        private System.Windows.Forms.ComboBox EditMakeBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.ComboBox MakeBox;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.CheckedListBox AccessoryBox;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckedListBox EditAccessoryBox;
        private System.Windows.Forms.TextBox EditModelBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox EditPlateBox;
        private System.Windows.Forms.ComboBox DeletePlateBox;

    }
}