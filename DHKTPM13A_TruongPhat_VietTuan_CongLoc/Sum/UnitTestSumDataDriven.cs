using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sum
{
    [TestClass]
    public class UnitTestSumDataDriven
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataSum.csv",
            "dataSum#csv",
            DataAccessMethod.Sequential),
                DeploymentItem("dataSum.csv"), TestMethod]

        public void TestMethodSUMDataDriven()
        {
            MethodLibrary.MethodLibrary oj = new MethodLibrary.MethodLibrary();

            long Expected = Convert.ToInt64(TestContext.DataRow[1]);
            long Actual = oj.Sum(Convert.ToInt64(TestContext.DataRow[0]), out long s1);

            Assert.AreEqual(Expected, Actual);
        }

    }
}
