using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTienDien
{
    public class UnitTestTienDienThrowExcepted
    {
        public TestContext TestContext { get; set; }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\dataTinhTienDienThrowExpected.csv",
            "dataTinhTienDienThrowExpected#csv",
            DataAccessMethod.Sequential),
                DeploymentItem("dataTinhTienDienThrowExpected.csv"), TestMethod]

        public void TestTinhTienDienThrowExpected()
        {
            Exception ExceptedException = null;
            try
            {
                SourceCode.SomeCode obj = new SourceCode.SomeCode();

                int chisocu = Convert.ToInt32(TestContext.DataRow[0]);
                int chisomoi = Convert.ToInt32(TestContext.DataRow[1]);

                double Expected = Convert.ToDouble(TestContext.DataRow[2]);
                double Actual = obj.TinhTienDien(chisocu, chisomoi);

                Assert.AreEqual(Expected, Actual);

            }
            catch(Exception ex)
            {
                ExceptedException = ex;
            }
            Assert.IsNotNull(ExceptedException);
        }

    }
}
