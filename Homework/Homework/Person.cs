using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public abstract class Person
    {
        public string name;
        public int age;
        protected string Name
        {
            get { return name; }
            set { name = value; }
        }
        protected int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
