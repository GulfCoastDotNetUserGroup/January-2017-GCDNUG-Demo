using System;
using System.Text;
using System.Collections.Generic;
using January_2017_GCDNUG_Demo.Helpers;
using January_2017_GCDNUG_Demo.Interfaces;
using January_2017_GCDNUG_Demo.Misc;

// Static usings
using static System.Reflection.MethodBase;

namespace January_2017_GCDNUG_Demo.Demos
{
    public class NameOfDemo : IMessageBuilder
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
            return $"{GetUserDetailsWithLiteralStrings()}{Environment.NewLine}{GetUserDetailsWithNameOf()}";
        }

        #endregion Public Methods

        #region Private Methods

        private string GetUserDetailsWithLiteralStrings()
        {
            // Old dictionary initializer
            var userPropertyDictionary = new Dictionary<string, string>()
            {
                { "Nmae", User.Name },
                { "usergUid", User.UserGuid.ToString() },
                { "Speceis", User.Species }
            };

            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{GetMessageFromDictionary(userPropertyDictionary)}";
        }

        private string GetUserDetailsWithNameOf()
        {
            // New dictionary initializer
            var userPropertyDictionary = new Dictionary<string, string>()
            {
                // nameof instead of literal strings
                [nameof(User.Name)] = User.Name,
                [nameof(User.UserGuid)] = User.UserGuid.ToString(),
                [nameof(User.Species)] = User.Species
            };

            return $"{GetCurrentMethod().MethodSignature()}{Environment.NewLine}{GetMessageFromDictionary(userPropertyDictionary)}";
        }

        private string GetMessageFromDictionary(Dictionary<string, string> dict)
        {
            var sb = new StringBuilder();

            foreach (var pair in dict)
            {
                sb.Append($"{pair.Key} = {pair.Value}{Environment.NewLine}");
            }

            return sb.ToString();
        }

        #endregion Private Methods 
    }
}
