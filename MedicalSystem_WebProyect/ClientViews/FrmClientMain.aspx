<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientMain.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmClientMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--labellink con el nombre de usuario, y logo de config cuenta -->
            <asp:LinkButton ID="LkbUserConfig" runat="server"></asp:LinkButton>
            <a href="#">logo</a>
            <!-- btn mis turnos: mandar content 1-->
            <asp:Button ID="BtnAppointment" runat="server" Text="Appointments" />
            <!-- btn mis pacientes: mandar content 2-->
            <asp:Button ID="BtnPatient" runat="server" Text="Patients" />
            <!-- btn exit-->
            <asp:Button ID="BtnExit" OnClick="BtnExit_Click" runat="server" Text="Exit" />
        </div>
    </form>
</body>
</html>
