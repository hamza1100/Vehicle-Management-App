using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication2
{
    class Vehicle
    {

        public Vehicle()
        {

        }

        //---------------------Vehicle Section Starts from here------------//
        public void AddVehicle(string plate_text, string make, string model, string year, string type, string accessory)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            xdoc.Element("root").Add(new XElement("Vehicle", new XElement("Number_Plate", plate_text),
                new XElement("Make", make), new XElement("Model", model), new XElement("Year", year),
                new XElement("Type", type), new XElement("Accessory", accessory),
                new XElement("Driver",""),
                new XElement("Ratings", "")
                ));

            xdoc.Save("vehicle.xml");

            MessageBox.Show("Vehicle is added in you XML File", "Task Successful");

        }


        public void EditVehicle(string plate_text, string make, string model, string year, string type, string accessory)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var items = from item in xdoc.Elements("root").Elements("Vehicle")
                        where item != null && (item.Element("Number_Plate").Value == plate_text)
                        select item;

            foreach(var item in items)
            {
                item.Element("Make").Value = make;
                item.Element("Model").Value = model;
                item.Element("Year").Value = year;
                item.Element("Type").Value = type;
                item.Element("Accessory").Value = accessory;
            }

            xdoc.Save("vehicle.xml");
            MessageBox.Show("Vehicle Has Been Edited Successfully", "Task Successfull");


        }


        public void DeleteVehicle(string plate_text)
        {
                XDocument xdoc = XDocument.Load("vehicle.xml");
                var Delete_Element = from dlt in xdoc.Elements("root").Elements("Vehicle")
                                     where dlt != null && dlt.Element("Number_Plate").Value.Equals(plate_text)
                                     select dlt;

                foreach (var dlt in Delete_Element)
                {
                    dlt.Remove();
                }

                xdoc.Save("vehicle.xml");
                MessageBox.Show("Vehicle Has Been Deleted Successfully", "Task Successfull");
           

        }


        //--------------------------Vehicle section Ends here---------//


        public void AddDriver(string Driver_name, string num_plate, string ratings)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var items = from item in xdoc.Elements("root").Elements("Vehicle")
                        where item != null && ( item.Element("Number_Plate").Value == num_plate
                       )
                        select item;

            foreach (var item in items)
            {
                item.Element("Driver").Value = Driver_name;
                item.Element("Ratings").Value = ratings;
            }
            xdoc.Save("vehicle.xml");
            MessageBox.Show("Driver With Ratings Has Been Assigned To A Vehicle Successfully", "Task Successfull");

        }

        public void EditDriver(string Driver_name, string num_plate, string ratings)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var items = from item in xdoc.Elements("root").Elements("Vehicle")
                        where item != null && (item.Element("Number_Plate").Value == num_plate
                         )
                        select item;

            foreach (var item in items)
            {
                item.Element("Driver").Value = Driver_name;
                item.Element("Ratings").Value = ratings;
            }
            xdoc.Save("vehicle.xml");
            MessageBox.Show("Driver With Ratings Has Been Edited Successfully", "Task Successfull");
        }


        public void DeleteDriver(string Driver_name)
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            var items = from item in xdoc.Elements("root").Elements("Vehicle")
                        where item != null && (item.Element("Driver").Value == Driver_name
                                                )
                        select item;

            foreach (var item in items)
            {
                item.Element("Driver").Value = "";
                item.Element("Ratings").Value = "";
            }
            xdoc.Save("vehicle.xml");
            MessageBox.Show("Driver With Ratings Has Been Deleted Successfully", "Task Successfull");
        }


       


        internal List<string> Retrieve_Number_Plate()
        {

            XDocument xdoc = XDocument.Load("vehicle.xml");

            List<string> number_list = new List<string>();
    
            var get_number_plate = from key in xdoc.Descendants("Number_Plate")
                     select key.Value;

            foreach (var num_plate in get_number_plate)
            {
                number_list.Add(num_plate);
            }
            return number_list;
           
        }

        internal List<string> Retrieve_Car_Model()
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            List<string> model_list = new List<string>();

            var add_driver_to_vehicle = from key in xdoc.Descendants("Number_Plate")
                                    select key.Value;

            

            foreach (var car_model in add_driver_to_vehicle)
            {
                model_list.Add(car_model);
            }
            return model_list;
        }

        internal List<string> Retreive_Driver_Name()
        {
            XDocument xdoc = XDocument.Load("vehicle.xml");

            List<string> driver_list = new List<string>();

            var add_driver_name_to_list = from key in xdoc.Descendants("Driver")
                                          select key.Value;

            foreach (var car_driver in add_driver_name_to_list)
            {
                driver_list.Add(car_driver);
            }
            return driver_list;
        }
    }
}