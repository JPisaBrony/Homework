using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_3
{
    class PersonEntryList
    {
        // static list used for storing PersonEntry objects
        private static List<PersonEntry> personList = new List<PersonEntry>();

        // this method add items to the private list
        public static void addPerson(PersonEntry person)
        {
            // adds items to list
            personList.Add(person);
        }

        // this method gets the whole list for reading
        public static List<PersonEntry> getPersonEntityList()
        {
            // returns list "personList"
            return personList;
        }
    }
}
