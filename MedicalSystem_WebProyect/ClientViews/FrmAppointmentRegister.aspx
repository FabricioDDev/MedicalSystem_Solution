<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAppointmentRegister.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmAppointmentRegister" %>

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

            <asp:Label ID="LblDate" runat="server" Text="Date"></asp:Label>
            <asp:TextBox ID="TxtDate" runat="server"></asp:TextBox>

            <asp:Label ID="LblDoctor" runat="server" Text="Doctor"></asp:Label>
            <asp:TextBox ID="TxtDoctor" runat="server"></asp:TextBox>

            <asp:Label ID="LblPatient" runat="server" Text="Patient"></asp:Label>
            <asp:DropDownList ID="DdlPatient" Enabled="true" runat="server"></asp:DropDownList>

            <asp:Label ID="LblState" runat="server" Text="State"></asp:Label>
            <asp:DropDownList ID="DdlState" runat="server"></asp:DropDownList>

            <asp:Label ID="LblQueryType" runat="server" Text="Query Type"></asp:Label>
            <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>

            <asp:Button ID="BtnSave" runat="server" Text="Save" />

            <asp:Button ID="BtnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
