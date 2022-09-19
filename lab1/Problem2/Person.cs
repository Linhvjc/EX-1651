using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public Person(int age)
        {
            this.Name = "No name";
            this.Age = age;
        }
        public Person(int age, string name)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
