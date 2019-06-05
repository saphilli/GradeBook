using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Stats
    {
        public double Average{
            get{
                return Sum/Count;
            }
        }
        public double Lowest;
        public double Highest;
        public char Letter{
            get{
                switch(Average){
                    case var g when g >= 70.0:
                        return 'A';
                    case var g when g >= 60.0:
                        return 'B';
                    case var g when g >= 50.0:
                        return 'C';   
                    case var g when g >= 40.0:
                        return 'D';
                    default: return 'F';     
                 }
             }
        }
        
        public int Count;
        public double Sum;  
        public void Add(double number){
            Sum+= number;
            Count+=1;
            Highest = Math.Max(Highest,number);
            Lowest = Math.Min(Lowest,number);
        }
        public Stats(){
            Sum = 0;
            Count =0;
            Highest = 0;
            Lowest = 100;
        }
        
    }
}