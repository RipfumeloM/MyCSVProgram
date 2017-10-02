using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class Person:IElement
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public string GetFullName => $"{FirstName} {LastName}";
        public Person(string firstName, string lastName, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
