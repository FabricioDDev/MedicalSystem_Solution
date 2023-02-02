<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUserConfig.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmUserConfig" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container vh-100 d-flex flex-column justify-content-center align-content-center" >
            <div class="row d-flex justify-content-center align-content-center">
                <div class="col d-flex justify-content-center align-content-center">
                    <h1>User Configuration</h1>
                </div>
            </div>
            <div class="row d-flex justify-content-center align-content-center">
                <div class="col d-flex flex-column justify-content-center align-content-center">
                    <div class="mb-3">
                        <asp:Label ID="LblId" CssClass="form-label" runat="server" Text="Id"></asp:Label>
                        <asp:TextBox ID="TxtId" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblFullName" CssClass="form-label" runat="server" Text="FullName"></asp:Label>
                        <asp:TextBox ID="TxtFullName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblUserName" CssClass="form-label" runat="server" Text="UserName"></asp:Label>
                        <asp:TextBox ID="TxtUserName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div> 
                </div>
                <div class="col">
                    <div class="mb-3">
                        <asp:Label ID="LblEmail" CssClass="form-label" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TxtEmail" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblPass" CssClass="form-label" runat="server" Text="Pass"></asp:Label>
                        <asp:TextBox ID="TxtPass" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblDni" CssClass="form-label" runat="server" Text="Dni"></asp:Label>
                        <asp:TextBox ID="TxtDni" CssClass="form-control" runat="server"></asp:TextBox>
                    </div> 
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="mb-3">
                        <asp:Button ID="BtnSave" CssClass="btn btn-success" OnClick="BtnSave_Click" runat="server" Text="Save" />
                        <asp:Button ID="BtnCancel" CssClass="btn btn-danger" OnClick="BtnCancel_Click" runat="server" Text="Cancel" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
