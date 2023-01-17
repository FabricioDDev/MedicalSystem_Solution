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

            <asp:Button ID="BtnBack" runat="server" OnClick="BtnBack_Click" Text="Back" />

            <!-- Filtro Rapido: por nombre-->
            <asp:TextBox ID="TxtFastFilter" AutoPostBack="true" OnTextChanged="TxtFastFilter_TextChanged" runat="server"></asp:TextBox>
           
            <%if (content == 1)
                { %>
                <asp:Button ID="BtnAdd" OnClick="BtnAdd_Click" runat="server" Text="Add" />
                <asp:CheckBox 
                    ID="CkbAdvancedFilter"
                    AutoPostBack="true"
                    OnCheckedChanged="CkbAdvancedFilter_CheckedChanged"
                    runat="server"
                    Text="Advanced Filter"/>

                    <!-- Filtro avanzado: turnocrud: por estado y tipo de consulta. -->

                    <asp:Label ID="LblCamp" runat="server" Text="Camp" Visible="false"></asp:Label>

                    <asp:DropDownList
                        ID="DdlCamp"
                        OnSelectedIndexChanged="DdlCamp_SelectedIndexChanged"
                        AutoPostBack="true"
                        runat="server"
                        Visible="false"></asp:DropDownList>
                   
                    <asp:Label ID="LblCriterion" runat="server" Text="Criterion" Visible="false"></asp:Label>
                    
                    <asp:DropDownList ID="DdlCriterion" runat="server" Visible="false"></asp:DropDownList>
                    
                    <asp:Button ID="BtnApply" OnClick="BtnApply_Click" runat="server" Text="Apply" Visible="false"/>
            
           

                    <!-- GvData con select y delete-->
                    <asp:GridView ID="GvData"
                        DataKeyNames="Id"
                        OnSelectedIndexChanged="GvData_SelectedIndexChanged"
                        AutoGenerateColumns="false"
                        runat="server">
                        <Columns>
                            <asp:CommandField ShowSelectButton="true" SelectText="select" HeaderText="command
                                " />
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
                    <asp:CheckBox
                        ID="CbxAddPatient"
                        AutoPostBack="true"
                        OnCheckedChanged="CbxAddPatient_CheckedChanged"
                        Text="Add Patient" runat="server" />
                    <asp:Label ID="LblPatients" Visible="false" runat="server" Text="Patient Name:"></asp:Label>
                    <asp:DropDownList ID="DdlPatients" Visible="false" runat="server"></asp:DropDownList>
                    <asp:Button ID="BtnAddPatient" OnClick="BtnAddPatient_Click" Visible="false" runat="server" Text="Add Patient" />
                    
                    <asp:GridView ID="GvData2" OnSelectedIndexChanged="GvData2_SelectedIndexChanged" runat="server">
                        <Columns>
                            
                            <asp:CommandField ShowSelectButton="true" SelectText="delete" HeaderText="command" />
                        </Columns>
                    </asp:GridView>
               <%} %>
            
        </div>
    </form>
</body>
</html>
