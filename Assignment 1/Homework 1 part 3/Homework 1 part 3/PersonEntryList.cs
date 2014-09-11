using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_1_part_3
{
    class PersonEntryList
    {
        private static List<PersonEntry> personList = new List<PersonEntry>();

        public static void addPerson(PersonEntry person)
        {
            personList.Add(person);
        }

        public static List<PersonEntry> getPersonEntityList()
        {
            return personList;
        }
    }
}
