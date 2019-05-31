using System;
using System.Collections.Generic;

namespace GradeBook
{   
    public interface IBook{
        void AddGrade(double grade);
        Stats GetStatistics();
        string Name{ get;}

    }
}