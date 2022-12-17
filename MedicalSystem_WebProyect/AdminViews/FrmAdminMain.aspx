<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdminMain.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmAdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnDoc" OnClick="BtnDoc_Click" runat="server" Text="Doctors" />
            <asp:Button ID="BtnPatient" OnClick="BtnPatient_Click" runat="server" Text="Patients" />
            <asp:Button ID="BtnExit" OnClick="BtnExit_Click" runat="server" Text="Exit" />
        </div>
    </form>
</body>
</html>
