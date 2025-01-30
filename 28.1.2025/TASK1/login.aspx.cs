using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.IO;

namespace TASK1
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void log_Click(object sender, EventArgs e)
        {
            if (Email.Text=="Admin@gmail.com" && Password.Text == "123")
            {
                Session["UserEmail"] = Email.Text;
                Response.Redirect("admindash.aspx");
            }
            else
            {

                string file = Server.MapPath("users.txt");

                string[] usersData = File.ReadAllLines(file);

                foreach (string user in usersData)
                {
                    string[] userData = user.Split(',');

                    if (Email.Text == userData[1] && Password.Text == userData[2])
                    {
                        result.Text = "login successfully";
                        result.Visible = true;
                        Session["UserEmail"] = Email.Text;
                        Response.Redirect("userdash.aspx");

                    }




                }

                result.Text = "Invalid username or password ";
                result.Visible = true;
            }

        }
        

        protected void registr_Click(object sender, EventArgs e)
        {
            Response.Redirect("regester.aspx");
        }
    }
}