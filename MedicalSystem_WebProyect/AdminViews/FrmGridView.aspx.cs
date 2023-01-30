using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;
using System.Runtime.Remoting.Messaging;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmGridView : System.Web.UI.Page
    {
        private int Content = 0;
        private MedicalData medicalData;
        private PatientData patientData;
        private List<Patient> patientList;
        private List<Medical> medicalList;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["Admin"] == null) Response.Redirect("FrmAdminLogin.aspx", false);
                if (Session["Error"] != null) Response.Redirect("../FrmError.aspx", false);

                Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
                Data();
                if (Content == 1 && !IsPostBack) { gv_Visibility(medicalList); GV_Charge(medicalList); }
                else if (Content == 2 && !IsPostBack) { gv_Visibility(patientList); GV_Charge(patientList); }
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }
        private void Data()
        {
            try
            {
                if (Content == 1) { medicalData = new MedicalData(); medicalList = medicalData.List(); }
                else { patientData = new PatientData(); patientList = patientData.PatientList(); }
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }
        private bool exist_Elements(List<Patient>List)
        {
          return  List.Count > 0? true : false;
        }
        private bool exist_Elements(List<Medical> List)
        {
            return List.Count > 0 ? true : false;
        }
        private void gv_Visibility(List<Patient>List)
        {
            if (exist_Elements(List)) { GvData.Visible= true; }
            else { GvData.Visible= false; LblWarning.Text = "Dont Have Patient Yet"; }
        }
        private void gv_Visibility(List<Medical> List)
        {
            if (exist_Elements(List)) { GvData.Visible = true; }
            else { GvData.Visible = false; LblWarning.Text = "Dont have Doctors yet"; }
        }

        private void GV_Charge(List<Medical>List)
        {
            try
            {
                Data();
                GvData.DataSource = List;
                GvData.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }
        private void GV_Charge(List<Patient> List)
        {
            try
            {
                Data();
                GvData.DataSource = List;
                GvData.DataBind();
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }
        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var Id = GvData.SelectedDataKey.Value.ToString();
                Response.Redirect("FrmRegisterFromAdmin.aspx?Id=" + Id + "&&content=" + Content);
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }

        protected void TxtFastFilter_TextChanged(object sender, EventArgs e)
        {
            FastFilter();
        }
        private void FastFilter()
        {
            Helper helper = new Helper();
            try
            {
                if (Content == 1) GV_Charge(helper.FastFilter(TxtFastFilter.Text, medicalData.List()));
                else GV_Charge(helper.FastFilter(TxtFastFilter.Text, patientData.PatientList()));
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }

        protected void BtnExit_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmAdminMain.aspx", false);
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmRegisterFromAdmin.aspx?content=" + Content);
        }

        protected void GvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                int Id = int.Parse(GvData.DataKeys[e.RowIndex].Value.ToString());
                if (Content == 1) { medicalData.MedicalDeleteSP(Id); Data(); GV_Charge(medicalList); gv_Visibility(medicalList); }
                else if (Content == 2) { patientData.PatientDelete(Id); Data(); GV_Charge(patientList); gv_Visibility(patientList); }
            }
            catch (Exception ex)
            {
                Session.Add("../FrmError.aspx", ex.ToString());
            }
        }
    }
}