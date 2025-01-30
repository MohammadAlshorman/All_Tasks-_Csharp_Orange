using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.SessionState;

namespace TASK1
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("users.txt");
            if (File.Exists(filePath))
            {
                string[] content = File.ReadAllLines(filePath);
                string userEmail = Session["UserEmail"].ToString();

                foreach (string line in content)
                {
                    string[] user = line.Split(',');
                    if (user[1] == userEmail)
                    {
                        name.InnerText= user[0];
                        email.InnerText= user[1];
                        gender.InnerText= user[3];
                        DOB.InnerText = user[4];
                    }
                }
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("edit profile.aspx");
        }

        protected void reset_Click(object sender, EventArgs e)
        {
            Response.Redirect("reset.aspx");
        }
    }
}