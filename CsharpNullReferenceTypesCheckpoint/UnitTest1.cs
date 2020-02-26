using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CsharpNullReferenceTypesCheckpoint
{
    [TestClass]
    public class TestsBefore
    {
        [TestMethod]
        public void Test1()
        {
            var student = new Student()
            {
                FirstName = "John"
            };

            string result = ($"The student is called {student.FirstName}{student.LastName}.");

            Assert.AreEqual("The student is called John.", result);
        }

        [TestMethod]
        public void Test2()
        {
            var student = new Student()
            {
                FirstName = "John"               
                // LastName = "Peters"
            };

            string result = ($"The student is called {student.FirstName}{student.LastName?.Length}.");

            Assert.AreEqual("The student is called John.", result);
        }
    }

    public class Student
    {
        public string? FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public char? Grade { get; set; }
    }
}
