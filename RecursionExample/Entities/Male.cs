using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExample.Entities
{
    public class Male : Person
    {
        public Male(string firstName, string lastName, DateTime birthDate, List<Person> children) : base(firstName, lastName, birthDate)
        {
            base.BirthGender = "Male";
            base.Children = children;
        }
    }
}
