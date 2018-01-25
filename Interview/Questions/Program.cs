using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questions
{
    class Program
    {
        static void Main(string[] args)
        {
            MathRound mr = new MathRound();
            mr.Execute();

            DynamicAndByte db = new DynamicAndByte();
            db.Execute();

            CompareToLearn ctl = new CompareToLearn();
            ctl.Execute();

            ConstructorAndDistructor cad = new ConstructorAndDistructor();

            StaticMethod.Execute();

            // Index out of range exception.
            //int[] i = new int[0];
            //Console.WriteLine(i[0]);

            Console.ReadKey();
        }
    }
}
