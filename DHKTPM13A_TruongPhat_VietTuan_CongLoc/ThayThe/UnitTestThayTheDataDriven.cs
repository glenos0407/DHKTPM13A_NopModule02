using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ThayThe
{
    [TestClass]
    public class UnitTestThayTheDataDriven
    {
        //public TestContext TestContext { get; set; }

        //[TestMethod]
        //[DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
        //    "|DataDirectory|\\dataThayThe.csv", "dataThayThe#csv",
        //    DataAccessMethod.Sequential), DeploymentItem("dataThayThe.csv")]
        //public void TestMethod1()
        //{
        //    MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();
        //    string a, b, c;
        //    a = Convert.ToString(TestContext.DataRow[0]);
        //    b = Convert.ToString(TestContext.DataRow[1]);
        //    c = Convert.ToString(TestContext.DataRow[2]);

        //    string Expected = Convert.ToString(TestContext.DataRow[3]);
        //    string Actual = obj.ThayThe(a, b, c);

        //    Assert.AreEqual(Expected, Actual);
        //}

        public TestContext TestContext { get; set; }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataThayThe.csv", "dataThayThe#csv",
                DataAccessMethod.Sequential), DeploymentItem("dataThayThe.csv")]
        public void TestDGN()
        {
            MethodLibrary.MethodLibrary obj = new MethodLibrary.MethodLibrary();

            string a, b, c;
            a = TestContext.DataRow[0].ToString();
            b = TestContext.DataRow[1].ToString();
            c = TestContext.DataRow[2].ToString();

            string expectedResult = TestContext.DataRow[3].ToString();
            string actualResult = obj.ThayThe(a, b, c);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
