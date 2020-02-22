using NUnit.Framework;
using Problems;

namespace Problems.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

       [Test]
        public void Test1()
        {
            
            string result = Program.Prefix("hello");
            Assert.AreEqual("5,1:hello",result);
        }
        [Test]
        public void Test2()
        {
           
           string result = Program.Prefix("");
           Assert.AreEqual("0,0:", result);
        }
        [Test]
        public void Test3()
        {
            
        string result = Program.Prefix("what    ...   did you say??");
          Assert.AreEqual("27,5:what    ...   did you say??", result);
        }
    }
}