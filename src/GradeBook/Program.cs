using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            IBook grades = new DiskBook("Test Book");
            grades.GradeAdded += OnGradeAdded;
            var input = "";
            Console.WriteLine("Enter the grades to be added to the book, by typing one grade and pressing enter between each.");
            Console.WriteLine("Enter s or S to stop");
                while(true) {
                    try{
                        input = Console.ReadLine();
                        if(input == "S"||input == "s"){ 
                            grades.PrintStatistics();
                            break; 
                        }
                        grades.AddGrade(double.Parse(input));

                    }
                    catch(ArgumentException){
                         Console.WriteLine("The input was invalid, please enter numbers only.");
                    }
                    catch(FormatException){
                        Console.WriteLine("The input was invalid, please enter numbers only.");
                    }
                }
           
        }
         static void OnGradeAdded(object sender, EventArgs e)
         {
             Console.WriteLine("The grade was added to the gradebook.");
         }
    }
}
