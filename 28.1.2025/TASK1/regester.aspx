<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="regester.aspx.cs" Inherits="TASK1.regester" %>

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
            <section class="vh-100" style="background-color: #eee;">
                <div class="container h-100">
                    <div class="row d-flex justify-content-center align-items-center h-100">
                        <div class="col-lg-12 col-xl-11">
                            <div class="card text-black" style="border-radius: 25px;">
                                <div class="card-body p-md-5">
                                    <div class="row justify-content-center">
                                        <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">

                                            <p class="text-center h1 fw-bold mb-5 mx-1 mx-md-4 mt-4">Sign up</p>

                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                     <label class="form-label" for="form3Example1c">Your Name</label><br />
                                                    <asp:TextBox ID="name" runat="server"></asp:TextBox>
                                                   
                                                </div>
                                            </div>



                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                       <label class="form-label" for="form3Example3c">Your Email</label><br />
                                                    <asp:TextBox ID="email" runat="server"></asp:TextBox>
                                                 
                                                </div>
                                            </div>
                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                      <asp:Label Text="Gender" runat="server"></asp:Label><br />
                                                    <asp:RadioButton ID="Male" GroupName="Gender" Text="Male" runat="server" /><br />
                                                    <asp:RadioButton ID="Female" GroupName="Gender" Text="Female" runat="server" /><br />
                                                  
                                                </div>
                                            </div>

                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-calendar-alt fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                      <asp:Label Text="Date of Birth" runat="server"></asp:Label><br />
                                                    <asp:TextBox ID="dob" runat="server" TextMode="Date"></asp:TextBox>
                                                  
                                                </div>
                                            </div>


                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                      <label class="form-label" for="form3Example4c">Password</label><br />
                                                    <asp:TextBox ID="password" runat="server" TextMode="Password" ></asp:TextBox>
                                                  
                                                </div>
                                            </div>

                                            <div class="d-flex flex-row align-items-center mb-4">
                                                <i class="fas fa-key fa-lg me-3 fa-fw"></i>
                                                <div class="form-outline flex-fill mb-0">
                                                     <label class="form-label" for="form3Example4cd"  >Repeat your password</label><br />
                                                    <asp:TextBox ID="repass" runat="server" TextMode="Password"></asp:TextBox>
                                                   
                                                </div>
                                            </div>

                                            <div class="form-check d-flex justify-content-center mb-5">
                                                <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3c" />
                                                <label class="form-check-label" for="form2Example3">
                                                    I agree all statements in <a href="#!">Terms of service</a>
                                                </label>
                                            </div>

                                            <div class="d-flex justify-content-center mx-4 mb-3 mb-lg-4">
                                                <asp:Button CssClass="btn btn-primary" ID="SignUp" runat="server" Text="Sign Up" OnClick="SignUp_Click" />
                                            </div>




                                        </div>
                                        <div class="col-md-10 col-lg-6 col-xl-7 d-flex align-items-center order-1 order-lg-2">

                                            <img src="https://media.istockphoto.com/id/1317983119/vector/vector-illustration-register-now-speech-bubble-label-internet-notification-register-now-sign.jpg?s=612x612&w=0&k=20&c=Nvja3xjFvD4NXlXis7un2B2vscvdTxKQL24t21v0NrA="
                                                class="img-fluid" alt="Sample image" />
                                        </div>

                                        <asp:Label ID="result" runat="server"></asp:Label>
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
