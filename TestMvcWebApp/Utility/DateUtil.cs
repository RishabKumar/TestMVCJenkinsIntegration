using System;

namespace TestMvcWebApp.Utility
{
    public static class DateUtil
    {
        public static string GetCurrentDate()
        {
            return DateTime.Today.ToShortDateString();
        }

        public static string GetCurrentTime()
        {
            return DateTime.Now.ToShortTimeString();
        }
    }
}