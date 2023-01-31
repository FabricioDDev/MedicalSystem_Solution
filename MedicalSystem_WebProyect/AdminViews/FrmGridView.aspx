<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmGridView.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <style>
        .Title{
            font-size: 2em;
            color:white;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"></link>
    <title></title>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container">
            <div class="row" style="padding:20px;">
                <div class="col">
                    <!--btnExit-->
                    <asp:Button ID="BtnExit" CssClass="btn btn-danger" runat="server" OnClick="BtnExit_Click" Text="Exit" />
                </div>
                <div class="col">
                     <!--Buscador rapido-->
                     <asp:TextBox ID="TxtFastFilter" CssClass="form-control" OnTextChanged="TxtFastFilter_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
                </div>
                <div class="col">
                    <!--agregar-->
                    <asp:Button ID="BtnAdd" CssClass="btn btn-success" runat="server" Text="Add" OnClick="BtnAdd_Click" />
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <!--grilla-->
                    <asp:Label ID="LblTitle" CssClass="Title" runat="server" Text=""></asp:Label>
                </div>
            </div>
            <div class="row">
                <div class="col">
                    <asp:GridView ID="GvData" CssClass="table table-primary" runat="server" DataKeyNames="Id" OnRowDeleting="GvData_RowDeleting" OnSelectedIndexChanged="GvData_SelectedIndexChanged" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="FullName" HeaderText="Complete Name" />
                            <asp:BoundField DataField="Dni"  HeaderText="Dni"  />
                            <asp:CommandField ShowSelectButton="true"  HeaderText="Command" />
                            <asp:CommandField ShowDeleteButton="true"  HeaderText="Command"  />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
             <div style="display:flex; justify-content:center; align-content:center;">
                <!--Warning -->
                 <asp:Label ID="LblWarning" CssClass="alert alert-danger" Visible="false" runat="server" Text=""></asp:Label>
            </div>
            </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
