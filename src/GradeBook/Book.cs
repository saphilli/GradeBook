using System;
using System.Collections.Generic;

namespace GradeBook{ 
    public class Book {
            private List<double> grades;
            private string name;

        public Book(string name){
                grades = new List<double> ();
                this.name = name;
            }
            public void AddGrade(double grade) {
                if(grade>0 && grade<101) {
                    grades.Add(grade);
                } 
                else{
                    Console.WriteLine($"The grade you entered, {grade}, is not a valid grade and was not recorded.");
                } 
            }
             public Stats ComputeStats(){
                 if(grades.Count == 0)
                 {
                     Console.WriteLine($"There are no grades recorded in the gradebook");
                 }
             
                 var resultStats = new Stats(grades);
                 return resultStats;
                
                 }
             public void printStats(){
                 var stats = ComputeStats();
                 Console.WriteLine($"Maximum Grade:{stats.highest}");
                 Console.WriteLine($"Minimum Grade:{stats.lowest}");
                 Console.WriteLine($"Average Grade:{stats.average:n1}");
             }

        }
}