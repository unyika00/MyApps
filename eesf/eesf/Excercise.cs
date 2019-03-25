using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eesf
{
    class Excercise
    {
        public string Name;

        public Excercise(string aName)
        {
            Name = aName;
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }
        public string getName()
        {
            return Name;
        }
    }
}
