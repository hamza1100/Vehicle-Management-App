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
using System.Xml.Linq;
using System.Xml.Serialization;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Display_Box : Form
    {
        private DataRetrieval data_ret;
        public Display_Box()
        {
            InitializeComponent();
            data_ret = new DataRetrieval();
        }

        public void ShowByMake(string makelist)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var query = from key in xdoc.Descendants("Vehicle")
                        where key != null && ( key.Element("Make").Value == makelist)
                        select new
                        {
                            Number_Plate = key.Element("Number_Plate").Value,
                            Make = key.Element("Make").Value,
                            Model = key.Element("Model").Value,
                            Year = key.Element("Year").Value,
                            Type = key.Element("Type").Value,
                            Accessory = key.Element("Accessory").Value,
                            Driver = key.Element("Driver").Value,
                            Ratings = key.Element("Ratings").Value
                        };

            dataGridView1.DataSource = query.ToList();

        }

        public void ShowByModel(string num_plate)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var query = from key in xdoc.Descendants("Vehicle")
                        where key != null && (key.Element("Number_Plate").Value == num_plate)
                        select new
                        {
                            Number_Plate = key.Element("Number_Plate").Value,
                            Make = key.Element("Make").Value,
                            Model = key.Element("Model").Value,
                            Year = key.Element("Year").Value,
                            Type = key.Element("Type").Value,
                            Accessory = key.Element("Accessory").Value,
                            Driver = key.Element("Driver").Value,
                            Ratings = key.Element("Ratings").Value
                        };

            dataGridView1.DataSource = query.ToList();
        }

        public void ShowByYear(string yearlist)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var query = from key in xdoc.Descendants("Vehicle")
                        where key != null && (key.Element("Year").Value == yearlist)
                        select new
                        {
                            Number_Plate = key.Element("Number_Plate").Value,
                            Make = key.Element("Make").Value,
                            Model = key.Element("Model").Value,
                            Year = key.Element("Year").Value,
                            Type = key.Element("Type").Value,
                            Accessory = key.Element("Accessory").Value,
                            Driver = key.Element("Driver").Value,
                            Ratings = key.Element("Ratings").Value
                        };

            dataGridView1.DataSource = query.ToList();

        }


        public void ShowByRating(string ratings)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var query = from key in xdoc.Descendants("Vehicle")
                        where key != null && (key.Element("Ratings").Value == ratings)
                        select new
                        {
                            Number_Plate = key.Element("Number_Plate").Value,
                            Make = key.Element("Make").Value,
                            Model = key.Element("Model").Value,
                            Year = key.Element("Year").Value,
                            Type = key.Element("Type").Value,
                            Accessory = key.Element("Accessory").Value,
                            Driver = key.Element("Driver").Value,
                            Ratings = key.Element("Ratings").Value
                        };

            dataGridView1.DataSource = query.ToList();

        }


 
        
    }
}
