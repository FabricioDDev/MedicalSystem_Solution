using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainModel;

namespace DomainModel
{
    public class Appointment
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public Medical medical { get; set; }
        public Patient patient { get; set; }
        public State state { get; set; }
        public Query query { get; set; }
    }
}
