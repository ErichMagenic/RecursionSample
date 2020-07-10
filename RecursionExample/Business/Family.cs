using RecursionExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExample.Business
{
    public class Family
    {
        public List<Person> Females { get; private set; }
        public List<Person> Males { get; private set; }
        private FamilyProcess familyProcess { get; set; }

        public Family()
        {
            Females = new List<Person>();
            Males = new List<Person>();
            familyProcess = new FamilyProcess();
        }

        public List<Person> PopulateFamily()
        {
            return new List<Person>()
            {
                new Female("Marianne", "Rivera-Dantes", new DateTime(1984, 08, 24),
                    new List<Person>()
                    {
                        new Female("Zia", "Dantes", new DateTime(2015, 11, 23), null),
                        new Male("Jose Sixto", "Dantes", new DateTime(2019, 04, 16), null)
                    }),
                new Male("DingDong", "Dantes", new DateTime(1980, 09, 29),
                    new List<Person>()
                    {
                        new Female("Zia", "Dantes", new DateTime(2015, 11, 23), null),
                        new Male("Jose Sixto", "Dantes", new DateTime(2019, 04, 16), null)
                    }),
                new Female("Chesca", "Garcia-Kramer", new DateTime(1980, 07, 24),
                    new List<Person>()
                    {
                        new Female("Clair Kendra", "Kramer", new DateTime(2009, 06, 25), null),
                        new Female("Scarlet Louvelle", "Kramer", new DateTime(2011, 10, 28), null),
                        new Male("Gavin Phoenix", "Kramer", new DateTime(2013, 01, 15), null)
                    }),
                new Male("Doug", "Kramer", new DateTime(1983, 07, 10),
                    new List<Person>()
                    {
                        new Female("Clair Kendra", "Kramer", new DateTime(2009, 06, 25), null),
                        new Female("Scarlet Louvelle", "Kramer", new DateTime(2011, 10, 28), null),
                        new Male("Gavin Phoenix", "Kramer", new DateTime(2013, 01, 15), null)
                    }),
                new Female("Sarah", "Lahbati-Gutierrez", new DateTime(1993, 10, 09),
                    new List<Person>()
                    {
                        new Male("Zion", "Gutierrez", new DateTime(2015, 11, 23), null),
                        new Female("Kai", "Gutierrez", new DateTime(2019, 04, 16), null)
                    }),
                new Male("Richard", "Gutierrez", new DateTime(1984, 01, 21),
                    new List<Person>()
                    {
                        new Male("Zion", "Gutierrez", new DateTime(2015, 11, 23), null),
                        new Female("Kai", "Gutierrez", new DateTime(2019, 04, 16), null)
                    }),
                new Female("Heart", "Evanghelista", new DateTime(1985, 02, 14), null),
                new Male("Chiz", "Escudero", new DateTime(1969, 10, 10), null),
            };
        }
        public void ProcessFamily(List<Person> families)
        {
            Console.WriteLine($"Listing all Female Persons");
            Females = familyProcess.ProcessPerson(families, "Female");
            Females.ForEach(person => Console.WriteLine($"{person.FullName} Aged {person.Age} is a {person.BirthGender}"));

            familyProcess.Clear();
            Console.WriteLine(Environment.NewLine);

            Console.WriteLine($"Listing all Male Persons");
            Males = familyProcess.ProcessPerson(families, "Male");
            Males.ForEach(person => Console.WriteLine($"{person.FullName} Aged {person.Age} is a {person.BirthGender}"));

            //
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine($"End of Process");
            Console.ReadLine();
        }
    }
}
