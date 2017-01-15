using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class AwaitInCatchBlockDemo : IMessageBuilder
    {
        public bool UseAwait { get; set; }
        public string Message { get; set; }

        public AwaitInCatchBlockDemo(bool useAwait)
        {
            UseAwait = useAwait;
        }

        public string GetMessage()
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
                await LogExceptionAsync(e, string.Empty);
            }
        }
    }
}
