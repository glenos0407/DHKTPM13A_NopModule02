using System;
using System.ComponentModel.Design;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Largest
{
    [TestClass]
    public class UnitTestLargest
    {
        [TestMethod]
        public void TestLargest_01()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            int[] a = {1};
            int expectedResult = 1;
            int actualResult = obj.Largest(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLargest_02()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            int[] a = { 4,3,6 };
            int expectedResult = 6;
            int actualResult = obj.Largest(a);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestLargest_03()
        {
            Exception ExceptedException = null;
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

                int[] a = { };
                int expectedResult = 961611;
                int actualResult = obj.Largest(a);

                Assert.AreEqual(expectedResult, actualResult);
            }
            catch (Exception ex)
            {
                ExceptedException = ex;
            }
            Assert.IsNotNull(ExceptedException);
        }
    }
}
