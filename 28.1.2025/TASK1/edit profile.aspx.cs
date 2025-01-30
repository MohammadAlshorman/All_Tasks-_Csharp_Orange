using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;

namespace TASK1
{
    public partial class edit_profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                load();
            }
        }

        protected void cancel_click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }

        protected void saveCanghes_Click(object sender, EventArgs e)
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
                        user[0] = name.Text;
                        user[1] = email.Text;
                        user[3] = gender.SelectedValue;
                        user[4] = dob.Text;
                        Session["UserEmail"] = email.Text;
                        content[i] = $"{user[0]},{user[1]},{user[2]},{user[3]},{user[4]}";
                        
                        Response.Write("<script>alert('information changed!');</script>");
                       
                        break;
                    }
                }
                File.WriteAllLines(filePath, content);
            }
            Response.Redirect("profile.aspx");
        }
        private void load()
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
                        name.Text = user[0];
                        email.Text = user[1];
                        gender.SelectedValue = user[3];
                        dob.Text = user[4];
                    }
                }
            }
        }
    }
}