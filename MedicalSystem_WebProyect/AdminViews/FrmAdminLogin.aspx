<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdminLogin.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmAdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"></link>
    <title></title>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container d-flex justify-content-center align-items-center vh-100" >
            
            <div class="row">
                <div class="col-auto">
                    <div class="mb-3">
                        <asp:Label ID="LblWarning" Visible="false" CssClass="alert alert-danger" runat="server" Text=""></asp:Label>
                    </div>
                    <div class="mb-3">
                        <h1>Admin Log In</h1>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblEmail" CssClass="form-label" runat="server" Text="Your Email:"></asp:Label>
                        <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                        <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblPass" CssClass="form-label"  runat="server" Text="Your Pass:"></asp:Label>
                        <asp:TextBox ID="TxtPass" CssClass="form-control" TextMode="Password" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Button runat="server" CssClass="btn btn-success" OnClick="BtnGo_Click" ID="BtnGo" Text="Go" />
                        <asp:Button runat="server" ID="BtnClient" CssClass="btn btn-primary" OnClick="BtnClient_Click" Text="As Doctor" />
                    </div>    
                </div>
            </div>
            
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>

           
        
            
            

