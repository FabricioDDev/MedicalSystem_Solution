﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientLogin.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmClientLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TxtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <asp:Button ID="BtnGo" OnClick="BtnGo_Click" runat="server" Text="Go" />
            <asp:Label ID="LblSupport" runat="server" Text="If you Lost your Account, Comunicate with the support."></asp:Label>
        </div>
    </form>
</body>
</html>
