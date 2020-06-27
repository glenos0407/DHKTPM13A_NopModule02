using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSort
{
    [TestClass]
    public class UnitTestQuickSort
    {
        Exception ExpectedException = null;
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

                int[] a = { 1, 3, 2, 4, 5 };
                int[] expectedResult = { 1, 2, 3, 4, 5 };
                obj.QuickSort(a, 0, 4);

                Assert.AreEqual(expectedResult, a);
            }
            catch (Exception ex)
            {
                ExpectedException = ex;
            }
            Assert.IsNotNull(ExpectedException);
        }
        [TestMethod]
        public void TestMethod2()
        {
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            int[] a = { 1, 3, 2, 4, 5 };
            int[] expectedResult = { 1, 2, 3, 4, 5 };
            obj.QuickSort(a, -1, 4);

            Assert.AreEqual(expectedResult, a);

            }
            catch (Exception ex)
            {
                ExpectedException = ex;
            }
            Assert.IsNotNull(ExpectedException);
        }
        [TestMethod]
        public void TestMethod3()
        {
            try
            {
                MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

                int[] a = { 1, 3, 2, 4, 5 };
                int[] expectedResult = { 1, 2, 3, 4, 5 };
                obj.QuickSort(a, 0, 5);

                Assert.AreEqual(expectedResult, a);
            }
            catch (Exception ex)
            {
                ExpectedException = ex;
            }
            Assert.IsNotNull(ExpectedException);
        }
    }
}
