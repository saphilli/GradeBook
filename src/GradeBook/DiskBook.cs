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
        }
        
        public override void AddGrade(double grade){  

            if(grade>0 && grade<101) {
                using (var writer = File.AppendText(path)) 
                {
                    writer.WriteLine(grade);
                }//at the end of this code, the compiler disposes the objects
                if(GradeAdded != null)
                {
                    GradeAdded(this,new EventArgs());
                }
            } 
            else{
                Console.WriteLine($"The grade you entered, {grade}, is not a valid grade and was not recorded.");
            } 
           
            
        }
        public override event GradeAddedDelegate GradeAdded;
        public override Stats GetStatistics(){
            var resultStats = new Stats();
            var count = 0;
            using (var reader = File.OpenText(path)){
                var line = reader.ReadLine();
                while(line!=null){
                    var num = double.Parse(line);
                    resultStats.Add(num);
                    line = reader.ReadLine();
                }
                count++;
            }
            if(count == 0)
            {
                Console.WriteLine($"There are no grades recorded in the gradebook");
            }
            return resultStats;
        }
    }
}


