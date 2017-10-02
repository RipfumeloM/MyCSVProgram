using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProgram
{
    public class CSVPersonParser: IPersonParser

    {

        public List<Person> Parse(string fileName)
        {
            StreamReader personReader = new StreamReader(fileName);
            var people = new List<Person>();
            personReader.ReadLine(); //reading meta data;

            while (!personReader.EndOfStream)
            {
                string personData = personReader.ReadLine();

                var person = CreatePerson(personData);
                people.Add(person); 
            }

            personReader.Close();
            return people;

        }

        private Person CreatePerson(string data)
        {   
            if(string.IsNullOrWhiteSpace(data)) throw new ArgumentNullException("person data cannot be empty.");
            string[] segs = data.Split(',');

            var person = new Person(segs[0],segs[1],segs[2],segs[3]);

            return person;
        }
    }
}
