using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3
{
    internal class Family
    {
        private List<Person> list = new List<Person>();
        public List<Person> List
        {
            get { return list; }
            set { list = value; }
        }

        public void AddMember(Person member)
        {
            list.Add(member);
        }

        public Person GetOldestMember()
        {
            Person oldest = new Person();
            int maxAge = 0;
            foreach(Person current in List)
            {
                if(current.Age > maxAge)
                {
                    maxAge = current.Age;
                    oldest = current;
                }
            }
            return oldest;
        }


    }
}
