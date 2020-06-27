using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TinhTienDien
{
    [TestClass]
    public class UnitTestTinhTienDien
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataTinhTienDien.csv", "dataTinhTienDien#csv",
            DataAccessMethod.Sequential),
                DeploymentItem("dataTinhTienDien.csv"), TestMethod]


        public void TestMethodTienDienDataDriven()
        {
            SourceCode.SomeCode obj = new SourceCode.SomeCode();

            int socu = Convert.ToInt32(TestContext.DataRow[0]);
            int somoi = Convert.ToInt32(TestContext.DataRow[1]);

            Double Expected = Convert.ToDouble(TestContext.DataRow[2]);
            Double Actual = obj.TinhTienDien(socu, somoi);

            Assert.AreEqual(Expected, Actual);
        }
    }
}
