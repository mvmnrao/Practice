using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");
           

            Minor minor1 = new Major();
            Console.WriteLine(minor1.GetGender());
            Console.WriteLine(
                "Major has been assigned to Minor, i.e., Child/Inherited class has been assigned to Parent/Base ");

            //Major major = new Minor() as Major;
            //Console.WriteLine(major.GetGender());
            //Console.WriteLine(
            //    "Minor has been assigned to Major, i.e., Parent/Base class has been assigned to Child/Inherited");

            DerivedClass dc = new DerivedClass();
            Console.WriteLine(dc.NormalMethod());

            Console.ReadKey();
        }

        static string CanHaveStaticMethod()
        {
            //MyStaticClass
            
            
            return "";
        }

    }

    public static class MyStaticClass
    {
        //public void NormalMethod()
        //{
            
        //}

        public static string PublicMethod()
        {
            return "Public";
        }

        private static string PrivateMethod()
        {
            return "Private";
        }
    }

    public abstract class MyAbstractClass
    {

        //public abstract string AbstractMethod()
        //{
        //    return "Abstract";
        //}

        public string NormalMethod()
        {

            return "Normal Method";
        }

        public virtual string VirtualMethod()
        {
            return "Virtual Method";
        }
    }

    public class DerivedClass : MyAbstractClass
    {
        //public new string NormalMethod()
        //{
        //    return "Normal Method from Derived Class";
        //}
    }
}
