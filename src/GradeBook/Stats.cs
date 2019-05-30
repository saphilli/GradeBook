using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public double average = 0.0;
        public double lowest = 0;
        public double highest = 100;

        public Stats(List<double> grades){
            var sum = 0.0;
            foreach(double n in grades){
                highest = Math.Max(highest,n);
                lowest = Math.Min(lowest,n);
                sum+=n;
            }
            average = sum/grades.Count;
        }
        
    }
}