using System;
using System.Text;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;
using January_2017_GCDNUG_Demo.Helpers;

using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    class ExceptionFiltersDemo : AbstractDemo
    {
        #region Properties

        public string Name { get; set; }

        public User User { get; set; }

        private string Message { get; set; }

        #endregion Properties

        #region Constructors

        public ExceptionFiltersDemo()
        {
            Name = null;
            User = null;
        }

        public ExceptionFiltersDemo(string name)
        {
            Name = name;
            User = !string.IsNullOrEmpty(name) 
                ? new User(Name) 
                : new User();
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.Append($"WITHOUT EXCEPTION FILTERS{DemoConstants.DoubleSpace}");

            ProcessMessageWithoutExceptionFilters();
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace + Environment.NewLine);

            sb.Append($"WITH EXCEPTION FILTERS{DemoConstants.DoubleSpace}");

            ProcessMessageWithExceptionFilters();
            sb.Append(Message);

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private void ProcessMessageWithoutExceptionFilters()
        {
            try
            {
                Message = $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}";

                if (User == null) throw new DotNetUserGroupException();
                if (string.IsNullOrEmpty(User.Name)) throw new DotNetUserGroupException();
                if (User.Name.Split(' ').Length < 2) throw new DotNetUserGroupException();

                Message += $"{DemoConstants.Hello}{User.Name}";
            }
            catch (DotNetUserGroupException e)
            {
                LogException(e, "EXCEPTION");
                Message += DemoConstants.OopsMessage;
            }
        }

        private void ProcessMessageWithExceptionFilters()
        {
            try
            {
                Message = $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}";

                if (User == null) throw new DotNetUserGroupException();
                if (string.IsNullOrEmpty(User.Name)) throw new DotNetUserGroupException();
                if (User.Name.Split(' ').Length < 2) throw new DotNetUserGroupException();

                Message += $"{DemoConstants.Hello}{User.Name}";
            }
            catch (DotNetUserGroupException e) when (User == null)
            {
                Message += DemoConstants.OopsMessage;
                WriteToImmediateAttentionLog(e, "Something terrible has happened! This application is doomed!");                              
            }
            catch (DotNetUserGroupException e) when (string.IsNullOrEmpty(User.Name))
            {
                Message += "Please enter a name if you would like your message processed.";
                WriteToTicketLog(e, "User did not provide a name");                
            }
            catch (DotNetUserGroupException e) when (User.Name.Split(' ').Length < 2)
            {
                Message += "You have only entered your first name. We cannot process your message correctly without your full name.";
                WriteToMoreImportantThingsToWorryAboutLog(e, "User only provided first name");               
            }
            catch (DotNetUserGroupException)
            {
                Message = "Run and don't look back!";
            }
        }

        #endregion Private Methods
    }
}
