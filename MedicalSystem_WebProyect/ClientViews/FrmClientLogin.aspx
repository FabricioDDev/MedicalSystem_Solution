<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientLogin.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmClientLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
    <title></title>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container d-flex  justify-content-center  align-items-center vh-100" >
            <div class="row">
                <div class="col-auto">
                    <div class="mb-2">
                        <h1>Log In</h1>
                    </div>
                    <div class="mb-2">
                        <asp:Label ID="LblEmail_User" CssClass="label-control" runat="server" Text="Your Email/UserName:"></asp:Label>
                        <asp:TextBox ID="TxtEmail_User" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-2">
                        <asp:Label ID="LblPass" CssClass="label-control" runat="server" Text="Your Password:"></asp:Label>
                        <asp:TextBox ID="TxtPassword" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-2">
                        <asp:Label ID="LblSupport" CssClass="label-control" runat="server" Text="If you Lost your Account, Comunicate with the support."></asp:Label>
                    </div>
                    <div class="mb-2">
                        <asp:Button ID="BtnGo" CssClass="btn btn-success" OnClick="BtnGo_Click" runat="server" Text="Go" />
                        <asp:Button ID="BtnAsAdmin" CssClass="btn btn-primary" OnClick="BtnAsAdmin_Click" runat="server" Text="As Admin" />
                    </div>
               </div>
            </div>
            
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
