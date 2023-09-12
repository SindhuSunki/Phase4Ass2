using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class UserAuthenticator
    {
        private Dictionary<string, string> userAccounts;

        public UserAuthenticator()
        {
            userAccounts = new Dictionary<string, string>();
        }

        public bool RegisterUser(string userName, string userPwd)
        {
            if (!userAccounts.ContainsKey(userName))
            {
                userAccounts[userName] = userPwd;
                return true;
            }
            return false;
        }

        public bool LoginUser(string userName, string userPwd)
        {
            if (userAccounts.ContainsKey(userName) && userAccounts[userName] == userPwd)
            {
                return true;
            }
            return false;
        }

        public bool ResetuserPwd(string userName, string newuserPwd)
        {
            if (userAccounts.ContainsKey(userName))
            {
                userAccounts[userName] = newuserPwd;
                return true;
            }
            return false;
        }
    }
}