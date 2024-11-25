using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_People_Uppgift
{
    internal class People
    {
        private string FirstName { get; }
        private string LastName { get; }
        private DateTime Birthyear { get; }
        public People(string firstName, string lastName, DateTime birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthyear = birthYear;
        }
    }

}
