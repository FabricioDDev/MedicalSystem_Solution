using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DB;
using DomainModel;

namespace DataModel
{
    public class AppointmentData
    {
        public AppointmentData() { data = new DataAccess(); }
        private DataAccess data;


    }
}
