using System.Threading;
using January_2017_GCDNUG_Demo.Misc;
using static January_2017_GCDNUG_Demo.Misc.Enums;
using System.Threading.Tasks;

namespace January_2017_GCDNUG_Demo.Helpers
{
    public static class ExceptionHelper
    {
        #region Public Methods

        public static void LogException(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(1000);
        }

        public static void LogExceptionLongRunning(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(DemoConstants.FakeProcessLength*2);
        }

        public static async Task LogExceptionAsync(DotNetUserGroupException e, string message)
        {
            await Task.Run(() => Thread.Sleep(DemoConstants.FakeProcessLength*2));
        }

        public static void WriteToMoreImportantThingsToWorryAboutLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(1000);
        }

        public static void WriteToTicketLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(1000);
        }

        public static void WriteToImmediateAttentionLog(DotNetUserGroupException e, string message)
        {
            Thread.Sleep(1000);
        }

        #endregion Public Methods
    }
}
