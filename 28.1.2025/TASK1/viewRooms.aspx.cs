using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace TASK1
{
    public partial class viewRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string filePath = Server.MapPath("rooms.txt");
            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllLines(filePath);
                StringBuilder tableRows = new StringBuilder();

                foreach (var line in fileContent)
                {
                    var columns = line.Split(',');
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