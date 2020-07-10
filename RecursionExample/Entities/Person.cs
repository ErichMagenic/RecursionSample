using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionExample.Entities
{
    public class Person
    {
        public Person(string firstName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get { return $"{this.FirstName} {this.LastName}"; } }
        public DateTime BirthDate { get; private set; }
        public Int32 Age { get { return (int)Math.Floor((DateTime.UtcNow - this.BirthDate).TotalDays / 365.25D); } }
        public string BirthGender { get; protected set; }
        public List<Person> Children { get; protected set; }
        public override string ToString()
        {
            return FullName.ToString();
        }
    }
}
