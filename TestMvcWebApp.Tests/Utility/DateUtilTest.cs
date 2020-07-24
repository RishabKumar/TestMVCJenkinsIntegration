using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestMvcWebApp.Utility;

namespace TestMvcWebApp.Tests.Utility
{
    [TestClass]
    public class DateUtilTest
    {
        [TestMethod]
        public void GetCurrentDate_IsNotNull()
        {
            Assert.IsNotNull(DateUtil.GetCurrentDate());
        }

        [TestMethod]
        public void GetCurrentTime_IsNotNull()
        {
            Assert.IsNotNull(DateUtil.GetCurrentTime());
        }
    }
}