using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;
using System.Xml.Linq;

namespace TASK1
{
    public partial class editRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBookData();
            }
            
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("rooms.txt");
            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);

                for (int i = 0; i < fileContent.Length; i++)
                {
                    string[] room = fileContent[i].Split(',');

                    if (room[0] == RoomId.Text)
                    {

                        room[1] = roomName.Text;
                        room[2] = roomLoc.Text;
                        room[3] = roomCap.Text;
                        fileContent[i] = $"{room[0]} , {room[1]} , {room[2]} , {room[3]} ";
                        break;
                    }

                }

                File.WriteAllLines(filePath, fileContent);
                LoadBookData();
            }
        }

        protected void serchBtn_Click(object sender, EventArgs e)
        {



            string filePath = Server.MapPath("rooms.txt");

            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);
                foreach (var line in fileContent)
                {
                    string[] room = line.Split(',');
                    if (room[0] == RoomId.Text)
                    {
                        searchRes.Text += $":    {line} ";
                        roomName.Text = room[1];
                        roomLoc.Text = room[2];
                        roomCap.Text = room[3];

                        return;
                    }

                }
            }
        }
        private void LoadBookData()
        {
            string filePath = Server.MapPath("rooms.txt");
            if (File.Exists(filePath))
            {
                string[] fileContent = File.ReadAllLines(filePath);
                StringBuilder tableRows = new StringBuilder();

                foreach (var line in fileContent)
                {
                    string[] columns = line.Split(',');
                    if (columns.Length == 4)
                    {
                        tableRows.Append("<tr>");
                        tableRows.AppendFormat("<td>{0}</td>", columns[0]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[1]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[2]);
                        tableRows.AppendFormat("<td>{0}</td>", columns[3]);
                        tableRows.Append("</tr>");
                    }
                }

                TableBody.InnerHtml = tableRows.ToString();
            }
            else
            {
                TableBody.InnerHtml = "<tr><td colspan='4'>File not found.</td></tr>";
            }
        }
    }
}