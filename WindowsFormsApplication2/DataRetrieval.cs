using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication2
{
    class DataRetrieval
    {
        private Vehicle vehicle_object;
        private Vehicle obj;

        public DataRetrieval()
        {
            vehicle_object = new Vehicle();
            obj = new Vehicle();
        }

        internal List<string> Get_Number_Plate()
        {
            return vehicle_object.Retrieve_Number_Plate();
        }

        internal List<string> Get_Car_Model()
        {
            return obj.Retrieve_Car_Model();
        }

        internal List<string> Get_Driver_Name()
        {
            return vehicle_object.Retreive_Driver_Name();
        }
    }
}
