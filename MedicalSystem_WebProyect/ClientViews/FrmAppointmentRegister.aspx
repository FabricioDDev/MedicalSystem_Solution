<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmAppointmentRegister.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmAppointmentRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .space{
            margin:10px;
        }
    </style>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container d-flex flex-column justify-content-center  align-items-center vh-100">
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col d-flex justify-content-center align-items-center">
                    <h1>Add</h1>
                </div>
            </div>
            <div class="row d-flex justify-content-center align-items-center">
                <div class="col flex-column justify-content-center align-items-center">
                    <asp:Label ID="LblId" CssClass="label-control" runat="server" Text="Id"></asp:Label>
                    <asp:TextBox ID="TxtId" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>

                    <asp:Label ID="LblDate" CssClass="label-control" runat="server" Text="Date"></asp:Label>
                    <asp:TextBox ID="TxtDate" CssClass="form-control" TextMode="Date" runat="server"></asp:TextBox>

                    <asp:Label ID="LblHour" CssClass="label-control" runat="server" Text="Hour"></asp:Label>
                    <asp:TextBox ID="TxtHour" CssClass="form-control" TextMode="Time" runat="server" ></asp:TextBox>
                </div>
                <div class="col flex-column justify-content-center align-items-center">
                    <asp:Label ID="LblDoctor" CssClass="label-control" runat="server" Text="Doctor"></asp:Label>
                    <asp:TextBox ID="TxtDoctor" CssClass="form-control" Enabled="false" runat="server"></asp:TextBox>

                    <asp:Label ID="LblPatient" CssClass="label-control" runat="server" Text="Patient"></asp:Label>
                    <asp:DropDownList ID="DdlPatient" CssClass="form-select" runat="server"></asp:DropDownList>

                    <asp:Label ID="LblState" CssClass="label-control" runat="server" Text="State"></asp:Label>
                    <asp:DropDownList ID="DdlState" CssClass="form-select" runat="server"></asp:DropDownList>

                    <asp:Label ID="LblQueryType" CssClass="label-control" runat="server" Text="Query Type"></asp:Label>
                    <asp:DropDownList ID="DdlQuery" CssClass="form-select" runat="server"></asp:DropDownList>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:Button ID="BtnSave" CssClass="btn btn-success space" OnClick="BtnSave_Click" runat="server" Text="Save" />
                    <asp:Button ID="BtnCancel" CssClass="btn btn-danger space" OnClick="BtnCancel_Click" runat="server" Text="Cancel" />
                </div>
            </div>
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
