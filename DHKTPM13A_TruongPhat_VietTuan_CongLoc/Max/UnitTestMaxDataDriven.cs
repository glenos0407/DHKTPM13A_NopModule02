using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SourceCode;

namespace Max
{
    [TestClass]
    public class UnitTestMaxDataDriven
    {
        public TestContext TestContext { get; set; }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataMax.csv", "dataMax#csv", DataAccessMethod.Sequential),
                DeploymentItem("dataMax.csv"), TestMethod]
        public void TestMethod1()
        {
            SourceCode.SomeCode CodeName = new SourceCode.SomeCode();
            int a, b, c;
            a = Convert.ToInt32(TestContext.DataRow[0]);
            b = Convert.ToInt32(TestContext.DataRow[1]);
            c = Convert.ToInt32(TestContext.DataRow[2]);

            int Expected = Convert.ToInt32(TestContext.DataRow[3]);
            int Actual = CodeName.SourceMax(a, b, c);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
