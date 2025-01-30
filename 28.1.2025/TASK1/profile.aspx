<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="profile.aspx.cs" Inherits="TASK1.profile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .gradient-custom {
            /* fallback for old browsers */
            background: #f6d365;
            /* Chrome 10-25, Safari 5.1-6 */
            background: -webkit-linear-gradient(to right bottom, rgba(246, 211, 101, 1), rgba(253, 160, 133, 1));
            /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */
            background: linear-gradient(to right bottom, rgba(246, 211, 101, 1), rgba(253, 160, 133, 1))
        }
    </style>

    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div>

            <section class="vh-100" style="background-color: #f4f5f7;">
                <div class="container py-5 h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col col-lg-6 mb-4 mb-lg-0">
                            <div class="card mb-3" style="border-radius: .5rem;">
                                <div class="row g-0">
                                    <div class="col-md-4 gradient-custom text-center text-white"
                                        style="border-top-left-radius: .5rem; border-bottom-left-radius: .5rem;">
                                        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-chat/ava1-bg.webp"
                                            alt="Avatar" class="img-fluid my-5" style="width: 80px;" />
                                        <h5 id="name" runat="server"></h5>
                                        <i class="far fa-edit mb-5"></i>
                                    </div>
                                    <div class="col-md-8">
                                        <div class="card-body p-4">
                                            <h6>Information</h6>
                                            <hr class="mt-0 mb-4" />
                                            <div class="row pt-1">

                                                <div class="col-6 mb-3">
                                                    <h6>Gender</h6>
                                                    <p class="text-muted" id="gender" runat="server"></p>
                                                </div>
                                                <div class="col-6 mb-3">
                                                    <h6>Date Of birth</h6>
                                                    <p class="text-muted" id="DOB" runat="server"></p>
                                                </div>

                                            </div>
                                            <div class="row pt-1">
                                                <div class="col-12 mb-3">
                                                    <h6>Email</h6>
                                                    <p class="text-muted" id="email" runat="server"></p>
                                                </div>
                                            </div>

                                            <div class="d-flex justify-content-start">
                                                <asp:Button ID="edit" Text="Edit Profile" runat="server" OnClick="edit_Click" CssClass="btn btn-warning" />
                                                <asp:Button ID="reset" Text="reset password" runat="server" OnClick="reset_Click" CssClass="btn btn-warning" />

                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </section>

        </div>
    </form>
</body>
</html>
