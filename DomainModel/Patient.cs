using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Patient
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Dni { get; set; }
        public string years { get; set; }
        public string MedicalPlan { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}
