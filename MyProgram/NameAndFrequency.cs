using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class NameAndFrequency:IElement
    {
        public NameAndFrequency(string name)
        {
            Name = name;
            Frequency = 1;
        } 
        public string Name  { get; set; }
        public int Frequency  { get; set; }
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
