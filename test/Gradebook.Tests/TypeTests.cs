using System;
using Xunit;

namespace GradeBook.Tests{
    //Tests for working w/ reference and value types
    public class TypeTests{
        private IBook GetBook(string name){
            return new DiskBook(name);
        }
        private void SetName(IBook book,string name){
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            book.Name = name;
        }
        //passes a book variable by reference instead of value
        private void GetBookSetName(ref IBook book, string name){
            book = GetBook(name); 
        }

        //delegate and delegate test
        int count = 0;
        public delegate string WriteLogDelegate(string logMessage);
        [Fact] 
        public void WriteLogDelegateCanPointToMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage; // this is like adding the method to the "queue" of methods that will be invoked.
            log += IncrementCount;
            var result = log("Hello!");
            //Assert.Equal(3,result);

        }
        private string IncrementCount(string message){
            count++;
            return message.ToLower();
        }
        private string ReturnMessage(string message)
        {
            count++;
            return message;
        }
        [Fact] 
        public void PassesByReference(){
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            Assert.Equal("New Name",book1.Name);
        }
        
        [Fact]
        public void TestName(){
            var book1 = GetBook("Book 1");
            SetName(book1,"New Name"); 
            Assert.Equal("New Name", book1.Name);
        }
        [Fact] //Attribute
        public void TestObjectRefs(){
            //arrange 
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");
            Assert.Equal("Book 1",book1.Name);
            Assert.Equal("Book 2",book2.Name);
        }
        [Fact] //checks if book1 and book2 point to the same object
        public void TwoVarsRefSameObject(){
            //arrange 
            var book1 = GetBook("Book 1");
            var book2 = book1;
            Assert.Same(book1,book2); //Should Pass as book1 and book2 point to same object
         //   Assert.True(Object.ReferenceEquals(book1,book2)); //Same as Assert.Same()
 
        }
    }
}
