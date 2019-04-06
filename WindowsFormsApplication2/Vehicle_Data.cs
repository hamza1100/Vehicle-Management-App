using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication2
{
    public partial class Vehicle_Data : Form
    {
        public static int count = 0;
        private DataRetrieval dr;
        
        public Vehicle_Data()
        {
            InitializeComponent();
            dr = new DataRetrieval();
        }

        private void button1_Click(object sender, EventArgs e)      //Add Vehicle
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.AddVehicle(plateBox.Text, MakeBox.Text, ModelBox.Text, YearBox.Text.ToString(), TypeBox.Text, AccessoryBox.SelectedItem.ToString());

            }
            /* string no_plate = plateBox.Text;
       * MessageBox.Show(no_plate);
       */

            catch(Exception )
            {
                MessageBox.Show("Please Fill All Fields","Empty Box Error");
            }
           

        }

        private void button4_Click(object sender, EventArgs e)      //Exit Button
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)      //Edit Vehicle
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.EditVehicle(EditPlateBox.Text, EditMakeBox.Text, EditModelBox.Text, EditYearBox.Text.ToString(), EditTypeBox.Text, EditAccessoryBox.SelectedItem.ToString());
            }

            catch(Exception )
            {
                MessageBox.Show("Please Fill All Fields", "Empty Box Error");
            }
            
        }

        private void button5_Click(object sender, EventArgs e)      //Exit Button
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)      //Delete Vehicle
        {
            try
            {
                Vehicle obj = new Vehicle();
                obj.DeleteVehicle(DeletePlateBox.Text);
            }
            catch(Exception )
            {
                MessageBox.Show("Please Fill All Fields", "Empty Box Error");
            }
            
        }
        

        private void button6_Click(object sender, EventArgs e)      //Exit Button
        {
            Close();
        }

        private void EditPlateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var categories = dr.Get_Number_Plate();
            EditPlateBox.DataSource = categories;
            
        }

        private void DeletePlateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            var categories = dr.Get_Number_Plate();
            DeletePlateBox.DataSource = categories;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DeletePlateBox.DataSource = null;
            DeletePlateBox.DataBindings.Clear();
        }
    }
}
