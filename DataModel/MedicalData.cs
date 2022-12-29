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
    }
}
