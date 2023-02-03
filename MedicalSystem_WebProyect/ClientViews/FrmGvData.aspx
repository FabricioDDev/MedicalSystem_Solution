<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmGvData.aspx.cs" Inherits="MedicalSystem_WebProyect.ClientViews.FrmGvData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style>
        .fuente{
            font-size:20px;
        }
        .espaciado{
            margin-right:15px;
        }
    </style>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous"/>
</head>
<body style="background-color:#0d1b2a; color:white;">
    <form id="form1" runat="server">
        <div class="container d-flex flex-column justify-content-center align-content-center">
            <div class="row d-flex flex-column justify-content-center align-content-center">
                <div class="col d-flex flex-row justify-content-flex-start align-content-center" style="border-bottom:solid 1px white;">
                    <div class="mb-3 d-flex flex-row espaciado">
                        <asp:Button ID="BtnBack" CssClass="btn btn-danger" runat="server" OnClick="BtnBack_Click" Text="Back" />
                    </div>
                    <div class="mb-3 d-flex flex-row espaciado">
                        <label class="fuente">Search</label>
                        <!-- Filtro Rapido: por nombre-->
                        <asp:TextBox ID="TxtFastFilter" CssClass="form-control form-control-sm" AutoPostBack="true" OnTextChanged="TxtFastFilter_TextChanged" runat="server"></asp:TextBox>
                    </div>
                </div>
            </div>

            
            <%if (content == 1)
                { %>
                <div class="row d-flex justify-content-center align-content-center">
                    <div class="col d-flex flex-row justify-content-space-between align-content-center">
                        <div class="mb-3">
                             <asp:Button ID="BtnAdd" CssClass="btn btn-success espaciado" OnClick="BtnAdd_Click" runat="server" Text="Add" />
                            
                        </div>
                        <div class="mb-3 d-flex flex-row justify-content-space-between espaciado align-content-center" style="border:solid 1px white; padding:5px; border-radius:10px;">
                             
                                <asp:CheckBox 
                                ID="CkbAdvancedFilter"
                                CssClass="form-checkbox-input espaciado" 
                                AutoPostBack="true"
                                OnCheckedChanged="CkbAdvancedFilter_CheckedChanged"
                                runat="server"
                                Text="Advanced Filter"/>

                                <asp:Label ID="LblCamp" CssClass="form-label fuente" runat="server" Text="Camp" Visible="false"></asp:Label>

                                <asp:DropDownList
                                    ID="DdlCamp"
                                    CssClass="form-select-sm"
                                    OnSelectedIndexChanged="DdlCamp_SelectedIndexChanged" 
                                    AutoPostBack="true"
                                    runat="server"
                                    Visible="false"></asp:DropDownList>
                   
                                <asp:Label ID="LblCriterion" CssClass="form-label fuente" runat="server" Text="Criterion" Visible="false"></asp:Label>
                    
                                <asp:DropDownList ID="DdlCriterion" CssClass="form-select-sm" runat="server" Visible="false"></asp:DropDownList>
                    
                                <asp:Button ID="BtnApply" CssClass="btn btn-success" OnClick="BtnApply_Click" runat="server" Text="Apply" Visible="false"/>
                        </div>
                      </div>
                </div>
               
                <div class="row">
                    <div class="col">
                        <!-- GvData con select y delete-->
                        <asp:GridView ID="GvData"
                            DataKeyNames="Id"
                            OnSelectedIndexChanged="GvData_SelectedIndexChanged"
                            AutoGenerateColumns="false"
                             CssClass="table table-primary" 
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
                    </div>
                </div>
                    
            <%} %>
            <%else if (content == 2)
                { %>
                <div class="row">
                    <div class="col">
                        <div style="border:solid 1px white; border-radius:10px; padding:10px;">
                            <asp:CheckBox
                        ID="CbxAddPatient"
                        AutoPostBack="true"
                        CssClass="form-checkbox-input"
                        OnCheckedChanged="CbxAddPatient_CheckedChanged"
                        Text="Add Patient" runat="server" />
                        <asp:Label ID="LblPatients" CssClass="form-label" Visible="false" runat="server" Text="Patient Name:"></asp:Label>
                        <asp:DropDownList ID="DdlPatients" CssClass="form-select-sm"  Visible="false" runat="server"></asp:DropDownList>
                        <asp:Button ID="BtnAddPatient" CssClass="btn btn-primary" OnClick="BtnAddPatient_Click" Visible="false" runat="server" Text="Add Patient" />
                    
                        </div>
                        
                    </div>
                </div>
                <div class="row">
                    <div class="col">
                        <asp:GridView ID="GvData2"  CssClass="table table-primary" OnSelectedIndexChanged="GvData2_SelectedIndexChanged" runat="server">
                        <Columns>
                            
                            <asp:CommandField ShowSelectButton="true" SelectText="delete" HeaderText="command" />
                        </Columns>
                        </asp:GridView>
                    </div>
                </div>
               <%} %>
            
        </div>
    </form>
    <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
</body>
</html>
