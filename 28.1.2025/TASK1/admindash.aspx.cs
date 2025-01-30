using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TASK1
{
    public partial class admindash : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("addBook.aspx");
           
        }

        protected void addRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("addRoom.aspx");
        }

        protected void editBook_Click(object sender, EventArgs e)
        {
            Response.Redirect("editbook.aspx");
        }

        protected void editRoom_Click(object sender, EventArgs e)
        {
            Response.Redirect("editRoom.aspx");
        }

        protected void profile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
    }
}