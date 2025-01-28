using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Text;

namespace _27_1_2025
{
    public partial class AllRooms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            string file = Server.MapPath("RoomsData.txt");
            string[] rooms = File.ReadAllLines(file);
            StringBuilder row = new StringBuilder();

            foreach (string room in rooms)
            {

                string[] Roomat = room.Split(' ');

                row.Append("<tr>");
                row.Append($"<td> {Roomat[0]} </td> ");
                row.Append($"<td> {Roomat[1]} </td> ");
                row.Append($"<td> {Roomat[2]} </td> ");
                row.Append($"<td> {Roomat[3]} </td> ");
                row.Append("</tr>");

            }

            TableBody.InnerHtml = row.ToString();



        }
    }
}