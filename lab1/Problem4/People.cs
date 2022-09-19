using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem4
{
    internal class List
    {
        private List<Person> people = new List<Person>();
        public List<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        public void AddMember(Person member)
        {
            people.Add(member);
        }

        public List<Person> Over30()
        {
            List<Person> newList = new List<Person>();
            foreach (Person person in People)
            {
                if(person.Age > 30)
                {
                    newList.Add(person);
                }
            }
            return newList.OrderBy(x => x.Name).ToList();
        }


    }
}
