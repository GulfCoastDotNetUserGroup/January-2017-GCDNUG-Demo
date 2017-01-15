using System;
using System.Text;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;
using January_2017_GCDNUG_Demo.Helpers;

using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    class ExceptionFiltersDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        public string Message { get; set; }

        #endregion Properties

        #region Constructors

        public ExceptionFiltersDemo(string name)
        {
            Name = name;
        }

        #endregion Constructors

        #region Public Methods

        public string GetMessage()
        {
            var sb = new StringBuilder();

            sb.Append($"WITHOUT EXCEPTION FILTERS{DemoConstants.DoubleSpace}");

            ProcessMessageWithoutExceptionFilters(new User(Name));
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace);

            ProcessMessageWithoutExceptionFilters(null);
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace + Environment.NewLine);

            sb.Append($"WITH EXCEPTION FILTERS{DemoConstants.DoubleSpace}");

            ProcessMessageWithExceptionFilters(new User(Name));
            sb.Append(Message);
            sb.Append(DemoConstants.DoubleSpace);

            ProcessMessageWithExceptionFilters(null);
            sb.Append(Message);

            return sb.ToString();
        }

        #endregion Public Methods

        #region Private Methods

        private void ProcessMessageWithoutExceptionFilters(User user)
        {
            try
            {
                if (user == null) throw new DotNetUserGroupException();
                if (string.IsNullOrEmpty(user.Name)) throw new DotNetUserGroupException();
                if (user.Name.Split(' ').Length < 2) throw new DotNetUserGroupException();

                Message = $"{DemoConstants.Hello}{user.Name}";
            }
            catch (DotNetUserGroupException e)
            {
                LogException(e, "EXCEPTION");
                Message = DemoConstants.OopsMessage;
            }
            finally
            {
                Message += $" {GetCurrentMethod().MethodSignature()}";
            }
        }

        private void ProcessMessageWithExceptionFilters(User user)
        {
            try
            {
                if (user == null) throw new DotNetUserGroupException();
                if (string.IsNullOrEmpty(user.Name)) throw new DotNetUserGroupException();
                if (user.Name.Split(' ').Length < 2) throw new DotNetUserGroupException();

                Message = $"{DemoConstants.Hello}{user.Name}";
            }
            catch (DotNetUserGroupException e) when (user == null)
            {
                WriteToImmediateAttentionLog(e, "Something terrible has happened! This application is doomed!");
                Message = DemoConstants.OopsMessage;               
            }
            catch (DotNetUserGroupException e) when (string.IsNullOrEmpty(user.Name))
            {
                WriteToTicketLog(e, "User did not provide a name");
                Message = "Please enter a name if you would like your message processed.";
            }
            catch (DotNetUserGroupException e) when (user.Name.Split(' ').Length < 2)
            {
                WriteToMoreImportantThingsToWorryAboutLog(e, "User did not provide full name");
                Message = "I'm sorry but we cannot process your message correctly if you don't provide your full name.";
            }
            catch (DotNetUserGroupException)
            {
                Message = "Run and don't look back!";
            }
            finally
            {
                Message += $" {GetCurrentMethod().MethodSignature()}";
            }
        }

        #endregion Private Methods
    }
}
