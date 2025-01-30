<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reset.aspx.cs" Inherits="TASK1.reset" %>

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
            <div class="container p-5 rounded border mt-5 w-25">
                <h1 class="text-center"> Set A New Password</h1>
                <div class="mb-3">
                    <label for="newpass" class="form-label">New Password</label>
                    <asp:TextBox runat="server" ID="newPass" CssClass="form-control"></asp:TextBox>
                </div>
                <div class="mb-3">
                    <label for="email" class="form-label">Confirm password</label>
                    <asp:TextBox runat="server" ID="Confirm" CssClass="form-control"></asp:TextBox>
                </div>

                <div class="row justify-content-between">
                    <asp:Button ID="cancel" runat="server" class="col-4 btn btn-secondary " OnClick="cancel_Click" Text="Cancel"></asp:Button>
                    <asp:Button ID="saveCanghes" runat="server" class=" col-6 btn btn-warning  " OnClick="saveCanghes_Click" Text="Save Changes"></asp:Button>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
