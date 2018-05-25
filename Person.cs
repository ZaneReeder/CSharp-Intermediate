using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section2
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }
        public string name;
        public string Username { get; set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;

                return years
            }
        }
    }
}
