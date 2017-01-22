using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Learning
{
    public partial class Click_program_without_viewstate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                click.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(click.Text) + 1;
            click.Text = count.ToString();
        }
    }
}