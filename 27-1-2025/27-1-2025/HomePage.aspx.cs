using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _27_1_2025
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Signin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }

        protected void SignUp_Click(object sender, EventArgs e)
        {

            Response.Redirect("signup.aspx");
        }
    }
}