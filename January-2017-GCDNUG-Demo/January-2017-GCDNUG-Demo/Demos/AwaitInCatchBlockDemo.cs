using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;
using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class AwaitInCatchBlockDemo : AbstractDemo
    {
        #region Properties

        public bool UseAwait { get; set; }
        private string Message { get; set; }

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
                throw new DotNetUserGroupException();
            }
            catch (DotNetUserGroupException e)
            {
                Message = DemoConstants.OopsMessage;
                LogExceptionLongRunning(e, string.Empty);
            }
        }

        private async void BuildMessageAsync()
        {
            try
            {
                throw new DotNetUserGroupException();
            }
            catch (DotNetUserGroupException e)
            {
                Message = DemoConstants.OopsMessage;
                await LogExceptionLongRunningAsync(e, string.Empty);
            }
        }

        #endregion Private Methods
    }
}
