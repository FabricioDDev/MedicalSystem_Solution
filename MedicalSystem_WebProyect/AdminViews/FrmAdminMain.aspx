<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAdminMain.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmAdminMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"></link>
    <title></title>
</head>
<body style="background-color:#0d1b2a; color:white;" >
    <form id="form1" runat="server">
        <div class="container d-flex text-center justify-content-center align-items-center vh-100"  style="display:flex; flex-flow:column nowrap;">
            <div class="row">
                <div class="col-auto">
                    <h1>DashBoard</h1>
                </div>
            </div>
            <div class="row">
                <div class="col-auto">
                    <div class="mb-3">
                        <asp:Button ID="BtnDoc" CssClass="btn btn-success" OnClick="BtnDoc_Click" runat="server" Text="Doctors" />
                        <asp:Button ID="BtnPatient" CssClass="btn btn-success" OnClick="BtnPatient_Click" runat="server" Text="Patients" />
                        <asp:Button ID="BtnExit" CssClass="btn btn-success" OnClick="BtnExit_Click" runat="server" Text="Exit" />
                    </div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
