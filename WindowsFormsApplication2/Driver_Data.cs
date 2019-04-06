using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Driver_Data : Form
    {
        private DataRetrieval data_ret;
        public Driver_Data()
        {
            InitializeComponent();
            data_ret = new DataRetrieval();
        }

        private void button1_Click(object sender, EventArgs e)  //add driver button
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.AddDriver(AddDriverBox.Text, AddVehicleToDriver.Text, AddRatingsBox.Text.ToString());
            }

            catch(Exception)
            {
                MessageBox.Show("Please Fill All Fields", "Empty Box Error");
            }
            
        }

        private void button4_Click(object sender, EventArgs e)  //exit button
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)      //Edit Driver Button
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.EditDriver(EditDriverBox.Text, EditVehicleForDriver.Text, EditRatingsBox.Text.ToString());
            }
            catch(Exception)
            {
                MessageBox.Show("Please Fill All Fields", "Empty Box Error");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)      //Exit Button
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)      //Delete Driver Button
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.DeleteDriver(DeleteDriverBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please Fill All Fields", "Empty Box Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)      //Exit Button
        {
            Close();
        }

        private void EditVehicleForDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            var values = data_ret.Get_Car_Model();
            EditVehicleForDriver.DataSource = values;
        }

        private void AddVehicleToDriver_SelectedIndexChanged(object sender, EventArgs e)
        {
            var values = data_ret.Get_Car_Model();
            AddVehicleToDriver.DataSource = values;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            EditVehicleForDriver.DataSource = null;
            EditVehicleForDriver.DataBindings.Clear();
        }

        private void DeleteDriverBox_Click(object sender, EventArgs e)
        {
            var values = data_ret.Get_Driver_Name();
            DeleteDriverBox.DataSource = values;
        }

    }
}