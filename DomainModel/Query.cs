using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Query
    {
        public int IdQuery { get; set; } 
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
