using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning
{
    public partial class Click_Program : System.Web.UI.Page
    {
        int count = 1;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txt1.Text = "0";
            }
        }

        protected void clicks_Click(object sender, EventArgs e)
        {
            if (ViewState["clicks"] !=null)
            { 
                count = (int)ViewState["clicks"] + 1;
            }
            txt1.Text = count.ToString();
            ViewState["clicks"] = count;

            int pls = count + count;
            plus.Text = pls.ToString();

            int sqr = count * count;
            square.Text = sqr.ToString();
        }
    }
}