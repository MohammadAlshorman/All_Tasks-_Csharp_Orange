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
    public partial class reset : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveCanghes_Click(object sender, EventArgs e)
        {
            if (newPass.Text == Confirm.Text)
            {
                string filePath = Server.MapPath("users.txt");
                if (File.Exists(filePath))
                {
                    string[] content = File.ReadAllLines(filePath);
                    string userEmail = Session["UserEmail"].ToString();

                    for (int i = 0; i < content.Length; i++)
                    {
                        string[] user = content[i].Split(',');
                        if (user[1] == userEmail)
                        {
                            user[2] = newPass.Text; 
                            content[i] = $"{user[0]},{user[1]},{user[2]},{user[3]},{user[4]}";

                            Response.Write("<script>alert('information changed!');</script>");

                            break;
                        }
                    }
                    File.WriteAllLines(filePath, content);
                }
                Response.Redirect("profile.aspx");
            }

            else
            {
                Response.Write("<script>alert('Not match!');</script>");

            }

        }

        protected void cancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
    }
}