using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Controle
{
    public static class CtrlLogin
    {
        private static String user = "admin";
        private static String pass = "1234";
        public static bool log = false;

        public static void Login(String u, String p)
        {
            if (u == user && p == pass)
            {
                log = true;
            }
        }

        public static String getUser()
        {
            return user;
        }
    }
}
