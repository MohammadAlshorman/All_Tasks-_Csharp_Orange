using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TASK1
{
    public partial class addRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string Name = roomName.Text;
            string ID = roomId.Text;
            string loc = roomLoc.Text;
            string cap = capacity.Text;

            if (ID != "" && Name != "" && loc != "" && cap != "")
            {
                string[] inputText = { ID, Name, loc, cap };
                string content = string.Join(",", inputText);
                string filePath = Server.MapPath("rooms.txt");

                if (File.Exists(filePath))
                {
                    File.AppendAllText(filePath, content + "\n");

                }
                else
                {
                    File.WriteAllText(filePath, content + Environment.NewLine);

                }
                res.Text = "room added ";
                res.Visible = true;
            }
            else
            {
                res.Text = "all fields are required";
            }
        }
    }
}