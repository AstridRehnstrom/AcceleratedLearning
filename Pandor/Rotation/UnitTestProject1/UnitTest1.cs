using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rotation;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var result = Program.RotateList(new List<int> { 200, 300, 400 }, 1);

            //Assert.AreEqual(300, result[0]);
            //Assert.AreEqual(400, result[1]);
            //Assert.AreEqual(200, result[2]);

            CollectionAssert.AreEqual(new List<int> { 300, 400, 200 }, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var result = Program.RotateList(new List<int> { 200, 300, 400 }, 2);
            CollectionAssert.AreEqual(new List<int> { 400, 200, 300}, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var result = Program.RotateList(new List<int> { 200, 300, 400 }, 0);
            CollectionAssert.AreEqual(new List<int> { 200, 300, 400 }, result);
        }
    }
}
