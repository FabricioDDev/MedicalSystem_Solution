﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmGridView.aspx.cs" Inherits="MedicalSystem_WebProyect.AdminViews.FrmGridView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <!--Buscador rapido-->
            <asp:TextBox ID="TxtFastFilter" OnTextChanged="TxtFastFilter_TextChanged" AutoPostBack="true" runat="server"></asp:TextBox>
            
            <!--agregar-->
            <asp:Button ID="BtnAdd" runat="server" Text="Button" />
            <!--grilla-->
            <asp:Label ID="LblTitle" runat="server" Text=""></asp:Label>
            <asp:GridView ID="GvData" runat="server" OnSelectedIndexChanged="GvData_SelectedIndexChanged" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="FullName" />
                    <asp:BoundField DataField="Dni" />
                    <asp:CommandField ShowSelectButton="true" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
