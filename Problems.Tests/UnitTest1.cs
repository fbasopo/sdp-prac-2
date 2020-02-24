using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        // [SetUp]
        // public void Setup()
        // {
        // }

        [TestCase("hello","5,1:hello")]
        [TestCase("","0,0:")]
        [TestCase("what    ...  did you say?? ","27,5:what    ...  did you say?? ")]


         public void TestProgram(string input, string correctAnswer)
        {
            //ARRANGE 
            //there is no need to arrange 
            //ACT
            var pass=Program.Prefix(input);
            //ASSERT
            Assert.That(pass,Is.EqualTo(correctAnswer));      
        }

        
    }
   
}