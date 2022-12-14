<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmRegisterFromAdmin.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmRegisterFromAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblId" runat="server" Text="Id"></asp:Label>
            <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>

            <asp:Label ID="LblFullName" runat="server" Text="FullName"></asp:Label>
            <asp:TextBox ID="TxtFullName" runat="server"></asp:TextBox>

            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>

            <asp:Label ID="LblUserName" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>

            <asp:Label ID="LblPass" runat="server" Text="Pass"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>

            <asp:Label ID="LblDni" runat="server" Text="Dni"></asp:Label>
            <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox>

            <asp:Label ID="LblYears" runat="server" Text="Years"></asp:Label>
            <asp:TextBox ID="TxtYears" runat="server"></asp:TextBox>

            <asp:Label ID="LblMedicalPlan" runat="server" Text="MedicalPlan"></asp:Label>
            <asp:TextBox ID="TxtMedicalPlan" runat="server"></asp:TextBox>

            <asp:Label ID="LblPhoneNumber" runat="server" Text="Phone"></asp:Label>
            <asp:TextBox ID="TxtPhoneNumber" runat="server"></asp:TextBox>

            <asp:Label ID="LblAddress" runat="server" Text="Address"></asp:Label>
            <asp:TextBox ID="TxtAddress" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
