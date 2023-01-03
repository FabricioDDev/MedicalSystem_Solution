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
    }
}