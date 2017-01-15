using System;
using System.Text;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;

// Static usings
using static System.Reflection.MethodBase;


namespace January_2017_GCDNUG_Demo.Demos
{
    class NameOfDemo : IMessageBuilder
    {
        #region Properties

        public string Name { get; set; }

        public User User { get; set; }

        #endregion Properties

        #region Contructors

        public NameOfDemo(string name)
        {
            Name = name;
            User = new User(name);
        }

        #endregion Contructors

        #region Public Methods

        public string GetMessage()
        {
            return $"{GetUserDetailsWithLiteralStrings()}{DemoConstants.DoubleSpace}{GetUserDetailsWithNameOf()}";
        }

        #endregion Public Methods

        #region Private Methods

        private string GetUserDetailsWithLiteralStrings()
        {
            var sb = new StringBuilder();

            sb.Append($"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}");
            sb.Append($"Nmae = {User.Name}{Environment.NewLine}");
            sb.Append($"UsergUid = {User.UserGuid}{Environment.NewLine}");
            sb.Append($"Speceis = {User.Species}");

            return sb.ToString();
        }

        private string GetUserDetailsWithNameOf()
        {
            var sb = new StringBuilder();

            sb.Append($"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}");
            sb.Append($"{nameof(User.Name)} = {User.Name}{Environment.NewLine}");
            sb.Append($"{nameof(User.UserGuid)} = {User.UserGuid}{Environment.NewLine}");
            sb.Append($"{nameof(User.Species)} = {User.Species}");

            return sb.ToString();
        }

        #endregion Private Methods
    }
}
