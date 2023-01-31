<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegisterFromAdmin.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmRegisterFromAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
    <title></title>
    <style>
       .title{
           font-size:2em;
           padding:20px;
       }
    </style>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container vh-100" >
            <div class="row">
                <div class="col">
                    <div class="mb-3">
                        <asp:Label ID="LblTitle" CssClass="title" runat="server" Text="Add"></asp:Label>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <div class="mb-3">
                        <asp:Label ID="LblId" CssClass="label-control" runat="server"  Enabled="false" Text="Id"></asp:Label>
                        <asp:TextBox ID="TxtId" runat="server" CssClass="form-control numericControll"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblFullName" CssClass="label-control" runat="server" Text="FullName"></asp:Label>
                        <asp:TextBox ID="TxtFullName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblEmail" CssClass="label-control" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TxtEmail" CssClass="form-control" TextMode="Email" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblUserName" CssClass="label-control" runat="server" Text="UserName"></asp:Label>
                        <asp:TextBox ID="TxtUserName" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblPass" CssClass="label-control" runat="server" Text="Pass"></asp:Label>
                        <asp:TextBox ID="TxtPass" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    
                </div>
                <div class="col">
                    <div class="mb-3">
                        <asp:Label ID="LblYears"  CssClass="label-control" runat="server" Text="Years"></asp:Label>
                        <asp:TextBox ID="TxtYears"  runat="server" CssClass="form-control numericControll" TextMode="Number"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblMedicalPlan" CssClass="label-control" runat="server" Text="MedicalPlan"></asp:Label>
                        <asp:TextBox ID="TxtMedicalPlan" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblPhoneNumber" CssClass="label-control" runat="server" Text="Phone"></asp:Label>
                        <asp:TextBox ID="TxtPhoneNumber"  TextMode="Phone" CssClass="form-control numericControll" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblAddress" CssClass="label-control" runat="server" Text="Address"></asp:Label>
                        <asp:TextBox ID="TxtAddress" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="mb-3">
                        <asp:Label ID="LblDni" CssClass="label-control" runat="server" Text="Dni"></asp:Label>
                        <asp:TextBox ID="TxtDni"  runat="server" CssClass=" form-control numericControll"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="BtnAdd" CssClass="btn btn-success" OnClick="BtnAdd_Click" runat="server" Text="Add" />
                    <asp:Button ID="BtnCancel" CssClass="btn btn-danger" OnClick="BtnCancel_Click" runat="server" Text="Cancel" />
                    <asp:Label ID="LblWarning" CssClass="" runat="server" Text=""></asp:Label>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
