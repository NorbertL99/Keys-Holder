using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeysHolder.Classes
{
    class KeysObjects
    {
        /// <summary>
        /// Variables
        /// </summary>
        public string platform { get; private set; }
        public string login { get; private set; }
        public string password { get; private set; }
        public string description { get; private set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        /// <param name="platform">Store info about platform</param>
        /// <param name="login">Store info about login</param>
        /// <param name="password">Store info about password</param>
        /// <param name="description">Store info about description</param>
        public KeysObjects(string platform, string login, string password, string description)
        {
            this.platform = platform;
            this.login = login;
            this.password = password;
            this.description = description;
        }
    }
}
