using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_Click(object sender, EventArgs e)
        {

        }

        protected void login_Click1(object sender, EventArgs e)
        {
            string useremail = email.Text;
            string userpassword = password.Text;


            if (useremail == "")
            {
                lblmsg.Text = "Email is required";
                lblmsg.Visible = true;
            }
            string file = Server.MapPath("UserData.txt");

            string[] users = File.ReadAllLines(file);
            foreach (string line in users) {

                string[] UserData = line.Split(' ');
                if (UserData[1] == useremail && UserData[2]==userpassword) {
                    Response.Redirect("UserDashboard.aspx");
                    return;
                }
                if (useremail == "Admin@gmail.com" && userpassword == "000") {
                    Response.Redirect("AdminDashboard.aspx");
                        }

            
            }

            lblmsg.Text = "Invalid Email or Password";
            lblmsg.Visible = true;


        }
    }
}