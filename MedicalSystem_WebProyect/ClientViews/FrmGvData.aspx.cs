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

        protected void GvData_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int IdToDelete = int.Parse(GvData.DataKeys[e.RowIndex].Value.ToString());
            AppointmentData appointmentData = new AppointmentData();
            appointmentData.AppointmentDeleteSP(IdToDelete);
            Charge_GvData();
        }
    }
}