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
            if(content == 1)
            {
                AppointmentData appointmentData= new AppointmentData();
                GvData.DataSource = appointmentData.AppointmentListSP(); GvData.DataBind();
            }
            else if(content == 2)
            {
                //error en la funcion
                MedicalData medicalData = new MedicalData();
                GvData2.DataSource = medicalData.Read_Patients_(int.Parse(Session["IdUser"].ToString())); GvData2.DataBind();
            }
        }
    }
}