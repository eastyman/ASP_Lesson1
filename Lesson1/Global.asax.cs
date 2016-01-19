using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.IO;

namespace Lesson1
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            string path = Server.MapPath("~log.txt");
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(time);
            }

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToString();
            string path = Server.MapPath("~log.txt");
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine(time);
            }

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}