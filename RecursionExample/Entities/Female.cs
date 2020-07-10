using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExample.Entities
{
    public class Female : Person
    {
        public Female(string firstName, string lastName, DateTime birthDate, List<Person> children) : base(firstName, lastName, birthDate)
        {
            this.BirthGender = "Female";
            base.Children = children;
        }
    }
}
