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
            <asp:Button ID="BtnDoc" runat="server" Text="Doctors" />
            <asp:Button ID="BtnPatient" runat="server" Text="Patients" />
            <asp:Button ID="BtnExit" runat="server" Text="Exit" />
        </div>
    </form>
</body>
</html>
