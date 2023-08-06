global using global::System;
global using global::System.Collections.Generic;
global using global::System.IO;
global using global::System.Linq;
global using global::System.Net.Http;
global using global::System.Threading;
global using global::System.Threading.Tasks;
using System.Xml;

namespace ClassTutorial
{
     internal class Program
    {
        static void Main(string[] args)
        {
            ISecondClass print = new SecondClass();
            // Area of a Triangle;
            var ansTri = print.AreaTraingle(14, 6);
            Console.WriteLine("The area of a triangle is {0} ", ansTri);
            var myAns = print.Area(8);
            Console.WriteLine("The area of a circle is {0} ", myAns);
            // Area of a Rectangle
            var answer = print.Area(14, 5.3);
            Console.WriteLine("The area of a rectangle is = {0}", answer);
            var age = print.YearOfBirth(1995);
            Console.WriteLine("My name is Tosin and I'm {0} ", age + " Years old");
        }
    }
}


