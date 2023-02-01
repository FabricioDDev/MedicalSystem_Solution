<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmClientMain.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmClientMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .options{
            margin:10px;
        }

        .LkbUserConfig{
            text-decoration: none;
            color:white;
            font-size:1em;
        }
        .logo{
            color:white;
            font-size:1em;
        }
    </style>
     <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container d-flex justify-content-center align-item-center flex-column vh-100">
            <div class="row d-flex justify-content-center align-item-center">
                <div class="col d-flex justify-content-center align-item-center">
                      <!--labellink con el nombre de usuario, y logo de config cuenta -->
                        <div class="mb-3 btn btn-success d-flex justify-content-center align-item-center">
                        <asp:LinkButton ID="LkbUserConfig" CssClass="LkbUserConfig"  OnClick="LkbUserConfig_Click" runat="server"></asp:LinkButton>
                        <a href="FrmUserConfig.aspx"><i class="fa-solid fa-user-pen logo"></i></a>
                        </div>
                </div>
            </div>
            <div class=" row d-flex justify-content-center align-item-center">
                <div class="col d-flex justify-content-center align-item-center">
                    <div class="mb-3 d-flex justify-content-center align-item-center">
                        <!-- btn mis turnos: mandar content 1-->
                        <asp:Button ID="BtnAppointment" CssClass="btn btn-success options" OnClick="BtnAppointment_Click" runat="server" Text="Appointments" />
                        <!-- btn mis pacientes: mandar content 2-->
                        <asp:Button ID="BtnPatient" CssClass="btn btn-success options" OnClick="BtnPatient_Click" runat="server" Text="Patients" />
                        <!-- btn exit-->
                        <asp:Button ID="BtnExit" CssClass="btn btn-danger options" OnClick="BtnExit_Click" runat="server" Text="Exit" /></div>
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
    <script src="https://kit.fontawesome.com/d12df09837.js" crossorigin="anonymous"></script>
</body>
</html>
