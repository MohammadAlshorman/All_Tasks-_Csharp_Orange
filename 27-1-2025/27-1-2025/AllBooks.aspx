<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AllBooks.aspx.cs" Inherits="_27_1_2025.AllBooks" %>

<!DOCTYPE html>
<html>
<head>
    <title>All Books</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="container mt-5">
            <h2 class="text-center">Library Books</h2>




            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Book Name</th>
                        <th scope="col">Type</th>
                        <th scope="col">Level</th>
                    </tr>
                </thead>
                <tbody id="TableBody" runat="server">
                </tbody>
            </table>



            <div class="container bg-primary d-flex flex-column align-items-center justify-content-center w-50 mt-5 p-5">
                <label>Book ID:</label>
                <asp:TextBox ID="bookId" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <label>Book Name:</label>
                <asp:TextBox ID="bookName" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <label>Book Type:</label>
                <asp:TextBox ID="bookType" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <label>Book Level:</label>
                <asp:TextBox ID="bookLevel" runat="server" CssClass="form-control"></asp:TextBox>
                <br />
                <asp:Button CssClass="btn btn-light" ID="edit" runat="server" Text="Edit Book" OnClick="edit_Click" />
                <asp:Label ID="res" runat="server" Visible="false" CssClass="text-white mt-3"></asp:Label>
            </div>
        </div>
    </form>
</body>
</html>
