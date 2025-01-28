using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register_Click(object sender, EventArgs e)


        {
            string username = name.Text;
            string useremail = email.Text;
            string userpassword = password.Text;
            string confirmpass = ConfirmPassword.Text;

            string userdata = $"{username} {useremail} {userpassword} {confirmpass}";

            string file = Server.MapPath("UserData.txt");




            if (username == "")
            {
                lblmsg.Text = "user name is required";
                lblmsg.Visible = true;
            }
            else
            {

                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                File.AppendAllText(file, userdata + Environment.NewLine);

                //using (StreamWriter sw = new StreamWriter(file, true)) //true = AppendAllText // False = WriteAllTExt
                //{
                //    sw.WriteLine(userdata);
                //}

                //using (StreamWriter sw = File.CreateText(file))
                //{
                //    sw.WriteLine(userdata);
                //}

                if (userpassword == confirmpass)
                {
                    lblmsg.Text = "Registration Successfull";
                    lblmsg.Visible = true;

                    Response.Redirect("login.aspx");
                }
                else
                {
                    lblmsg.Text = "The Password doesn't match";
                    lblmsg.Visible = true;
                }


            }

        }
    }
}