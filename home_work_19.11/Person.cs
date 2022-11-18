using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home_work_19._11
{
    internal class Person
    {
       

           public string _name;

            public string name
            {
                set { _name = value; }
                get { return _name; }
            }

            public Person(string name)
            {
                this.name = name;
            }
        
    }
}
