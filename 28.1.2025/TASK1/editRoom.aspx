<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editRoom.aspx.cs" Inherits="TASK1.editRoom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous"/>
    
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">#</th>
                        <th scope="col">Room name</th>
                        <th scope="col">location</th>
                        <th scope="col">capacity</th>
                    </tr>
                </thead>
                <tbody id="TableBody" runat="server">
                </tbody>
            </table>

            <div class="container bg-primary d-flex flex-column align-items-center justify-content-center w-50 mt-5 p-5">
                <h1>Search by ID</h1>
                <label>room id:</label>
                <asp:TextBox ID="RoomId" runat="server"></asp:TextBox>
                <asp:Button CssClass="btn btn-light mt-5" ID="serchBtn" runat="server" Text="search" onClick="serchBtn_Click"/>
                <asp:Label ID="searchRes" runat="server">Result</asp:Label>
            </div>

            <div class="container bg-primary d-flex flex-column align-items-center justify-content-center w-50 mt-5 p-5">
                
                <br />
                <br />
                <label>room name:</label>
                <asp:TextBox ID="roomName" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>room location:</label>
                <asp:TextBox ID="roomLoc" runat="server"></asp:TextBox>
                <br />
                <br />
                <label>room capacity:</label>
                <asp:TextBox ID="roomCap" runat="server"></asp:TextBox>
                <br />
                <br />
                <asp:Button CssClass="btn btn-light" ID="edit" runat="server" Text="edit book" OnClick="edit_Click" />
                <asp:Label ID="res" runat="server" Visible="false"></asp:Label>

            </div>
        </div>
    </form>
</body>
</html>
