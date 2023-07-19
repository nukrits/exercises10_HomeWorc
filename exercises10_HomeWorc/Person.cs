using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises10_HomeWorc
{
    public class Person
    {
        public static int count = 0;
        public Person() 
        {
            count = count + 1;
        }
    }
}
