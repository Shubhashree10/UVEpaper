<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UVEpaper.Login" %>

<!DOCTYPE html>
<html lang="en" dir="ltr">

<head>
    

    <meta charset="utf-8" />
            <title>Udayavani - Admin & Dashboard Template</title>
            <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
            <meta content="Premium Multipurpose Admin & Dashboard Template" name="description" />
            <meta content="" name="author" />
            <meta http-equiv="X-UA-Compatible" content="IE=edge" />

            <!-- App favicon -->
            <link rel="shortcut icon" href="assets/images/favicon.ico">

       

     <!-- App css -->
     <link href="assets/css/bootstrap.min.css" rel="stylesheet" type="text/css" />
     <link href="assets/css/icons.min.css" rel="stylesheet" type="text/css" />
     <link href="assets/css/app.min.css" rel="stylesheet" type="text/css" />

</head>

<body id="body" class="auth-page card-bg">
    <form id="frmLogin" runat="server">
   <!-- Log In page -->
    <div class="container-fluid">
        <div class="row vh-100">
            <div class="col-12">
                <div class="card-body p-0">
                    <div class="row d-flex align-items-center">
                        <div class="col-md-5 col-xl-3 col-lg-4">
                            <div class="card mb-0 border-0">
                                <div class="card-body p-0">
                                    <div class="text-center p-3">
                                        <a href="index.html" class="logo logo-admin">
                                            <img src="assets/images/logo-sm.png" height="50" alt="logo" class="auth-logo">
                                        </a>
                                        <h4 class="mt-3 mb-1 fw-semibold font-18">Explore the epapers</h4>   
                                        <p class="text-muted  mb-0">Sign in to continue to explore.</p>  
                                    </div>
                                </div><!--end card-body-->
                                <div class="card-body pt-0">                                    
                                    <div class="form-group mb-2">
                                        <label class="form-label" for="username">Username</label>
                                        <asp:TextBox ID="txtUsername" runat="server" CssClass="form-control" placeholder="Enter username"></asp:TextBox>
                                    </div><!--end form-group--> 
            
                                    <div class="form-group">
                                        <label class="form-label" for="userpassword">Password</label>
                                        <asp:TextBox ID="txtPassword" runat="server" CssClass="form-control" placeholder="Enter password" TextMode="Password"></asp:TextBox>
                                    </div><!--end form-group--> 
            
                                        
            
                                    <div class="form-group mb-0 row">
                                        <div class="col-12">
                                            <div class="d-grid mt-3">
                                                <asp:LinkButton ID="lnkLogin" runat="server" CssClass="btn btn-primary" OnClick="lnkLogin_Click">Log In <i class="fas fa-sign-in-alt ms-1"></i></asp:LinkButton>
                                            </div>
                                        </div><!--end col--> 
                                    </div> <!--end form-group-->    
                                    
                                    <div class="alert alert-danger border-0" role="alert" id="divMessage" runat="server">
                                        <asp:Label ID="lblMessage" runat="server"></asp:Label>
                                    </div>

                                </div><!--end card-body-->
                            </div><!--end card-->
                        </div><!--end col-->
                        <div class="col-md-7 col-xl-9 col-lg-8  p-0 vh-100 d-flex justify-content-center auth-bg">
                            <div class="accountbg d-flex align-items-center"> 
                                <div class="account-title text-center text-blue">
                                    <img src="assets/images/logo-sm.png" alt="" class="thumb-sm">
                                    <h4 class="mt-3 text-white">Welcome To <span class="text-warning">Udayavani</span> </h4>
                                    <h1 class="text-black"> Udayavani epapers</h1>
                                    <p class="font-21 mt-3">Udayavani.</p>
                                    <div class="border w-25 mx-auto border-warning"></div>
                                </div>
                            </div><!--end /div-->
                        </div><!--end col-->
                    </div><!--end row-->
                </div><!--end card-body-->
            </div><!--end col-->
        </div><!--end row-->
    </div><!--end container-->
    <!-- vendor js -->
    </form>

    <script src="assets/libs/bootstrap/js/bootstrap.bundle.min.js"></script>
    <script src="assets/libs/simplebar/simplebar.min.js"></script>
    <script src="assets/libs/feather-icons/feather.min.js"></script>
    <!-- App js -->
    <script src="assets/js/app.js"></script>
    
</body>

</html>
