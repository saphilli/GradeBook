using System;
using System.Collections.Generic;

namespace GradeBook { 
    public delegate void GradeAddedDelegate(object sender, EventArgs args); //this delegate is a convention for an event
    
    public abstract class Book : NamedObject{
        public abstract void AddGrade(double grade);
    }
}

   
