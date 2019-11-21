using System;
using System.Collections.Generic;
using System.Text;

namespace VEGA_JSON
{
    class Auth
    {
        string cmd;
        string login;
        string password;

        public Auth(string cmd, string login, string password)
        {
            this.cmd = cmd;
            this.login = login;
            this.password = password;
        }
    }

    class CMD
    {
        string cmd;

        public CMD(string cmd)
        {
            this.cmd = cmd;
        }
    }
}