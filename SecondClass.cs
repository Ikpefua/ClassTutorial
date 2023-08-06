using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
    public class SecondClass : ISecondClass
    {
        const double pi = 3.14;
        //area of a rectangle
        /// <summary>
        /// to caculate area of a rectangle
        /// </summary>
        /// <param name="lenght"></param>
        /// <param name="breadth"></param>
        /// <returns></returns>
        //area of a traingle
        public double Area(double lenght, double breadth)
        {
            return lenght * breadth;
        }

        //area of a circle
        /// <summary>
        /// to caculate area of a circle
        /// </summary>
        /// <param name="radius"></param>
        /// <param ></param>
        /// <returns></returns>
        public double Area(double radius)
        {
            return pi * radius * radius;
        }

        //area of a triangle
        /// <summary>
        /// to calculate the area of a triangle
        /// </summary>
        /// <param name="basee"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public double AreaTraingle(double basee, double height)
        {
            return basee * height / 0.5;
        }

        public double YearOfBirth(double year)
        {
            double currentDate = DateTime.Now.Year;
            return  currentDate - year;
        }
    }
}
