using System;
using System.Collections.Generic;
using System.IO;

namespace GradeBook
{
    public class DiskBook : Book {

        string path;
        string fileName; 
        // base name references the Book name property
        public DiskBook(string name) : base(name)
        {
            path = $"C:\\Users\\sphillips\\gradebook\\src\\GradeBook\\{name}.txt";
            fileName = $"{name}.txt";
            Name = name;
            if (!File.Exists(path)) {   
            // Create the unique gradebook as a text file to be written to.
                var sw = File.CreateText(fileName);
                sw.Close();

            }
        }
        
        public override void AddGrade(double grade){
            using (var writer = File.AppendText(path)) 
            {
                writer.WriteLine(grade);
            }//at the end of this code, the compiler disposes the objects
        }
        public override event GradeAddedDelegate GradeAdded;
        //public override Stats GetStatistics();
    }
}

