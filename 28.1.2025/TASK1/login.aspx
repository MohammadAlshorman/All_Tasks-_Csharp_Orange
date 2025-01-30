<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="TASK1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous" />
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
    <style>
        .divider:after,
        .divider:before {
            content: "";
            flex: 1;
            height: 1px;
            background: #eee;
        }

        .h-custom {
            height: calc(100% - 73px);
        }

        @media (max-width: 450px) {
            .h-custom {
                height: 100%;
            }
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100">
                <div class="container-fluid h-custom">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-md-9 col-lg-6 col-xl-5">
                            <img src="data:image/png;base64,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"
                                class="img-fluid" alt="Sample image"/>
                        </div>
                        <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">


                                <!-- Email input -->
                                <div  class="form-outline mb-4">
                                    
                                    <label class="form-label" for="form3Example3">Email address</label><br />
                                    <asp:TextBox ID="Email" runat="server" ></asp:TextBox>
                                </div>

                                <!-- Password input -->
                                <div class="form-outline mb-3">
                                      <label class="form-label" for="form3Example4">Password</label><br />
                                    <asp:TextBox ID="Password" runat="server" TextMode="Password" ></asp:TextBox>
                                   
                                  
                                </div>

                                <div class="d-flex justify-content-between align-items-center">
                                    <!-- Checkbox -->
                                    <div class="form-check mb-0">
                                        <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3" />
                                        <label class="form-check-label" for="form2Example3">
                                            Remember me
                                        </label>
                                    </div>
                                    <a href="#!" class="text-body">Forgot password?</a>
                                </div>

                                <div class="text-center text-lg-start mt-4 pt-2">
                                    <asp:Button CssClass="btn bg-primary" ID="log" Text ="Login" runat="server" OnClick="log_Click" />
                                    <asp:Button CssClass="btn bg-primary" ID="registr" Text ="registr" runat="server" OnClick="registr_Click" />
                                    
                                </div>

                           <asp:Label ID="result" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
                <div
                    class="d-flex flex-column flex-md-row text-center text-md-start justify-content-between py-4 px-4 px-xl-5 bg-primary">
                    <!-- Copyright -->
                    <div class="text-white mb-3 mb-md-0">
                        Copyright © 2020. All rights reserved.
                    </div>
                    <!-- Copyright -->

                    <!-- Right -->
                    <div>
                        <a href="#!" class="text-white me-4">
                            <i class="fab fa-facebook-f"></i>
                        </a>
                        <a href="#!" class="text-white me-4">
                            <i class="fab fa-twitter"></i>
                        </a>
                        <a href="#!" class="text-white me-4">
                            <i class="fab fa-google"></i>
                        </a>
                        <a href="#!" class="text-white">
                            <i class="fab fa-linkedin-in"></i>
                        </a>
                    </div>
                    <!-- Right -->
                </div>
            </section>
        </div>
    </form>
</body>
</html>
