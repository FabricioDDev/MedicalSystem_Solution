<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmUserConfig.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmUserConfig" %>

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
            <asp:TextBox ID="TxtId" Enabled="false" runat="server"></asp:TextBox>

            <asp:Label ID="LblFullName" runat="server" Text="FullName"></asp:Label>
            <asp:TextBox ID="TxtFullName" runat="server"></asp:TextBox>

            <asp:Label ID="LblUserName" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>

            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>

            <asp:Label ID="LblPass" runat="server" Text="Pass"></asp:Label>
            <asp:TextBox ID="TxtPass" Enabled="false" runat="server"></asp:TextBox>

            <asp:Label ID="LblDni" runat="server" Text="Dni"></asp:Label>
            <asp:TextBox ID="TxtDni" runat="server"></asp:TextBox>

            <asp:Button ID="BtnSave" OnClick="BtnSave_Click" runat="server" Text="Save" />
            <asp:Button ID="BtnCancel" OnClick="BtnCancel_Click" runat="server" Text="Cancel" />

        </div>
    </form>
</body>
</html>
