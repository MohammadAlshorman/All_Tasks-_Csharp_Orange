using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK1
{
    public partial class HOME : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void signup_Click(object sender, EventArgs e)
        {
            Response.Redirect("regester.aspx");
        }

        protected void signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}