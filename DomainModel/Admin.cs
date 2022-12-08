using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Admin
    {
        public int Id { get; set; }
        public string Email { get; set; }
        
        private string Password { get; set; }
        public string PropPassword
        {
            get { return Password; }
            set { Password = value; }
        }
    }
}
