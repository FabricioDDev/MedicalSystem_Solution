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
                    aux.date = (DateTime)data.PropReader["AppointmentDate"];

                    aux.medical = new Medical();
                    aux.medical.Id = (int)data.PropReader["Mid"];
                    aux.medical.FullName = (string)data.PropReader["Mname"];

                    aux.patient = new Patient();
                    aux.patient.Id = (int)data.PropReader["Pid"];
                    aux.patient.FullName = (string)data.PropReader["Pname"];

                    aux.state = new State();
                    aux.state.Id = (int)data.PropReader["Sid"];
                    aux.state.Name = (string)data.PropReader["Sname"];

                    aux.query = new Query();
                    aux.query.Id = (int)data.PropReader["id"];
                    aux.query.Name = (string)data.PropReader["Qname"];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public List<Appointment> AppointmentListFilter(string camp, string criterion)
        {
            List<Appointment> list = new List<Appointment>();
            try
            {
                string query = "select A.Id as Id, AppointmentDate,M.Id as Mid, M.FullName as Mname, P.Id as Pid, P.FullName as Pname, S.Id as Sid, S.Name as Sname, Q.Id as Qid, Q.Name as Qname from Appointment A, Medical M, Patient P, StateTypes S, QueryTypes Q where A.IdMedical = M.Id and A.IdPatient = P.Id and A.IdState = S.Id AND A.IdQuery = Q.Id";
                switch (camp)
                {
                    case "State":
                        query = query + " and IdState = " + criterion; break;
                    case "Query Type":
                        query = query + " and IdQuery = " + criterion; break;
                    default:
                        break;
                }
                data.Query(query);
                data.Read();
                while (data.PropReader.Read())
                {
                    Appointment aux = new Appointment();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.date = (DateTime)data.PropReader["AppointmentDate"];

                    aux.medical = new Medical();
                    aux.medical.Id = (int)data.PropReader["Mid"];
                    aux.medical.FullName = (string)data.PropReader["Mname"];

                    aux.patient = new Patient();
                    aux.patient.Id = (int)data.PropReader["Pid"];
                    aux.patient.FullName = (string)data.PropReader["Pname"];

                    aux.state = new State();
                    aux.state.Id = (int)data.PropReader["Sid"];
                    aux.state.Name = (string)data.PropReader["Sname"];

                    aux.query = new Query();
                    aux.query.Id = (int)data.PropReader["id"];
                    aux.query.Name = (string)data.PropReader["Qname"];

                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public void AppointmentInsertSP(Appointment appointment)
        {
            try
            {
                data.SP("AppointmentInsert");
                data.Parameters("@IdMedical", appointment.medical.Id);
                data.Parameters("@IdPatient", appointment.patient.Id);
                data.Parameters("@IdState", appointment.state.Id);
                data.Parameters("@IdQuery", appointment.query.Id);
                data.Parameters("@AppointmentDate", appointment.date);
                data.Execute();
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public void AppointmentUpdateSP(Appointment appointment)
        {
            try
            {
                data.SP("AppointmentUpdate");
                data.Parameters("@IdMedical", appointment.medical.Id);
                data.Parameters("@IdPatient", appointment.patient.Id);
                data.Parameters("@IdState", appointment.state.Id);
                data.Parameters("@IdQuery", appointment.query.Id);
                data.Parameters("@AppointmentDate", appointment.date);
                data.Parameters("@Id", appointment.Id);
                data.Execute();
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    
        public void AppointmentDeleteSP(int Id)
        {
            try
            {
                data.SP("AppointmentDelete");
                data.Parameters("@Id", Id);
                data.Execute();
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
