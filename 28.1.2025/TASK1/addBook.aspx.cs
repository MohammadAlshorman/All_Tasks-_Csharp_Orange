using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Xml.Linq;
using System.Text;

namespace TASK1
{
    public partial class addBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void add_Click(object sender, EventArgs e)
        {
            string Name = bookName.Text;
            string ID = bookId.Text;
            string type = bookType.Text;
            string level = bookLevel.Text;


            if (ID != "" && Name != "" && type != "" && level != "")
            {

                string[] inputText = { ID, Name, type,level };
                string content = string.Join(",", inputText);
                string filePath = Server.MapPath("books.txt");

                if (File.Exists(filePath))
                {
                    var fileContent = File.ReadAllLines(filePath);
                    foreach (var line in fileContent)
                    {
                        var book = line.Split(',');
                        if (book[0] == ID)
                        {
                            res.Text = "book id is allrady in the table";
                            res.Visible = true;

                            return;
                        }
                       
                    }
                    File.AppendAllText(filePath, content + "\n");
                    
                }
                else
                {
                    File.WriteAllText(filePath, content + Environment.NewLine);

                }
                res.Text = "book added";
                res.Visible = true;
            }
            else
            {
                res.Text = "all fields are required";
            }
        }
    }
}