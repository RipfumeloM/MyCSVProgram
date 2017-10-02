using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class PersonAddressWriter:IVisitor
    {
        private readonly StreamWriter StreamWriter;

        public PersonAddressWriter(StreamWriter sw)
        {
            StreamWriter = sw;
        }
        public void Visit(IElement element)
        {
            var person = element as Person;
            StreamWriter.WriteLine(person.Address);
        }
    }
}
