<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userDash.aspx.cs" Inherits="TASK1.userDash" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="contsiner">
                <h1 class="text-center">Powers Of Students</h1>
                <div class="row d-flex justify-content-center">
                    <div class="card" style="width: 18rem;">
                        <img src="book.jpg" class="card-img-top w-100" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title">Card title</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button CssClass="btn btn-primary" ID="goBook" runat="server" Text="see all books" OnClick="goBook_Click" />
                        </div>
                    </div>

                    <div class="card" style="width: 18rem;">
                        <img src="meeting.jpg" class="card-img-top w-100" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title">Card title</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button CssClass="btn btn-primary" ID="goMeeting" runat="server" Text="see all Meeting rooms" OnClick="goMeeting_Click" />

                        </div>
                    </div>

                    <div class="card" style="width: 18rem;">
                        <img src="meeting.jpg" class="card-img-top w-100" alt="..." />
                        <div class="card-body">
                            <h5 class="card-title">Card title</h5>
                            <p class="card-text">Some quick example text to build on the card title and make up the bulk of the card's content.</p>
                            <asp:Button CssClass="btn btn-primary" ID="profile" runat="server" Text="profile" OnClick="profile_Click" />

                        </div>
                    </div>
                </div>

            </div>
        </div>
    </form>
</body>
</html>
