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


    }
}
