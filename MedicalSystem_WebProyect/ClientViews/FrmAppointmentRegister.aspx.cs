using DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataModel;

namespace MedicalSystem_WebProyect.ClientViews
{
    public partial class FrmAppointmentRegister : System.Web.UI.Page
    {
        private Medical User;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack) {
                ChargeUser();
                Charge_Ddl();
            }
            if (Request.QueryString["Id"] != null) ChargeControlls();

        }
        private void Charge_Ddl()
        {
            MedicalData medicalData = new MedicalData();
            StateData stateData = new StateData();
            QueryData queryData = new QueryData();

            DdlPatient.DataSource = medicalData.Read_Patients_(User.Id);
            DdlPatient.DataTextField = "FullName";
            DdlPatient.DataValueField = "Id";
            DdlPatient.DataBind();

            DdlState.DataSource = stateData.QueryList();
            DdlState.DataTextField = "Name";
            DdlState.DataValueField = "Id";
            DdlState.DataBind();

            DdlQuery.DataSource = queryData.QueryList();
            DdlQuery.DataTextField= "Name";
            DdlQuery.DataValueField= "IdQuery";
            DdlQuery.DataBind();
        }
        private void ChargeUser()
        {
            MedicalData medicalData = new MedicalData();
            Helper helper = new Helper();
            User = helper.SearchUser(
                int.Parse(Session["IdUser"].ToString()),
                medicalData.List()
                );
            TxtDoctor.Text = User.FullName;
        }
        private void ChargeControlls()
        {
            AppointmentData appointmentData = new AppointmentData();
            Appointment appointment = appointmentData.AppointmentListSP().Find(x => x.Id == int.Parse(Request.QueryString["Id"]));
            TxtId.Text = appointment.Id.ToString();
            TxtDate.Text = appointment.date.ToString("yyyy-MM-dd");
            TxtHour.Text = appointment.date.ToString("t");
            DdlPatient.SelectedValue = appointment.patient.Id.ToString();
            DdlState.SelectedValue= appointment.state.Id.ToString();
            DdlQuery.SelectedValue = appointment.query.IdQuery.ToString();
        }

        
    }
}