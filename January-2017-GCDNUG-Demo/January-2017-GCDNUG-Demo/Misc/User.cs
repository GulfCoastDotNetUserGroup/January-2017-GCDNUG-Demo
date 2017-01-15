using System;

namespace January_2017_GCDNUG_Demo.Misc
{
    public class User
    {
        #region Properties

        public string Name { get; set; }

        public Guid UserGuid { get; set; } = Guid.NewGuid();

        public string Species { get; } = "Human";

        #endregion Properties

        #region Constructors

        public User(string name)
        {
            Name = name;
        }

        #endregion Constructors
    }
}
