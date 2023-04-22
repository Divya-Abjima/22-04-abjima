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
    
    public sealed class PwdInfo : Class1
    {
        public static void pwdInfo()
        {
            string username = "divya0729";
            string pwd = "this ain't a password";
        }
    }

    public class ShowPwdInfo : PwdInfo    //class PwdInfo can't be inherited because it is sealed
    {
        public static void showPwd()
        {
            Console.WriteLine(username + " " + pwd);
        }
    }
    public class ChildClass2 : Class1
    {
        public static void printName(string name)
        {
            name = Console.ReadLine();
            Console.WriteLine(name);
        }
    }
}
