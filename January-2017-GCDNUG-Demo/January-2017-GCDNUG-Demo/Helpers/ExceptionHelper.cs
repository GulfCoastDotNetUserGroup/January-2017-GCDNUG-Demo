using System.Threading;
using January_2017_GCDNUG_Demo.Misc;
using static January_2017_GCDNUG_Demo.Misc.Enums;
using System.Threading.Tasks;

namespace January_2017_GCDNUG_Demo.Helpers
{
    public static class ExceptionHelper
    {
        #region Syncronous

        public static void LogException(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength);
        }      

        public static void LogExceptionLongRunning(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength*2);
        }       

        public static void WriteToMoreImportantThingsToWorryAboutLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength);
        }      

        public static void WriteToTicketLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength);
        }

        public static void WriteToImmediateAttentionLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength);
        }

        #endregion Syncronous

        #region Asyncronous

        public static async Task LogExceptionAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task LogExceptionLongRunningAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.LongRunningFakeProcessLength));
        }

        public static async Task WriteToMoreImportantThingsToWorryAboutLogAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task WriteToTicketLogAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task WriteToImmediateAttentionLogAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        #endregion Asyncronous
    }
}
