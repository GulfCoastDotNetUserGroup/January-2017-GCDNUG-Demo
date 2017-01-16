using System;
using January_2017_GCDNUG_Demo.Interfaces;

namespace January_2017_GCDNUG_Demo.Demos
{
    public abstract class AbstractDemo : IMessageBuilder
    {
        public string Input { get; set; }
        public string Message { get; set; }

        public string GetMessage()
        {
            return GetMessageInternal();
        }

        public virtual string GetMessageInternal()
        {
            throw new NotImplementedException();
        }
    }
}
