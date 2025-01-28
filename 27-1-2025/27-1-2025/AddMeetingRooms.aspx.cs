using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Reflection.Emit;


namespace _27_1_2025
{
    public partial class AddMeetingsRoom : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {

            string roomid = id.Text;
            string roomname = name.Text;
            string roomloc = loc.Text;
            string roomcap = cap.Text;

            string roomsData = $"{roomid} {roomname} {roomloc} {roomcap}";

            string file = Server.MapPath("RoomsData.txt");


            if (roomid == "" || roomname == "" || roomloc == "" || roomcap == "")
            {
                lblmsg.Text = "Room Inforamtion are required";
                lblmsg.Visible = true;
            }
            else
            {


                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                File.AppendAllText(file, roomsData + Environment.NewLine);

                //using (StreamWriter sw = new StreamWriter(file, true)) //true = AppendAllText // False = WriteAllTExt
                //{
                //    sw.WriteLine(userdata);
                //}

                //using (StreamWriter sw = File.CreateText(file))
                //{
                //    sw.WriteLine(userdata);
                //}


                lblmsg.Text = "The Room has been added";
                lblmsg.Visible = true;




            }
        }
    }
}