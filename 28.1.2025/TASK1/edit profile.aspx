<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit profile.aspx.cs" Inherits="TASK1.edit_profile" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container p-5 rounded border mt-5 w-25">
            <div class="mb-3">
                <label for="fullName" class="form-label">name</label>
                <asp:TextBox runat="server" ID="name" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="email" class="form-label">email</label>
                <asp:TextBox runat="server" ID="email" CssClass="form-control"></asp:TextBox>
            </div>
            <div class="mb-3">
                <label for="gender" class="form-label">gender</label>
                <asp:DropDownList ID="gender" runat="server" CssClass="form-control">
                    <asp:ListItem Value="Male">Male</asp:ListItem>
                    <asp:ListItem Value="Female">Female</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="d-flex flex-row align-items-center mb-4">
                <i class="fas fa-calendar-alt fa-lg me-3 fa-fw"></i>
                <div class="form-outline flex-fill mb-0">
                    <asp:Label Text="Date of Birth" runat="server"></asp:Label>
                    <asp:TextBox ID="dob" runat="server" TextMode="Date"></asp:TextBox>

                </div>
            </div>


            <div class="row justify-content-between">
                <asp:Button ID="cancel" runat="server" class="col-4 btn btn-secondary " OnClick="cancel_click" Text="Cancel"></asp:Button>
                <asp:Button ID="saveCanghes" runat="server" class=" col-6 btn btn-warning  " OnClick="saveCanghes_Click" Text="Save Changes"></asp:Button>
            </div>
        </div>
    </form>
</body>
</html>
