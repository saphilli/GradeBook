using System;
using System.Collections.Generic;

namespace GradeBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            var grades = new InMemoryBook("Test Book");
            grades.GradeAdded += OnGradeAdded;
            var input = "";
            Console.WriteLine("Enter the grades to be added to the book, by typing one grade and pressing enter between each.");
            try{
                while(true) {
                    input = Console.ReadLine();
                    if(input == "S "||input == "s"){ 
                        break; 
                    }
                    grades.AddGrade(double.Parse(input));
                }
            }
            catch(ArgumentException e){
               Console.WriteLine(e.Message);
            }
            catch(FormatException e){
                Console.WriteLine(e.Message);
            }
            finally{
                Console.WriteLine("The input was invalid, please enter numbers only.");
            }
            grades.ComputeStats();
           
        }
         static void OnGradeAdded(object sender, EventArgs e)
         {
             Console.WriteLine("The grade was added");
         }
    }
}
