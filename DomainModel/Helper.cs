using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModel
{
    public class Helper
    {
        public List<Medical> FastFilter(string Criterion, List<Medical> list)
        {
            List<Medical> Result = list.FindAll(x => x.FullName.ToUpper().Contains(Criterion.ToUpper()));
            return Result;
        }
        public List<Patient> FastFilter(string Criterion, List<Patient> list)
        {
            List<Patient> Result = list.FindAll(x => x.FullName.ToUpper().Contains(Criterion.ToUpper()));
            return Result;
        }

        public Medical ValidateUser(string User, string pass, List<Medical>List)
        {
            Medical user = List.Find
            (x => x.Email == User || x.UserName == User && x.PropPassword == pass);
            return user;
        }
        public Medical SearchUser(int Id, List<Medical> List)
        {
            Medical user = List.Find(x => x.Id == Id);
            return user;
        }
    }
}
