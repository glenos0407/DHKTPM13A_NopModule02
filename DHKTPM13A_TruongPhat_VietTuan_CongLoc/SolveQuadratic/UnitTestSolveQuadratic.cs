using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolveQuadratic
{
    [TestClass]
    public class UnitTestSolveQuadratic
    {
        [TestMethod]
        public void TestMethod1()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Vô số nghiệm";
            string Actual = obj.SolveQuadratic(0,0,0,out float x1,out float x2);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Vô nghiệm";
            string Actual = obj.SolveQuadratic(0, 0, 1, out float x1, out float x2);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod3()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Vô nghiệm";
            string Actual = obj.SolveQuadratic(1, 1, 1, out float x1, out float x2);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Có 1 nghiệm";
            string Actual = obj.SolveQuadratic(0, 1, 2, out float x1, out float x2);

            Assert.AreEqual(Expected, Actual);
        }

        [TestMethod]
        public void TestMethod5()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Có nghiệm kép";
            string Actual = obj.SolveQuadratic(2,4,2, out float x1, out float x2);

            Assert.AreEqual(Expected, Actual);
        }
       

        [TestMethod]
        public void TestMethod6()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "Có 2 nghiệm phân biệt";
            string Actual = obj.SolveQuadratic(1,-4,3, out float x1, out float x2);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
