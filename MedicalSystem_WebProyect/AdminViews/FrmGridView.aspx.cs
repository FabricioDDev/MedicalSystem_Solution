using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace MedicalSystem_WebProyect.AdminViews
{
    public partial class FrmGridView : System.Web.UI.Page
    {
        private int Content = 0;
        private MedicalData medicalData;
        private PatientData patientData;
        protected void Page_Load(object sender, EventArgs e)
        {
            Content = Request.QueryString["content"] != null ? int.Parse(Request.QueryString["content"]) : 0;
            Data();
            GV_Charge();
        }
        private void Data()
        {
            if(Content == 1) medicalData= new MedicalData();
            else patientData= new PatientData();
        }
        private void GV_Charge()
        {
            if (Content == 1)
            {
                GvData.DataSource = medicalData.ListSP();
                LblTitle.Text = "Doctors";
            }
            else if (Content == 2)
            {
                GvData.DataSource = patientData.PatientListSP();
                LblTitle.Text = "Patients";
            }
            GvData.DataBind();
        }
        private void GV_Charge(List<Medical>List)
        {
            GvData.DataSource = List;
            GvData.DataBind();
        }
        private void GV_Charge(List<Patient> List)
        {
            GvData.DataSource = List;
            GvData.DataBind();
        }


        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Id = GvData.SelectedDataKey.Value.ToString();
            Response.Redirect("FrmRegisterFromAdmin.aspx?Id=" + Id + "&&content=" + Content);
        }

        protected void TxtFastFilter_TextChanged(object sender, EventArgs e)
        {
            FastFilter();
        }
        private void FastFilter()
        {
            Helper helper = new Helper();
            if (Content == 1) GV_Charge(helper.FastFilter(TxtFastFilter.Text, medicalData.ListSP()));
            else GV_Charge(helper.FastFilter(TxtFastFilter.Text, patientData.PatientListSP()));
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
            int Id = int.Parse(GvData.DataKeys[e.RowIndex].Value.ToString());
            if (Content == 1) medicalData.MedicalDeleteSP(Id);
            else patientData.PatientDelete(Id);
        }
    }
}