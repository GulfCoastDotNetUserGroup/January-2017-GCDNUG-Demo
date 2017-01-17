using System.Threading;
using January_2017_GCDNUG_Demo.Misc;
using System.Threading.Tasks;

namespace January_2017_GCDNUG_Demo.Helpers
{
    public static class ExceptionHelper
    {
        public static void LogExceptionLongRunning(DotNetUsersGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.LongRunningFakeProcessLength);
        }

        public static async Task LogExceptionLongRunningAsync(DotNetUsersGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.LongRunningFakeProcessLength));
        }

        #region Syncronous

        public static void LogException(DotNetUsersGroupException e, string message)
        {
            //Thread.Sleep(DemoConstants.FakeProcessLength);
        }              

        public static void WriteToMoreImportantThingsToWorryAboutLog(DotNetUsersGroupException e, string message)
        {
            //Thread.Sleep(DemoConstants.FakeProcessLength);
        }      

        public static void WriteToTicketLog(DotNetUsersGroupException e, string message)
        {
            //Thread.Sleep(DemoConstants.FakeProcessLength);
        }

        public static void WriteToImmediateAttentionLog(DotNetUsersGroupException e, string message)
        {
            //Thread.Sleep(DemoConstants.FakeProcessLength);
        }

        #endregion Syncronous

        #region Asyncronous

        public static async Task LogExceptionAsync(DotNetUsersGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task WriteToMoreImportantThingsToWorryAboutLogAsync(DotNetUsersGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task WriteToTicketLogAsync(DotNetUsersGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        public static async Task WriteToImmediateAttentionLogAsync(DotNetUsersGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength));
        }

        #endregion Asyncronous
    }
}
