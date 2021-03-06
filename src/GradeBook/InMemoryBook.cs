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
        public override Stats GetStatistics(){
            if(grades.Count == 0)
            {
                Console.WriteLine($"There are no grades recorded in the gradebook");
            }
            var resultStats = new Stats();
            foreach(var n in grades){
                resultStats.Add(n);
            }
            return resultStats;

            }

    }
}