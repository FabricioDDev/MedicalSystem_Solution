using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Medical
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }   
        private string Password { get; set; }
        public string PropPassword
        {
            get { return Password; }
            set { Password = value; }
        }
        public string Dni { get; set; }
        public List<Patient> PatientsList { get;set; }
    }
}
