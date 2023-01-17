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
            <asp:Label ID="LblUserName" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="TxtUserName" runat="server"></asp:TextBox>

            <asp:Label ID="LblPass" runat="server" Text="Pass"></asp:Label>
            <asp:TextBox ID="TxtPass" runat="server"></asp:TextBox>

            <asp:Label ID="LblPassConfirm" runat="server" Text="Confirm the Pass"></asp:Label>
            <asp:TextBox ID="TxtPassConfirm" runat="server"></asp:TextBox>

            <asp:Button ID="BtnSave" runat="server" Text="Save" />
            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
