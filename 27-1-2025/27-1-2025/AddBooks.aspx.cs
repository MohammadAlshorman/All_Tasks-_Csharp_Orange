using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace _27_1_2025
{
    public partial class AddBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string bookid = id.Text;
            string bookname = name.Text;
            string booktype = type.Text;
            string booklevel = level.Text;

            string booksData = $"{bookid} {bookname} {booktype} {booklevel}";

            string file = Server.MapPath("BooksData.txt");


            if (bookid == "" || bookname=="" ||booktype=="" ||booklevel=="")
            {
                lblmsg.Text = "Book Inforamtion are required";
                lblmsg.Visible = true;
            }
            else
            {


                if (!File.Exists(file))
                {
                    File.Create(file);
                }

                File.AppendAllText(file, booksData + Environment.NewLine);

                //using (StreamWriter sw = new StreamWriter(file, true)) //true = AppendAllText // False = WriteAllTExt
                //{
                //    sw.WriteLine(userdata);
                //}

                //using (StreamWriter sw = File.CreateText(file))
                //{
                //    sw.WriteLine(userdata);
                //}


                lblmsg.Text = "The Book has been added";
                lblmsg.Visible = true;





            }
        }
    }
}