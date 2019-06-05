using System;
using System.Collections.Generic;

namespace GradeBook{   
    public interface IBook{ //Interface naming convention, starts with capital I
        void AddGrade(double grade); // dont use public because it is assumed to be public
        Stats GetStatistics();
        void PrintStatistics();
        string Name{ get;set;} //property Name is able to be read with the getter
        event GradeAddedDelegate GradeAdded;

    }
}