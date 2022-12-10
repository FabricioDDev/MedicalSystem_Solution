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

        public List<Appointment> AppointmentListSP()
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                data.SP("AppointmentList");
                data.Read();
                while (data.PropReader.Read())
                {
                    Appointment aux = new Appointment();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.Time = (string)data.PropReader["Time"];
                    aux.date = (DateTime)data.PropReader["AppointmentDate"];

                    aux.medical = new Medical();
                    aux.medical.Id = (int)data.PropReader["Mid"];
                    aux.medical.FullName = (string)data.PropReader["Mname"];

                    aux.patient = new Patient();
                    aux.patient.Id = (int)data.PropReader["Pid"];
                    aux.patient.FullName = (string)data.PropReader["Pname"];

                    aux.state = new State();
                    aux.state.Id = (int)data.PropReader["Sid"];
                    aux.state.Name = (string)data.PropReader["Name"];

                    aux.query = new Query();
                    aux.query.Id = (int)data.PropReader["id"];
                    aux.query.Name = (string)data.PropReader["name"];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
