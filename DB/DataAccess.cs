using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DB
{
    public class DataAccess
    {
        public DataAccess()
        {
            connection = new SqlConnection("server=DESKTOP-J1JBL3C\\SQLEXPRESS; database=MedicalSystem_DB; integrated security = true");
            command = new SqlCommand();
        }
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;
        public SqlDataReader PropReader
        {
            get { return reader; }
        }

        public void Query(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }
        public void SP(string Sp)
        {
            command.CommandType = System.Data.CommandType.StoredProcedure;
            command.CommandText = Sp;
        }
        public void Read()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void Execute()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        public void Parameters(string parameter, object value)
        {
            command.Parameters.AddWithValue(parameter, value);
        }
        public void Close()
        {
            if (reader != null)
                reader.Close();
            connection.Close();
        }
    }
}
