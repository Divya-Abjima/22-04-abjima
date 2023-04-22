using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_22_04
{
    public class Class1
    {

        public virtual void printName(string name)
        {
            Console.WriteLine(name);
        }
    }

    public class ChildClass : Class1
    {
        public static  void greeting(string name)
        {
            Console.WriteLine("Hello "+name);
        }
    }
    public class ChildClass2 : Class1
    {
        public override void printName(string name)
        {
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
