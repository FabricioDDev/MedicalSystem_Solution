using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class AdminData
    {
        public AdminData() { data = new DataAccess(); }
        private DataAccess data;
        
        public List<Admin> ListSP()
        {
            List<Admin> list = new List<Admin>();
            try
            {
                data.SP("AdminList");
                data.Read();
                while (data.PropReader.Read())
                {
                    Admin aux = new Admin();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.Email = (string)data.PropReader["Email"];
                    aux.PropPassword = (string)data.PropReader["Pass"];
                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
