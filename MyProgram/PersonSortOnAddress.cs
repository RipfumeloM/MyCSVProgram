using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public  class PersonSortOnAddress:IComparer<Person>
    {
        

        public int Compare(Person x, Person y)
        {   
            if(y ==null || x == null) throw new ArgumentNullException();
            string firstPersonAddress = x.Address.Substring(x.Address.IndexOf(" "));
            string secondPersonAddress = y.Address.Substring(y.Address.IndexOf(" "));

            return string.Compare(firstPersonAddress, secondPersonAddress, StringComparison.InvariantCulture);
        }
    }
}
