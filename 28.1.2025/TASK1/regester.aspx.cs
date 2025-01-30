using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TASK1
{
    public partial class regester : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUp_Click(object sender, EventArgs e)
        {
            string Name = name.Text;
            string Email = email.Text;
            string Password = password.Text;
            string Repass = repass.Text;
            string userGender = Male.Checked ? "Male" :"Female";
            string userDob = dob.Text;

            if (Password == Repass && Name != "" && Email != "" && Password != "" && Repass != "")
            {
                string[] inputText = { Name,  Email, Password , userGender, userDob };
                string content = string.Join(",", inputText);
                string filePath = Server.MapPath("users.txt");

                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, content + "\n");
                    Response.Redirect("login.aspx");
                }
                else
                {
                    File.WriteAllText(filePath, content + Environment.NewLine);

                }
            }
            else if (Password != Repass)
            {
                result.Text = "password not match";
            }
            else
            {
                result.Text = "fields are requierd ";
            }
        }
    }
}