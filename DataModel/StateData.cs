using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class StateData
    {
        public StateData() { data = new DataAccess(); }
        private DataAccess data;

        public List<State> QueryList()
        {
            List<State> list = new List<State>();
            try
            {
                data.Query("Select Id, Name from StateTypes");
                data.Read();
                while (data.PropReader.Read())
                {
                    State aux = new State();
                    aux.Id = (int)data.PropReader["Id"];
                    aux.Name = (string)data.PropReader["Name"];
                    list.Add(aux);
                }
                return list;
            }
            catch (Exception ex) { throw ex; }
            finally { data.Close(); }
        }
    }
}
