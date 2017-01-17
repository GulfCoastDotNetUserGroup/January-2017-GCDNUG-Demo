using January_2017_GCDNUG_Demo.Misc;
using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class AwaitInCatchBlockDemo : AbstractDemo
    {
        #region Properties

        public bool UseAwait { get; set; }

        #endregion Properties

        #region Constructors

        public AwaitInCatchBlockDemo(bool useAwait)
        {
            UseAwait = useAwait;
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            if (UseAwait)
            {
                BuildMessageAsync();
            }
            else
            {
                BuildMessage();
            }
            return Message;
        }

        #endregion Public Methods

        #region Private Methods

        private void BuildMessage()
        {
            try
            {
                throw new DotNetUsersGroupException();
            }
            catch (DotNetUsersGroupException e)
            {
                Message = OopsMessage;
                LogExceptionLongRunning(e, string.Empty);
            }
        }

        private async void BuildMessageAsync()
        {
            try
            {
                throw new DotNetUsersGroupException();
            }
            catch (DotNetUsersGroupException e)
            {
                Message = OopsMessage;
                await LogExceptionLongRunningAsync(e, string.Empty);
            }
        }

        #endregion Private Methods
    }
}
