using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning
{
    public partial class Server_control : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("You have logged in for the first time.");
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            Response.Write("Text Changed" + "<br/>");
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Button Clicked" + "<br/>");
        }

       
    }
}