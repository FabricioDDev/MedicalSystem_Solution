<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdminLogin.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmAdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LblWarning" runat="server" Text=""></asp:Label>
            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
            <asp:Label ID="LblPass"  runat="server" Text="Pass"></asp:Label>
            <asp:TextBox ID="TxtPass" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button runat="server" OnClick="BtnGo_Click" ID="BtnGo" Text="Go" />
            <asp:Button runat="server" ID="BtnClient" OnClick="BtnClient_Click" Text="As Doctor" />
        </div>
    </form>
</body>
</html>

