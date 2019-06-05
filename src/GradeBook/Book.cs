using System;
using System.Collections.Generic;

namespace GradeBook { 
    public delegate void GradeAddedDelegate(object sender, EventArgs args); //this delegate is a convention for an event
    public abstract class Book : NamedObject, IBook {
        public Book(string name){
            Name = name;
        }
        public abstract void AddGrade(double grade);
        public abstract event GradeAddedDelegate GradeAdded;
        //public abstract Stats GetStatistics();
    }
}

   
