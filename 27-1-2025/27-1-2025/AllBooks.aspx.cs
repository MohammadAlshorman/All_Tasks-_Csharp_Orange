//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.IO;
//using System.Text;
//namespace _27_1_2025
//{
//    public partial class AllBooks : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {


//            string file = Server.MapPath("BooksData.txt");
//            string[] books = File.ReadAllLines(file);
//            StringBuilder row = new StringBuilder();

//            foreach (string book in books)
//            {

//                string[] Library = book.Split(' ');

//                row.Append("<tr>");
//                row.Append($"<td> {Library[0]} </td> ");
//                row.Append($"<td> {Library[1]} </td> ");
//                row.Append($"<td> {Library[2]} </td> ");
//                row.Append($"<td> {Library[3]} </td> ");
//                row.Append("</tr>");

//            }

//            TableBody.InnerHtml = row.ToString();




//        }
//    }
//}




using System;
using System.IO;
using System.Text;

namespace _27_1_2025
{
    public partial class AllBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadBooks();
            }
        }

        private void LoadBooks()
        {
            string file = Server.MapPath("BooksData.txt");
            if (File.Exists(file))
            {
                string[] books = File.ReadAllLines(file);
                StringBuilder row = new StringBuilder();

                foreach (string book in books)
                {
                    string[] Library = book.Split(' ');

                    row.Append("<tr>");
                    row.Append($"<td> {Library[0]} </td> ");
                    row.Append($"<td> {Library[1]} </td> ");
                    row.Append($"<td> {Library[2]} </td> ");
                    row.Append($"<td> {Library[3]} </td> ");
                    row.Append("</tr>");
                }

                TableBody.InnerHtml = row.ToString();
            }
        }

        protected void edit_Click(object sender, EventArgs e)
        {
            string bookIdInput = bookId.Text;
            string newBookName = bookName.Text;
            string newBookType = bookType.Text;
            string newBookLevel = bookLevel.Text;

            string filePath = Server.MapPath("BooksData.txt");

            if (File.Exists(filePath))
            {
                var fileContent = File.ReadAllLines(filePath);

                bool bookFound = false;
                for (int i = 0; i < fileContent.Length; i++)
                {
                    string[] book = fileContent[i].Split(' ');
                    if (book[0] == bookIdInput)
                    {
                        fileContent[i] = $"{book[0]} {newBookName} {newBookType} {newBookLevel}";
                        bookFound = true;
                        break;
                    }
                }

                if (bookFound)
                {
                    File.WriteAllLines(filePath, fileContent);
                    res.Text = "Book updated successfully!";
                    res.Visible = true;
                    LoadBooks(); // Reload the updated books into the table
                }
                else
                {
                    res.Text = "Book ID not found!";
                    res.Visible = true;
                }
            }
            else
            {
                res.Text = "Books file does not exist!";
                res.Visible = true;
            }
        }
    }
}
