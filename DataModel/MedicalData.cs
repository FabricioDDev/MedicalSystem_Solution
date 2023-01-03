using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class MedicalData
    {
        public MedicalData() { data = new DataAccess(); }
        private DataAccess data;

        public List<Medical> List()
        {
            List<Medical>List = new List<Medical>();
            try
            {
                data.Query("select Id, FullName, UserName, Pass, Email, Dni from Medical");
                data.Read();
                while (data.PropReader.Read())
                {
                    Medical aux = new Medical();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.FullName = (string)data.PropReader["FullName"];
                    aux.UserName = (string)data.PropReader["UserName"];
                    aux.PropPassword = (string)data.PropReader["Pass"];
                    aux.Email = (string)data.PropReader["Email"];
                    aux.Dni = (string)data.PropReader["Dni"];
                    List.Add(aux);
                }
                return List;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public void MedicalInsertSP(Medical medical)
        {
            try
            {
                data.SP("MedicalInsertSP");
                data.Parameters("@FullName", medical.FullName);
                data.Parameters("@UserName", medical.UserName);
                data.Parameters("@Pass", medical.PropPassword);
                data.Parameters("@Email", medical.Email);
                data.Parameters("@Dni", medical.Dni);
                data.Execute();
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public void MedicalUpdateSP(Medical medical)
        {
            try
            {
                data.SP("MedicalUpdate");
                data.Parameters("@FullName", medical.FullName);
                data.Parameters("@UserName", medical.UserName);
                data.Parameters("@Pass", medical.PropPassword);
                data.Parameters("@Email", medical.Email);
                data.Parameters("@Dni", medical.Dni);
                data.Parameters("@Id", medical.Id);
                data.Execute();
            }
            catch(Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public void MedicalDeleteSP(int Id)
        {
            try
            {
                data.SP("MedicalDelete");
                data.Parameters("@Id", Id);
                data.Execute();
            }
            catch(Exception ex) { throw ex; }
            finally { data.Close(); }
        }
        public List<Patient> Read_Patients_(int IdM)
        {
            try
            {
                //Get Id
                string query = "select Patient_Id from Medical_Detail where Medical_Id = " + IdM;
                List<int> IdList = new List<int>();
                data.Query(query);
                data.Read();
                while (data.PropReader.Read())
                {
                    int id = (int)data.PropReader["Patient_Id"];
                    IdList.Add(id);
                }

                //Get Patients 
                PatientData patientData = new PatientData();
                List<Patient> patientList = new List<Patient>();

                foreach (int i in IdList)
                {
                    Patient aux = patientData.PatientList().Find(x => x.Id == i);
                    patientList.Add(aux);
                }
                return patientList;
            }
            catch(Exception ex) { throw ex; }
            finally { data.Close(); }
        }

        

        public void Insert_To_PatientList(int Patient_Id, int Medical_Id)
        {
            try
            {
                data.Query("insert into Medical_Detail values (@Medical, @Patient)");
                data.Parameters("@Medical", Medical_Id);
                data.Parameters("@Patient", Patient_Id);
                data.Execute();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { data.Close(); }
        }
        public void Delete_Patient_from_PatientList(int Medical_Id, int Patient_Id)
        {
            try
            {
                data.Query("delete Medical_Detail where Medical_Id = @Medical_Id and Patient_Id = @Patient_Id");
                data.Parameters("@Medical_Id", Medical_Id);
                data.Parameters("Patient_Id", Patient_Id);
                data.Execute();
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
