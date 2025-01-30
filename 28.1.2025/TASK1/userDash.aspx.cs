using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK1
{
    public partial class userDash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       

        protected void goMeeting_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewRooms.aspx");
        }

        protected void goBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewBooks.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
    }
}