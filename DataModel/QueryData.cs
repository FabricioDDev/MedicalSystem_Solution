using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;
using DB;

namespace DataModel
{
    public class QueryData
    {
        public QueryData() { data = new DataAccess(); }
        private DataAccess data;

        public List<Query> QueryList()
        {
            List<Query> list = new List<Query>();
            try
            {
                data.Query("Select Id, Name from QueryTypes");
                data.Read();
                while (data.PropReader.Read())
                {
                    Query aux = new Query();
                    aux.IdQuery = (int)data.PropReader["Id"];
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
