using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace January2017GCDNUG
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
