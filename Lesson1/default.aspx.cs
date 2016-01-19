using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lesson1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Label1.Text += "Request.UserHostAddress<br />";
            //Label1.Text += Request.UserHostAddress + "<br />";
            //Label1.Text += "Request.HttpMethod<br />";
            //Label1.Text += Request.HttpMethod + "<br />";
            //Label1.Text += "Request.Headers<br />";
            //foreach (string k in Request.Headers.AllKeys)
            //{
            //    Label1.Text += k + ": " + Request.Headers[k] + "<br />";
            //}
            ////Label1.Text += Request.Headers;
            //Label1.Text += Server.MachineName;
            //Label1.Text += Server.MapPath("~/default.aspx");
            //if (!IsPostBack)
            //{
            //    Button1.Text = "0";
            //    Session["number"] = 0;
            //    ViewState["number"] = 0;
            //}
            //else
            //{
            //    int i = (int)ViewState["number"];
            //    i++;
            //    Button1.Text = i.ToString();
            //    Session["number"] = i;
            //    ViewState["number"] = i;
            //}
            Label1.Text = "";
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Configuration config = WebConfigurationManager.OpenWebConfiguration(Request.ApplicationPath);

            //MyConfig section = (MyConfig)config.GetSection("MySection");
            //section.param2 = "bla-bla-bla2";
            //section.param1 = "bla-bla-bla1";
            //Label1.Text = section.param1;
            
           // Session.Abandon();
            int num;
            if (Int32.TryParse(TextBox1.Text, out num))
            {
                Label1.Text = (num * num).ToString();
            }
            else
            {
                Label1.Text = "Ввел какую то фигную";
            }
       
            


        }
    }
}