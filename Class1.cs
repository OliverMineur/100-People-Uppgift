using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100_People_Uppgift
{
    internal class People
    {
        public string FirstName { get; }
        public string LastName { get; }
        public DateTime Birthyear { get; }
        public TimeSpan TS;
        Random Random = new Random();
        public People(string firstName, string lastName, DateTime birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthyear = birthYear;
        }
        public People()
        {
            var rn = "Johan, John, Erik, Bertil, Oliver, Azat, Hampus, Adolf".Split(", ");
            var en = "Bylander, Eriksson, Svensson, Johansson, Mineur, Sandström, Sandmark, Karaboga".Split(", ");

            FirstName = rn[Random.Next(rn.Length)];
            LastName = en[Random.Next(en.Length)];
            Birthyear = new DateTime(Random.Next(1900, 2024), Random.Next(1, 12), Random.Next(1, 28));
            TS = DateTime.Now - Birthyear;
        }

    }

}
