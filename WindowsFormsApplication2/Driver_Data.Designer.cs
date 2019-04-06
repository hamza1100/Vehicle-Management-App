namespace WindowsFormsApplication2
{
    partial class Driver_Data
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.AddVehicleToDriver = new System.Windows.Forms.ComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddRatingsBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDriverBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EditVehicleForDriver = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.EditRatingsBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EditDriverBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteDriverBox = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 75);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(722, 510);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.AddVehicleToDriver);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.AddRatingsBox);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AddDriverBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(714, 481);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Add";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // AddVehicleToDriver
            // 
            this.AddVehicleToDriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddVehicleToDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.AddVehicleToDriver.FormattingEnabled = true;
            this.AddVehicleToDriver.Location = new System.Drawing.Point(305, 175);
            this.AddVehicleToDriver.Name = "AddVehicleToDriver";
            this.AddVehicleToDriver.Size = new System.Drawing.Size(144, 24);
            this.AddVehicleToDriver.TabIndex = 9;
            this.AddVehicleToDriver.DataSourceChanged += new System.EventHandler(this.AddVehicleToDriver_SelectedIndexChanged);
            this.AddVehicleToDriver.Click += new System.EventHandler(this.AddVehicleToDriver_SelectedIndexChanged);
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.Location = new System.Drawing.Point(348, 387);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 49);
            this.button4.TabIndex = 8;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(163, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Asign Vehicle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddRatingsBox
            // 
            this.AddRatingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddRatingsBox.FormattingEnabled = true;
            this.AddRatingsBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.AddRatingsBox.Location = new System.Drawing.Point(305, 277);
            this.AddRatingsBox.Name = "AddRatingsBox";
            this.AddRatingsBox.Size = new System.Drawing.Size(144, 24);
            this.AddRatingsBox.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ratings";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(169, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select Number Plate";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(169, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Driver Name";
            // 
            // AddDriverBox
            // 
            this.AddDriverBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddDriverBox.Location = new System.Drawing.Point(305, 92);
            this.AddDriverBox.Name = "AddDriverBox";
            this.AddDriverBox.Size = new System.Drawing.Size(144, 22);
            this.AddDriverBox.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EditVehicleForDriver);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.EditRatingsBox);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.EditDriverBox);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(714, 481);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Edit";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EditVehicleForDriver
            // 
            this.EditVehicleForDriver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditVehicleForDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditVehicleForDriver.FormattingEnabled = true;
            this.EditVehicleForDriver.Location = new System.Drawing.Point(299, 179);
            this.EditVehicleForDriver.Name = "EditVehicleForDriver";
            this.EditVehicleForDriver.Size = new System.Drawing.Size(151, 24);
            this.EditVehicleForDriver.TabIndex = 12;
            this.EditVehicleForDriver.DataSourceChanged += new System.EventHandler(this.Form3_Load);
            this.EditVehicleForDriver.Click += new System.EventHandler(this.EditVehicleForDriver_SelectedIndexChanged);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.Location = new System.Drawing.Point(376, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 57);
            this.button5.TabIndex = 11;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // EditRatingsBox
            // 
            this.EditRatingsBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditRatingsBox.FormattingEnabled = true;
            this.EditRatingsBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.EditRatingsBox.Location = new System.Drawing.Point(299, 264);
            this.EditRatingsBox.Name = "EditRatingsBox";
            this.EditRatingsBox.Size = new System.Drawing.Size(151, 24);
            this.EditRatingsBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 271);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Ratings";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Select Number Plate";
            // 
            // EditDriverBox
            // 
            this.EditDriverBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditDriverBox.Location = new System.Drawing.Point(299, 101);
            this.EditDriverBox.Name = "EditDriverBox";
            this.EditDriverBox.Size = new System.Drawing.Size(151, 22);
            this.EditDriverBox.TabIndex = 3;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(181, 357);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 57);
            this.button2.TabIndex = 2;
            this.button2.Text = "Assign Vehicle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Driver Name";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteDriverBox);
            this.tabPage3.Controls.Add(this.button6);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(714, 481);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteDriverBox
            // 
            this.DeleteDriverBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteDriverBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeleteDriverBox.FormattingEnabled = true;
            this.DeleteDriverBox.Location = new System.Drawing.Point(305, 177);
            this.DeleteDriverBox.Name = "DeleteDriverBox";
            this.DeleteDriverBox.Size = new System.Drawing.Size(178, 24);
            this.DeleteDriverBox.TabIndex = 4;
            this.DeleteDriverBox.Click += new System.EventHandler(this.DeleteDriverBox_Click);
            // 
            // button6
            // 
            this.button6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button6.Location = new System.Drawing.Point(390, 351);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 57);
            this.button6.TabIndex = 3;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(167, 351);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Driver";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select Driver";
            // 
            // Driver_Data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(746, 597);
            this.Controls.Add(this.tabControl1);
            this.Name = "Driver_Data";
            this.Text = "Driver Info";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AddDriverBox;
        private System.Windows.Forms.TextBox EditDriverBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox AddRatingsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox EditRatingsBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox AddVehicleToDriver;
        private System.Windows.Forms.ComboBox EditVehicleForDriver;
        private System.Windows.Forms.ComboBox DeleteDriverBox;
    }
}