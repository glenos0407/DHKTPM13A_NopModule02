using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HuyChuoi
{
    [TestClass]
    public class UnitTestHuyChuoi
    {
        [TestMethod]
        public void TestCaseHuyChuoi_01()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
            
            string Expected = "afgh";
            string Actual = obj.HuyChuoi("abcdefhg",4,1);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_02()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",5,-1);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_03()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",5,9);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_04()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",-1,5);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_05()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdef";
            string Actual = obj.HuyChuoi("abcdefhg",5,5);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_06()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "";
            string Actual = obj.HuyChuoi("abcdefhg",8,0);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_07()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefh";
            string Actual = obj.HuyChuoi("abcdefhg",1,7);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_08()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",4,-1);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_09()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",4,8);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_10()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdefhg";
            string Actual = obj.HuyChuoi("abcdefhg",-1,5);

            Assert.AreEqual(Expected, Actual);
        }
        [TestMethod]
        public void TestCaseHuyChuoi_11()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string Expected = "abcdef";
            string Actual = obj.HuyChuoi("abcdefhg",9,5);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
