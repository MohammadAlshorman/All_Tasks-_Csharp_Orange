using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class UserDashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goMeeting_Click(object sender, EventArgs e)
        {

            Response.Redirect("AllRooms.aspx");

        }

        protected void goBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("AllBooks.aspx");

        }
    }
}