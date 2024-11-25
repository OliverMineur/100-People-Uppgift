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
        private string FirstName { get; }
        private string LastName { get; }
        private DateTime Birthyear { get; }
        private TimeSpan TS;
        Random Random = new Random();

        public People()
        {
            var rn = "Johan, John, Erik, Bertil".Split(", ");
            var en = "Bylander, Eriksson, Svensson, Johansson".Split(", ");

            FirstName = rn[Random.Next(rn.Length)];
            LastName = en[Random.Next(en.Length)];
            Birthyear = new DateTime(Random.Next(1900, 2024), Random.Next(1, 12), Random.Next(1, 28));
            TS = DateTime.Now - Birthyear;
        }

    }

}
