using TestMvcWebApp.Utility;
using Xunit;

namespace TestMvcWebApp.Util
{
    public class DateUtilTest
    {
        [Fact]
        public void GetCurrentDate_IsNotNull()
        {
            Assert.NotNull(DateUtil.GetCurrentDate());
        }

        [Fact]
        public void GetCurrentTime_IsNotNull()
        {
           Assert.NotNull(DateUtil.GetCurrentTime());
        }
    }
}