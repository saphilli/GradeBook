using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public double Average = 0.0;
        public double Lowest = 0;
        public double Highest = 100;
        public char Grade;
        public Stats(List<double> grades){
            var sum = 0.0;
            foreach(double n in grades){
                Highest = Math.Max(Highest,n);
                Lowest = Math.Min(Lowest,n);
                sum+=n;
            }
            Average = sum/grades.Count;
        }
        
    }
}