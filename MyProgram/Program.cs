using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyProgram
{
    public class Program
    {

        private List<Person> people;

        public Program()
        {
            IPersonParser csv  = new CSVPersonParser(); 

            people = csv.Parse("data.csv");

            var names = ExtractNames(people);
            names.Sort(new PersonSortOnFreqAndName());
            WriteOutNames(names.ToList<IElement>(), "NamesAndFreq.txt");

            people.Sort(new PersonSortOnAddress());
            WriteOutAddresses(people.ToList<IElement>(), "Addresses.txt");


        }

        private List<NameAndFrequency> ExtractNames(List<Person> personList)
        {
            var names = new List<NameAndFrequency>();
            foreach (var person in personList)
            {
                var cur = names.Find(x => x.Name == person.FirstName);
                if(cur == null) names.Add(new NameAndFrequency(person.FirstName)); else cur.Frequency++;


                 cur = names.Find(x => x.Name == person.LastName);
                if (cur == null) names.Add(new NameAndFrequency(person.LastName)); else cur.Frequency++;
            }

            return names;
        }
        private void WriteOutNames(List<IElement> names, string fileName)
        {   
            StreamWriter sw = new StreamWriter(fileName);
            var writer = new PersonNameAndFrequencyWriter(sw);
            WriteOut(names, writer);
            sw.Close();

        }

        private void WriteOut(List<IElement> personList, IVisitor writer)
        {
            foreach (var person in personList)
            {
                person.Accept(writer);

            }
            
        }

        private void WriteOutAddresses(List<IElement> personList, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            var writer = new PersonAddressWriter(sw);
            WriteOut(personList, writer);
            sw.Close();
        }
        static void Main(string[] args)
        {

            new Program();


        }
    }
}


