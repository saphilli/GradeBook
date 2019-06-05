using System;
using System.Collections.Generic;

namespace GradeBook {     
    public class InMemoryBook : Book {
        private List<double> grades;
        //public string Name; //remove this as we added the inheritance

        public InMemoryBook(string name) : base(name){
                grades = new List<double> ();
                Name = name;
            }
        public string GetLetterGrade(double grade){
            if(grade<0 || grade >100) return "N/A";
            switch(grade){
                case var g when g >= 70.0:
                    return "I";
                case var g when g >= 60.0:
                    return "II.I";
                case var g when g >= 50.0:
                    return "II.II";   
                case var g when g >= 40.0:
                    return "III";
                default: return "Fail";     
            }

        }
        public override event GradeAddedDelegate GradeAdded;
        public override void AddGrade(double grade) {
            if(grade>0 && grade<101) {
                grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this,new EventArgs());
                }
            } 
            else{
                Console.WriteLine($"The grade you entered, {grade}, is not a valid grade and was not recorded.");
            } 
        }
        public Stats GetStatistics(){
                 if(grades.Count == 0)
                 {
                     Console.WriteLine($"There are no grades recorded in the gradebook");
                 }
                 var resultStats = new Stats(grades);
                 return resultStats;

                 }
        // public void printStats(){
        //          var stats = ComputeStats();
        //          Console.WriteLine($"Maximum Grade:{stats.Highest}");
        //          Console.WriteLine($"Minimum Grade:{stats.Lowest}");
        //          Console.WriteLine($"Average Grade:{stats.Average:n1}");
        //      }

        }
}