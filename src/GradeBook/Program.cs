using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var grades = new Book("Test Book");
            foreach(string n in args){
                grades.AddGrade(Convert.ToDouble(n));
            }
            grades.ComputeStats();
        }
    }
}
