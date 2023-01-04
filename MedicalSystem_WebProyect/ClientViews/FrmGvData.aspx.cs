using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DomainModel;
using DataModel;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmGvData : System.Web.UI.Page
    {
        public int content;
        protected void Page_Load(object sender, EventArgs e)
        {
            content = int.Parse(Request.QueryString["content"]);
            Charge_GvData();
        }
        private void Charge_GvData()
        {
            if (content == 1)
            {
                AppointmentData appointmentData = new AppointmentData();
                GvData.DataSource = appointmentData.AppointmentListSP(); GvData.DataBind();
            }
            else if (content == 2)
            {
                MedicalData medicalData = new MedicalData();
                GvData2.DataSource = medicalData.Read_Patients_(int.Parse(Session["IdUser"].ToString())); GvData2.DataBind();
            }
        }
        private void Charge_GvData(List<Appointment>list)
        {
            GvData.DataSource = list;
            GvData.DataBind();
        }
        private void Charge_GvData(List<Patient> list)
        {
            GvData2.DataSource = list;
            GvData2.DataBind();
        }

        protected void GvData_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(GvData.SelectedRow.Cells[1].Text);
            Response.Redirect("FrmAppointmentRegister.aspx?Id=" + Id);
        }

        protected void GvData2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Id = int.Parse(GvData2.SelectedRow.Cells[1].Text);
            Response.Redirect("FrmMedicalPatientRegister.aspx?Id=" + Id);
        }

        protected void BtnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmClientMain.aspx");
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (content == 1) Response.Redirect("FrmAppointmentRegister.aspx");
            else if (content == 2) Response.Redirect("FrmMedicalPatientRegister.aspx");
        }

        protected void CkbAdvancedFilter_CheckedChanged(object sender, EventArgs e)
        {
            //refactorizacion: creo que con un array se podria simplificar(para pensar).
            if (CkbAdvancedFilter.Checked == true)
            {
                LblCamp.Visible = true;
                DdlCamp.Visible = true;
                LblCriterion.Visible = true;
                DdlCriterion.Visible = true;
                BtnApply.Visible = true;
                TxtFastFilter.Enabled = false;
            }
            if (CkbAdvancedFilter.Checked == false)
            {
                LblCamp.Visible = false;
                DdlCamp.Visible = false;
                LblCriterion.Visible = false;
                DdlCriterion.Visible = false;
                BtnApply.Visible = false;
                TxtFastFilter.Enabled = true;
            }
        }

        protected void TxtFastFilter_TextChanged(object sender, EventArgs e)
        {
            Helper helper = new Helper();
            if(content == 1)
            {
                AppointmentData appointmentData = new AppointmentData();
                Charge_GvData(helper.FastFilter(TxtFastFilter.Text, appointmentData.AppointmentListSP()));
            }
            else
            {
                MedicalData medicalData = new MedicalData();
                Charge_GvData(
                    helper.FastFilter(
                        TxtFastFilter.Text,
                        medicalData.Read_Patients_(
                            int.Parse(Session["IdUser"].ToString()))));
            }
        }
    }
}