using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class PersonNameAndFrequencyWriter : IVisitor
    {
        private readonly StreamWriter StreamWriter;

        public PersonNameAndFrequencyWriter(StreamWriter sw)
        {
            StreamWriter = sw;
        }
        public void Visit(IElement element)
        {
            var cur = element as NameAndFrequency;
            StreamWriter.WriteLine($"{cur.Name} {cur.Frequency}");
        }
    }
}
