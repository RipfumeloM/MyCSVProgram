using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class PersonSortOnFreqAndName:IComparer<NameAndFrequency>
    { 

        public int Compare(NameAndFrequency x, NameAndFrequency y)
        {   
            if(x == null || y == null) throw new ArgumentNullException();
            if (x.Frequency < y.Frequency)
                return 1;
            else if (x.Frequency == y.Frequency)
            return string.Compare(x.Name, y.Name, StringComparison.InvariantCultureIgnoreCase);
            else
            {
                return -1;
            }
        }

    }
}
