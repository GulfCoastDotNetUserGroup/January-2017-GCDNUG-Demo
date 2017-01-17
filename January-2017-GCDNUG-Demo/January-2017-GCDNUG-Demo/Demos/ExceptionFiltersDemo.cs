using System.Text;
using January_2017_GCDNUG_Demo.Misc;
using January_2017_GCDNUG_Demo.Helpers;
using static January_2017_GCDNUG_Demo.Helpers.ExceptionHelper;
using static System.Reflection.MethodBase;
using static System.Environment;
using static January_2017_GCDNUG_Demo.Misc.DemoConstants;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class ExceptionFiltersDemo : AbstractDemo
    {
        #region Properties

        public User User { get; set; }

        #endregion Properties

        #region Constructors

        public ExceptionFiltersDemo()
        {
            Input = null;
            User = null;
        }

        public ExceptionFiltersDemo(string name)
        {
            Input = name;
            User = !string.IsNullOrEmpty(name) 
                ? new User(Input) 
                : new User();
        }

        #endregion Constructors

        #region Public Methods

        public override string GetMessageInternal()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"WITHOUT EXCEPTION FILTERS{NewLine}");

            ProcessMessageWithoutExceptionFilters();
            sb.Append(Message);
            sb.AppendLine(DoubleSpace);

            sb.AppendLine($"WITH EXCEPTION FILTERS{NewLine}");

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
                Message = $"{GetCurrentMethod().MethodSignature()}{NewLine}";

                if (User == null) throw new DotNetUsersGroupException();
                if (string.IsNullOrEmpty(User.Name)) throw new DotNetUsersGroupException();
                if (User.Name.Split(' ').Length < 2) throw new DotNetUsersGroupException();

                Message += $"{Hello}{User.Name}";
            }
            catch (DotNetUsersGroupException e)
            {
                LogException(e, "EXCEPTION");
                Message += OopsMessage;
            }
        }

        private void ProcessMessageWithExceptionFilters()
        {
            try
            {
                Message = $"{GetCurrentMethod().MethodSignature()}{NewLine}";

                if (User == null) throw new DotNetUsersGroupException();
                if (string.IsNullOrEmpty(User.Name)) throw new DotNetUsersGroupException();
                if (User.Name.Split(' ').Length < 2) throw new DotNetUsersGroupException();

                Message += $"{Hello}{User.Name}";
            }
            catch (DotNetUsersGroupException e) when (User == null)
            {
                Message += OopsMessage;
                WriteToImmediateAttentionLog(e, "Something terrible has happened! This application is doomed!");                              
            }
            catch (DotNetUsersGroupException e) when (string.IsNullOrEmpty(User.Name))
            {
                Message += "Please enter a name if you would like your message processed.";
                WriteToTicketLog(e, "User did not provide a name");                
            }
            catch (DotNetUsersGroupException e) when (User.Name.Split(' ').Length < 2)
            {
                Message += "You have only entered your first name. We cannot process your message correctly without your full name.";
                WriteToMoreImportantThingsToWorryAboutLog(e, "User only provided first name");               
            }
            catch (DotNetUsersGroupException)
            {
                Message = "Run and don't look back!";
            }
        }

        #endregion Private Methods
    }
}
