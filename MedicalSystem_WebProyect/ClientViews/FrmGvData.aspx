<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmGvData.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmGvData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="BtnBack" runat="server" Text="Back" />
            <!-- Filtro Rapido: por nombre-->
            <asp:TextBox ID="TxtFastFilter" runat="server"></asp:TextBox>
            <!-- Filtro avanzado: turnocrud: por estado y tipo de consulta. -->
            <asp:DropDownList ID="DdlCamp" runat="server"></asp:DropDownList>
            <asp:DropDownList ID="DdlCriterion" runat="server"></asp:DropDownList>
            <asp:Button ID="BtnApply" runat="server" Text="Apply" />
            <!-- btn Add-->
            <asp:Button ID="BtnAdd" runat="server" Text="Add" />
            <!-- GvData con select y delete-->
            <%if (content == 1)
                { %>
                <asp:GridView ID="GvData" DataKeyNames="Id" OnSelectedIndexChanged="GvData_SelectedIndexChanged" AutoGenerateColumns="false" runat="server">
                    <Columns>
                        <asp:CommandField ShowSelectButton="true" SelectText="Select" HeaderText="command" />
                        <asp:BoundField DataField="Id" HeaderText="Id" />
                        <asp:BoundField DataField="patient" HeaderText="PatientName" />
                        <asp:BoundField DataField="medical" HeaderText="DoctorName" />
                        <asp:BoundField DataField="date" HeaderText="Date"/>
                        <asp:BoundField DataField="state" HeaderText="State"/>
                        <asp:BoundField DataField="query" HeaderText="QueryType"/>

                    </Columns>
                </asp:GridView>
            <%} %>

            <%else if (content == 2)
                { %>
                    <asp:GridView ID="GvData2" OnSelectedIndexChanged="GvData2_SelectedIndexChanged" runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="true" SelectText="Select" HeaderText="command" />
                        </Columns>
                    </asp:GridView>
               <%} %>
            
        </div>
    </form>
</body>
</html>
