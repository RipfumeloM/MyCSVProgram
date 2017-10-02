using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public interface IPersonParser
    {

        List<Person> Parse(string fileName);


    }
}
