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

        public List<Medical> ListSP()
        {
            List<Medical>List = new List<Medical>();
            try
            {
                data.SP("MedicalList");
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
                    aux.IdPatientsList = (List<int>)data.PropReader["PatientList"];
                    List.Add(aux);
                }
                return List;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
