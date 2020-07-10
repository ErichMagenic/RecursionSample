using RecursionExample.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExample.Business
{
    public class FamilyProcess
    {
        private List<Person> returnVal { get; set; }

        public FamilyProcess()
        {
            this.Clear();
        }

        public void Clear()
        {
            this.returnVal = new List<Person>();
        }

        public List<Person> ProcessPerson(List<Person> families, string Gender)
        {

            for (int ctr = 0; ctr < families.Count; ctr++)
            {
                var person = families[ctr];
                if (person.BirthGender.Equals(Gender, StringComparison.InvariantCulture))
                {
                    if (!((this.returnVal.FindIndex(x => x.FirstName.Equals(person.FirstName, StringComparison.InvariantCulture)
                        && x.LastName.Equals(person.LastName, StringComparison.InvariantCulture)
                        && x.BirthDate == person.BirthDate)) > 0))
                    {
                        returnVal.Add(person);
                    }
                }
                if (person.Children != null)
                {
                    ProcessPerson(person.Children, Gender);
                }
            }

            return returnVal;
        }
    }
}
